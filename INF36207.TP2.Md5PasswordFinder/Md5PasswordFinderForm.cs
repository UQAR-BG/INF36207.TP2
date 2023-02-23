using INF36207.TP2.Enums;
using INF36207.TP2.Files;
using INF36207.TP2.Hashing;
using INF36207.TP2.Utils;
using System;
using System.Reflection.Emit;
using System.Threading;
using System.Windows.Forms;

namespace INF36207.TP2.Md5PasswordFinder
{
    public partial class Md5PasswordFinderForm : Form
    {
        private readonly IHasher _hasher;
        private PasswordDictionaryReader _reader;
        private readonly string _passwordFileName;

        private int timeElapsed;

        public Md5PasswordFinderForm(string passwordFileName)
        {
            InitializeComponent();

            IHasherFactory hasherFactory = new HasherFactory();
            _hasher = hasherFactory.GetHasher(HashingStrategies.Md5);
            _passwordFileName = passwordFileName;
        }

        private void Md5PasswordFinderForm_Load(object sender, EventArgs e)
        {
            _reader = new PasswordDictionaryReader(_passwordFileName);

            lblNbreMots.Text = "Mots dans le dictionnaire : " + _reader.GetNumberOfLines();
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            lblCountdown.Text = "Temps écoulé : " + TimeUtils.GetTimeElapsed(timeElapsed);
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
    }
}
