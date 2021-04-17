
namespace Hospital_Saving_Management
{
    partial class FrmHastaGiriş
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.lnkÜye = new System.Windows.Forms.LinkLabel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC kimlik no:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(86, 30);
            this.mskTc.Mask = "000000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(100, 20);
            this.mskTc.TabIndex = 2;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(86, 70);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(100, 20);
            this.txtŞifre.TabIndex = 3;
            // 
            // lnkÜye
            // 
            this.lnkÜye.AutoSize = true;
            this.lnkÜye.Location = new System.Drawing.Point(192, 77);
            this.lnkÜye.Name = "lnkÜye";
            this.lnkÜye.Size = new System.Drawing.Size(39, 13);
            this.lnkÜye.TabIndex = 4;
            this.lnkÜye.TabStop = true;
            this.lnkÜye.Text = "Üye Ol";
            this.lnkÜye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkÜye_LinkClicked);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(111, 112);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmHastaGiriş
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 147);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lnkÜye);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHastaGiriş";
            this.Text = "FrmHastaGiriş";
            this.Load += new System.EventHandler(this.FrmHastaGiriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.LinkLabel lnkÜye;
        private System.Windows.Forms.Button btnEnter;
    }
}