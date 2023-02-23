namespace INF36207.TP2.Md5PasswordFinder
{
    partial class Md5PasswordFinderForm
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
            this.components = new System.ComponentModel.Container();
            this.lblNbreMots = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.panelNbrMots = new System.Windows.Forms.Panel();
            this.picCadenas = new System.Windows.Forms.PictureBox();
            this.lblHash = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.lblTentatives = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.panelNbrMots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCadenas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNbreMots
            // 
            this.lblNbreMots.AutoSize = true;
            this.lblNbreMots.Location = new System.Drawing.Point(250, 6);
            this.lblNbreMots.Name = "lblNbreMots";
            this.lblNbreMots.Size = new System.Drawing.Size(133, 13);
            this.lblNbreMots.TabIndex = 0;
            this.lblNbreMots.Text = "Mots dans le dictionnaire : ";
            // 
            // countdown
            // 
            this.countdown.Interval = 1000;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // panelNbrMots
            // 
            this.panelNbrMots.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelNbrMots.Controls.Add(this.lblNbreMots);
            this.panelNbrMots.Location = new System.Drawing.Point(0, 117);
            this.panelNbrMots.Name = "panelNbrMots";
            this.panelNbrMots.Size = new System.Drawing.Size(464, 28);
            this.panelNbrMots.TabIndex = 1;
            // 
            // picCadenas
            // 
            this.picCadenas.Location = new System.Drawing.Point(12, 12);
            this.picCadenas.Name = "picCadenas";
            this.picCadenas.Size = new System.Drawing.Size(80, 80);
            this.picCadenas.TabIndex = 2;
            this.picCadenas.TabStop = false;
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(107, 47);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(123, 13);
            this.lblHash.TabIndex = 3;
            this.lblHash.Text = "Saisir votre hachage ici :";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(110, 72);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(214, 20);
            this.txtHash.TabIndex = 4;
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(330, 72);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(118, 23);
            this.btnHash.TabIndex = 5;
            this.btnHash.Text = "Valider !";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // lblTentatives
            // 
            this.lblTentatives.AutoSize = true;
            this.lblTentatives.Location = new System.Drawing.Point(288, 13);
            this.lblTentatives.Name = "lblTentatives";
            this.lblTentatives.Size = new System.Drawing.Size(66, 13);
            this.lblTentatives.TabIndex = 6;
            this.lblTentatives.Text = "Tentatives : ";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Location = new System.Drawing.Point(288, 26);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(83, 13);
            this.lblCountdown.TabIndex = 7;
            this.lblCountdown.Text = "Temps écoulé : ";
            // 
            // Md5PasswordFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 138);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblTentatives);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.picCadenas);
            this.Controls.Add(this.panelNbrMots);
            this.Name = "Md5PasswordFinderForm";
            this.Text = "Application pour forcer un mot de passe encrypté en MD5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Md5PasswordFinderForm_FormClosing);
            this.Load += new System.EventHandler(this.Md5PasswordFinderForm_Load);
            this.panelNbrMots.ResumeLayout(false);
            this.panelNbrMots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCadenas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNbreMots;
        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.Panel panelNbrMots;
        private System.Windows.Forms.PictureBox picCadenas;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Label lblTentatives;
        private System.Windows.Forms.Label lblCountdown;
    }
}