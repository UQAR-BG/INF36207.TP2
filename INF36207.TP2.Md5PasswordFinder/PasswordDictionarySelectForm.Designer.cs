namespace INF36207.TP2.Md5PasswordFinder
{
    partial class PasswordDictionarySelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblOuvrirFichier = new System.Windows.Forms.Label();
            this.btnOuvrirFichier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // lblOuvrirFichier
            // 
            this.lblOuvrirFichier.AutoSize = true;
            this.lblOuvrirFichier.Location = new System.Drawing.Point(84, 58);
            this.lblOuvrirFichier.Name = "lblOuvrirFichier";
            this.lblOuvrirFichier.Size = new System.Drawing.Size(284, 13);
            this.lblOuvrirFichier.TabIndex = 0;
            this.lblOuvrirFichier.Text = "Veuillez sélectionner un dictionnaire de mots de passe (.txt)";
            // 
            // btnOuvrirFichier
            // 
            this.btnOuvrirFichier.Location = new System.Drawing.Point(163, 91);
            this.btnOuvrirFichier.Name = "btnOuvrirFichier";
            this.btnOuvrirFichier.Size = new System.Drawing.Size(121, 23);
            this.btnOuvrirFichier.TabIndex = 1;
            this.btnOuvrirFichier.Text = "Ouvrir";
            this.btnOuvrirFichier.UseVisualStyleBackColor = true;
            this.btnOuvrirFichier.Click += new System.EventHandler(this.btnOuvrirFichier_Click);
            // 
            // Md5PasswordFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 161);
            this.Controls.Add(this.btnOuvrirFichier);
            this.Controls.Add(this.lblOuvrirFichier);
            this.Name = "Md5PasswordFinderForm";
            this.Text = "Application pour forcer un mot de passe encrypté en MD5";
            this.Load += new System.EventHandler(this.Md5PasswordFinderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblOuvrirFichier;
        private System.Windows.Forms.Button btnOuvrirFichier;
    }
}

