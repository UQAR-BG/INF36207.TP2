using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace INF36207.TP2.Md5PasswordFinder
{
    public partial class PasswordDictionarySelectForm : Form
    {
        private Md5PasswordFinderForm _passwordFinderForm;

        public PasswordDictionarySelectForm()
        {
            InitializeComponent();
        }

        private void Md5PasswordFinderForm_Load(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;

            openFileDialog.InitialDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            _passwordFinderForm = new Md5PasswordFinderForm(openFileDialog.FileName);
            _passwordFinderForm.ShowDialog();
        }

        private void btnOuvrirFichier_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }
    }
}
