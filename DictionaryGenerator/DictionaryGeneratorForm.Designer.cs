namespace INF36207.TP2.DictionaryGenerator
{
    partial class DictionaryGenerator
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
            this.lbLongueurMinimale = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lbLongueurMaximale = new System.Windows.Forms.Label();
            this.chBoxParam = new System.Windows.Forms.CheckedListBox();
            this.lbCaractèresPermis = new System.Windows.Forms.Label();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.lblOuvrirFichier = new System.Windows.Forms.Label();
            this.txtNomFichier = new System.Windows.Forms.TextBox();
            this.lbNomFichier = new System.Windows.Forms.Label();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lbLocation = new System.Windows.Forms.Label();
            this.txtCaracPerso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLongueurMinimale
            // 
            this.lbLongueurMinimale.AutoSize = true;
            this.lbLongueurMinimale.Location = new System.Drawing.Point(29, 51);
            this.lbLongueurMinimale.Name = "lbLongueurMinimale";
            this.lbLongueurMinimale.Size = new System.Drawing.Size(96, 13);
            this.lbLongueurMinimale.TabIndex = 0;
            this.lbLongueurMinimale.Text = "Longueur Minimale";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(131, 48);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 1;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(131, 74);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 2;
            // 
            // lbLongueurMaximale
            // 
            this.lbLongueurMaximale.AutoSize = true;
            this.lbLongueurMaximale.Location = new System.Drawing.Point(29, 77);
            this.lbLongueurMaximale.Name = "lbLongueurMaximale";
            this.lbLongueurMaximale.Size = new System.Drawing.Size(99, 13);
            this.lbLongueurMaximale.TabIndex = 3;
            this.lbLongueurMaximale.Text = "Longueur Maximale";
            // 
            // chBoxParam
            // 
            this.chBoxParam.FormattingEnabled = true;
            this.chBoxParam.Items.AddRange(new object[] {
            "abcdefghijklmnopqrstuvwxyz",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            "1234567890",
            "!",
            "@",
            "#",
            "$",
            "%",
            "?",
            "&",
            "*"});
            this.chBoxParam.Location = new System.Drawing.Point(296, 48);
            this.chBoxParam.Name = "chBoxParam";
            this.chBoxParam.Size = new System.Drawing.Size(242, 154);
            this.chBoxParam.TabIndex = 4;
            // 
            // lbCaractèresPermis
            // 
            this.lbCaractèresPermis.AutoSize = true;
            this.lbCaractèresPermis.Location = new System.Drawing.Point(368, 21);
            this.lbCaractèresPermis.Name = "lbCaractèresPermis";
            this.lbCaractèresPermis.Size = new System.Drawing.Size(92, 13);
            this.lbCaractèresPermis.TabIndex = 5;
            this.lbCaractèresPermis.Text = "Caractères Permis";
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(64, 166);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(121, 23);
            this.btnSelectionner.TabIndex = 7;
            this.btnSelectionner.Text = "Sélectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // lblOuvrirFichier
            // 
            this.lblOuvrirFichier.AutoSize = true;
            this.lblOuvrirFichier.Location = new System.Drawing.Point(29, 133);
            this.lblOuvrirFichier.Name = "lblOuvrirFichier";
            this.lblOuvrirFichier.Size = new System.Drawing.Size(196, 13);
            this.lblOuvrirFichier.TabIndex = 6;
            this.lblOuvrirFichier.Text = "Veuillez sélectionner le dossier de sortie.";
            // 
            // txtNomFichier
            // 
            this.txtNomFichier.Location = new System.Drawing.Point(54, 271);
            this.txtNomFichier.Name = "txtNomFichier";
            this.txtNomFichier.Size = new System.Drawing.Size(121, 20);
            this.txtNomFichier.TabIndex = 8;
            // 
            // lbNomFichier
            // 
            this.lbNomFichier.AutoSize = true;
            this.lbNomFichier.Location = new System.Drawing.Point(29, 237);
            this.lbNomFichier.Name = "lbNomFichier";
            this.lbNomFichier.Size = new System.Drawing.Size(173, 13);
            this.lbNomFichier.TabIndex = 9;
            this.lbNomFichier.Text = "Veuillez nommez le fichier de sortie.";
            // 
            // btnGenerer
            // 
            this.btnGenerer.Location = new System.Drawing.Point(349, 268);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(121, 23);
            this.btnGenerer.TabIndex = 10;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(39, 205);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(0, 13);
            this.lbLocation.TabIndex = 11;
            // 
            // txtCaracPerso
            // 
            this.txtCaracPerso.Location = new System.Drawing.Point(417, 230);
            this.txtCaracPerso.Name = "txtCaracPerso";
            this.txtCaracPerso.Size = new System.Drawing.Size(121, 20);
            this.txtCaracPerso.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Caractères Personalisés:";
            // 
            // DictionaryGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaracPerso);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.lbNomFichier);
            this.Controls.Add(this.txtNomFichier);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.lblOuvrirFichier);
            this.Controls.Add(this.lbCaractèresPermis);
            this.Controls.Add(this.chBoxParam);
            this.Controls.Add(this.lbLongueurMaximale);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lbLongueurMinimale);
            this.Name = "DictionaryGenerator";
            this.Text = "DictionaryGenerator";
            this.Load += new System.EventHandler(this.DictionaryGeneratorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLongueurMinimale;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lbLongueurMaximale;
        private System.Windows.Forms.CheckedListBox chBoxParam;
        private System.Windows.Forms.Label lbCaractèresPermis;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Label lblOuvrirFichier;
        private System.Windows.Forms.TextBox txtNomFichier;
        private System.Windows.Forms.Label lbNomFichier;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.TextBox txtCaracPerso;
        private System.Windows.Forms.Label label1;
    }
}

