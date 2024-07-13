namespace AnydeskEasyConnect
{
    partial class Login
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
            KullaniciAdiGirdisi = new TextBox();
            KullaniciParolasiGirdisi = new TextBox();
            KullaniciAdiLabel = new Label();
            KullaniciParolasiLabel = new Label();
            GirisYapButonu = new Button();
            SuspendLayout();
            // 
            // KullaniciAdiGirdisi
            // 
            KullaniciAdiGirdisi.Location = new Point(63, 54);
            KullaniciAdiGirdisi.Name = "KullaniciAdiGirdisi";
            KullaniciAdiGirdisi.Size = new Size(251, 23);
            KullaniciAdiGirdisi.TabIndex = 0;
            KullaniciAdiGirdisi.TextChanged += KullaniciAdiGirdisi_TextChanged;
            // 
            // KullaniciParolasiGirdisi
            // 
            KullaniciParolasiGirdisi.Location = new Point(63, 113);
            KullaniciParolasiGirdisi.Name = "KullaniciParolasiGirdisi";
            KullaniciParolasiGirdisi.Size = new Size(251, 23);
            KullaniciParolasiGirdisi.TabIndex = 1;
            KullaniciParolasiGirdisi.TextChanged += KullaniciParolasiGirdisi_TextChanged;
            // 
            // KullaniciAdiLabel
            // 
            KullaniciAdiLabel.AutoSize = true;
            KullaniciAdiLabel.Location = new Point(63, 36);
            KullaniciAdiLabel.Name = "KullaniciAdiLabel";
            KullaniciAdiLabel.Size = new Size(76, 15);
            KullaniciAdiLabel.TabIndex = 2;
            KullaniciAdiLabel.Text = "Kullanıcı Adı:";
            // 
            // KullaniciParolasiLabel
            // 
            KullaniciParolasiLabel.AutoSize = true;
            KullaniciParolasiLabel.Location = new Point(63, 95);
            KullaniciParolasiLabel.Name = "KullaniciParolasiLabel";
            KullaniciParolasiLabel.Size = new Size(43, 15);
            KullaniciParolasiLabel.TabIndex = 3;
            KullaniciParolasiLabel.Text = "Parola:";
            // 
            // GirisYapButonu
            // 
            GirisYapButonu.Location = new Point(146, 152);
            GirisYapButonu.Name = "GirisYapButonu";
            GirisYapButonu.Size = new Size(98, 38);
            GirisYapButonu.TabIndex = 4;
            GirisYapButonu.Text = "Giriş Yap";
            GirisYapButonu.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 202);
            Controls.Add(GirisYapButonu);
            Controls.Add(KullaniciParolasiLabel);
            Controls.Add(KullaniciAdiLabel);
            Controls.Add(KullaniciParolasiGirdisi);
            Controls.Add(KullaniciAdiGirdisi);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox KullaniciAdiGirdisi;
        private TextBox KullaniciParolasiGirdisi;
        private Label KullaniciAdiLabel;
        private Label KullaniciParolasiLabel;
        private Button GirisYapButonu;
    }
}