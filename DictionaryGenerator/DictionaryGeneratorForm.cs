using System;
using System.Collections.Generic;
using System.Windows.Forms;
using INF36207.TP2.PassGen;
using INF36207.TP2.Files;
using System.Linq;

namespace INF36207.TP2.DictionaryGenerator
{
    public partial class DictionaryGenerator : Form
    {

        public DictionaryGenerator()
        {
            InitializeComponent();
        }

        private void DictionaryGeneratorForm_Load(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK){
                lbLocation.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            string caracterList = "";
            int max = 0;
            int min = 0;

            // vérification 
            for (int i = 0; i < chBoxParam.Items.Count; i++)
            {
                if (chBoxParam.GetItemCheckState(i) == CheckState.Checked)
                {
                    caracterList += chBoxParam.Items[i].ToString();
                }
            }

            if (folderBrowserDialog.SelectedPath == "" ||
                txtMax.Text == "" || txtMin.Text == "" ||
                txtNomFichier.Text == "" || (caracterList == "" && txtCaracPerso.Text == ""))
            {
                MessageBox.Show("Veuillez remplir le form.");
                return;
            }
            if (!Int32.TryParse(txtMax.Text, out max))
            {
                MessageBox.Show("Longueur Maximale: erreur de convertion.");
                return;
            }
            if (!Int32.TryParse(txtMin.Text, out min))
            {
                MessageBox.Show("Longueur Minimale: erreur de convertion.");
                return;
            }
            if (max <= 0)
            {
                MessageBox.Show("Longueur maximale doit être plus grand que 0.");
                return;
            }
            if (min < 0)
            {
                MessageBox.Show("Longueur minimale doit être plus grand ou égal à 0.");
                return;
            }
            if (min > max)
            {
                MessageBox.Show("Longueur minimale ne peut pas être plus grand que la longuer maximale.");
                return;
            }
            if (txtCaracPerso.Text != "")
            {
                for (int i = 0; i < txtCaracPerso.Text.Length; i++)
                {
                    if (!caracterList.Contains(txtCaracPerso.Text[i]))
                    {
                        caracterList += txtCaracPerso.Text[i];
                    }
                }
            }
           
            PasswordDictionaryGenerator generator = new PasswordDictionaryGenerator();
            IEnumerable<string> list = generator.Generate(caracterList, min, max);

            PasswordDictionaryWriter writer = new PasswordDictionaryWriter();

            writer.Open(folderBrowserDialog.SelectedPath+ '\\' + txtNomFichier.Text + ".txt");
            if(!writer.IsOpened())
                return;

            writer.Write(list);

            writer.Close();

        }
    }
}
