using INF36207.TP2.Enums;
using INF36207.TP2.Files;
using INF36207.TP2.Hashing;
using INF36207.TP2.Utils;
using System;
using System.Reflection.Emit;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INF36207.TP2.Md5PasswordFinder
{
    public partial class Md5PasswordFinderForm : Form
    {
        private readonly IHasher _hasher;
        private delegate void SafeCallDelegate(string text);
        private PasswordDictionaryReader _reader;
        private readonly string _passwordFileName;
        private int timeElapsed;
        private static System.Timers.Timer countdown;
        public Md5PasswordFinderForm(string passwordFileName)
        {
            InitializeComponent();

            IHasherFactory hasherFactory = new HasherFactory();
            _hasher = hasherFactory.GetHasher(HashingStrategies.Md5);
            _passwordFileName = passwordFileName;

            countdown = new System.Timers.Timer();
            countdown.Interval = 1000;
            countdown.Elapsed += countdown_Tick;
            countdown.Enabled = false;
            countdown.AutoReset = true;
        }

        private void Md5PasswordFinderForm_Load(object sender, EventArgs e)
        {
            _reader = new PasswordDictionaryReader(_passwordFileName);

            lblNbreMots.Text = "Mots dans le dictionnaire : " + _reader.GetNumberOfLines();
        }


        private void btnHash_Click(object sender, EventArgs e)
        {
            lblCountdown.Text = "Temps écoulé : " + TimeUtils.GetTimeElapsed(0);

            timeElapsed = 0;
            countdown.Enabled = true;

            _reader = new PasswordDictionaryReader(_passwordFileName);

            Thread procThread = new Thread(this.TryForceMd5PasswordHash);
            procThread.Start();
        }

        private void Md5PasswordFinderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopTimer();
        }

        private void TryForceMd5PasswordHash()
        {
            bool passwordFound = false;
            int nbrOfPasswords = _reader.GetNumberOfLines();
            int counter = 0;
            string password = "";
            string hash = txtHash.Text.ToUpper();

            while (!passwordFound && counter < nbrOfPasswords)
            {
                    password = _reader.ReadLine();
                    string hashedPassword = _hasher.ComputeHash(password);

                    if (hashedPassword.Equals(hash))
                    {
                        passwordFound = true;
                    }

                    counter++;
                    Invoke((MethodInvoker)delegate { lblTentatives.Text = $"Tentatives : {counter} / {nbrOfPasswords}"; });
            }

            StopTimer();

            if (passwordFound)
            {
                MessageBox.Show($"Votre hachage: \n{hash}\n\nCorrespond au mot suivant :\n{password}"
                    , "Félicitations !!!"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("Le mot de passe n'existe pas dans le dictionnaire fourni."
                    , "Dommage..."
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }

        private void StopTimer()
        {
            countdown.Stop();
            countdown.Enabled = false;
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            string Countdown = "Temps écoulé : " + TimeUtils.GetTimeElapsed(timeElapsed);
            WriteTextSafe(Countdown);
        }
        // this come from: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-make-thread-safe-calls-to-windows-forms-controls?view=netframeworkdesktop-4.8
        private void WriteTextSafe(string text)
        {
            if (lblCountdown.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                lblCountdown.Invoke(d, new object[] { text });
            }
            else
            {
                lblCountdown.Text = text;
            }
        }
    }
}
