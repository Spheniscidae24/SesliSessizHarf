namespace SesliSessizHarf1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKelime = new System.Windows.Forms.TextBox();
            this.cbHarf = new System.Windows.Forms.ComboBox();
            this.bGetir = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.lSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(34, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sonuç";
            // 
            // tbKelime
            // 
            this.tbKelime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbKelime.Location = new System.Drawing.Point(134, 31);
            this.tbKelime.Name = "tbKelime";
            this.tbKelime.Size = new System.Drawing.Size(321, 27);
            this.tbKelime.TabIndex = 1;
            // 
            // cbHarf
            // 
            this.cbHarf.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbHarf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHarf.FormattingEnabled = true;
            this.cbHarf.Items.AddRange(new object[] {
            "--Seçiniz--",
            "Sesli Harf",
            "Sessiz Harf"});
            this.cbHarf.Location = new System.Drawing.Point(134, 93);
            this.cbHarf.Name = "cbHarf";
            this.cbHarf.Size = new System.Drawing.Size(151, 28);
            this.cbHarf.TabIndex = 2;
            // 
            // bGetir
            // 
            this.bGetir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bGetir.Location = new System.Drawing.Point(34, 247);
            this.bGetir.Name = "bGetir";
            this.bGetir.Size = new System.Drawing.Size(198, 76);
            this.bGetir.TabIndex = 3;
            this.bGetir.Text = "Getir";
            this.bGetir.UseVisualStyleBackColor = false;
            this.bGetir.Click += new System.EventHandler(this.bGetir_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bTemizle.Location = new System.Drawing.Point(252, 247);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(203, 76);
            this.bTemizle.TabIndex = 4;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = false;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // lSonuc
            // 
            this.lSonuc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lSonuc.Location = new System.Drawing.Point(134, 151);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(321, 79);
            this.lSonuc.TabIndex = 7;
            this.lSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(540, 335);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bGetir);
            this.Controls.Add(this.cbHarf);
            this.Controls.Add(this.tbKelime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesli-Sessiz Harf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbKelime;
        private ComboBox cbHarf;
        private Button bGetir;
        private Button bTemizle;
        private Label lSonuc;
    }
}