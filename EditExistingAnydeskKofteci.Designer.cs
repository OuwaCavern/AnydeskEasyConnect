namespace AnydeskEasyConnect
{
    partial class EditExistingAnydeskKofteci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditExistingAnydeskKofteci));
            EditExistingAnydeskFlowLayout = new FlowLayoutPanel();
            AdGirinizLabel = new Label();
            ŞubeAdıGirdisi = new TextBox();
            NumaraGirinizLabel = new Label();
            AnydeskNumarasıGirdisi = new TextBox();
            ParolaGirinizLabel = new Label();
            AnydeskParolasıGirdisi = new TextBox();
            BilgisayarYetkiLabel = new Label();
            BilgisayarYetkisiComboBox = new ComboBox();
            KaydetButonu = new Button();
            EditExistingAnydeskFlowLayout.SuspendLayout();
            SuspendLayout();
            // 
            // EditExistingAnydeskFlowLayout
            // 
            EditExistingAnydeskFlowLayout.Controls.Add(AdGirinizLabel);
            EditExistingAnydeskFlowLayout.Controls.Add(ŞubeAdıGirdisi);
            EditExistingAnydeskFlowLayout.Controls.Add(NumaraGirinizLabel);
            EditExistingAnydeskFlowLayout.Controls.Add(AnydeskNumarasıGirdisi);
            EditExistingAnydeskFlowLayout.Controls.Add(ParolaGirinizLabel);
            EditExistingAnydeskFlowLayout.Controls.Add(AnydeskParolasıGirdisi);
            EditExistingAnydeskFlowLayout.Controls.Add(BilgisayarYetkiLabel);
            EditExistingAnydeskFlowLayout.Controls.Add(BilgisayarYetkisiComboBox);
            EditExistingAnydeskFlowLayout.Controls.Add(KaydetButonu);
            EditExistingAnydeskFlowLayout.Dock = DockStyle.Fill;
            EditExistingAnydeskFlowLayout.FlowDirection = FlowDirection.TopDown;
            EditExistingAnydeskFlowLayout.Location = new Point(0, 0);
            EditExistingAnydeskFlowLayout.Name = "EditExistingAnydeskFlowLayout";
            EditExistingAnydeskFlowLayout.Size = new Size(432, 346);
            EditExistingAnydeskFlowLayout.TabIndex = 0;
            // 
            // AdGirinizLabel
            // 
            AdGirinizLabel.AutoSize = true;
            AdGirinizLabel.Font = new Font("Segoe UI", 10F);
            AdGirinizLabel.Location = new Point(10, 10);
            AdGirinizLabel.Margin = new Padding(10, 10, 3, 0);
            AdGirinizLabel.Name = "AdGirinizLabel";
            AdGirinizLabel.Size = new Size(116, 19);
            AdGirinizLabel.TabIndex = 0;
            AdGirinizLabel.Text = "Şube Adını Giriniz";
            // 
            // ŞubeAdıGirdisi
            // 
            ŞubeAdıGirdisi.Location = new Point(3, 32);
            ŞubeAdıGirdisi.Name = "ŞubeAdıGirdisi";
            ŞubeAdıGirdisi.Size = new Size(425, 23);
            ŞubeAdıGirdisi.TabIndex = 1;
            ŞubeAdıGirdisi.TextChanged += ŞubeAdıGirdisi_TextChanged;
            // 
            // NumaraGirinizLabel
            // 
            NumaraGirinizLabel.AutoSize = true;
            NumaraGirinizLabel.Font = new Font("Segoe UI", 10F);
            NumaraGirinizLabel.Location = new Point(10, 78);
            NumaraGirinizLabel.Margin = new Padding(10, 20, 3, 0);
            NumaraGirinizLabel.Name = "NumaraGirinizLabel";
            NumaraGirinizLabel.Size = new Size(229, 19);
            NumaraGirinizLabel.TabIndex = 2;
            NumaraGirinizLabel.Text = "Şubenin Anydesk Numarasını Giriniz";
            // 
            // AnydeskNumarasıGirdisi
            // 
            AnydeskNumarasıGirdisi.Location = new Point(3, 100);
            AnydeskNumarasıGirdisi.Name = "AnydeskNumarasıGirdisi";
            AnydeskNumarasıGirdisi.Size = new Size(425, 23);
            AnydeskNumarasıGirdisi.TabIndex = 3;
            AnydeskNumarasıGirdisi.TextChanged += AnydeskNumarasıGirdisi_TextChanged;
            // 
            // ParolaGirinizLabel
            // 
            ParolaGirinizLabel.AutoSize = true;
            ParolaGirinizLabel.Font = new Font("Segoe UI", 10F);
            ParolaGirinizLabel.Location = new Point(10, 146);
            ParolaGirinizLabel.Margin = new Padding(10, 20, 3, 0);
            ParolaGirinizLabel.Name = "ParolaGirinizLabel";
            ParolaGirinizLabel.Size = new Size(218, 19);
            ParolaGirinizLabel.TabIndex = 4;
            ParolaGirinizLabel.Text = "Şubenin Anydesk Parolasını Giriniz";
            // 
            // AnydeskParolasıGirdisi
            // 
            AnydeskParolasıGirdisi.Location = new Point(3, 168);
            AnydeskParolasıGirdisi.Name = "AnydeskParolasıGirdisi";
            AnydeskParolasıGirdisi.Size = new Size(425, 23);
            AnydeskParolasıGirdisi.TabIndex = 5;
            AnydeskParolasıGirdisi.TextChanged += AnydeskParolasıGirdisi_TextChanged;
            // 
            // BilgisayarYetkiLabel
            // 
            BilgisayarYetkiLabel.AutoSize = true;
            BilgisayarYetkiLabel.Font = new Font("Segoe UI", 10F);
            BilgisayarYetkiLabel.Location = new Point(10, 214);
            BilgisayarYetkiLabel.Margin = new Padding(10, 20, 3, 0);
            BilgisayarYetkiLabel.Name = "BilgisayarYetkiLabel";
            BilgisayarYetkiLabel.Size = new Size(258, 19);
            BilgisayarYetkiLabel.TabIndex = 6;
            BilgisayarYetkiLabel.Text = "Şubenin Bilgisayar Yetki Seviyesini Seçiniz";
            // 
            // BilgisayarYetkisiComboBox
            // 
            BilgisayarYetkisiComboBox.BackColor = SystemColors.Info;
            BilgisayarYetkisiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BilgisayarYetkisiComboBox.FormattingEnabled = true;
            BilgisayarYetkisiComboBox.Items.AddRange(new object[] { "Ana Bilgisayar", "Garson Bilgisayar", "Belirtilmedi" });
            BilgisayarYetkisiComboBox.Location = new Point(3, 236);
            BilgisayarYetkisiComboBox.Name = "BilgisayarYetkisiComboBox";
            BilgisayarYetkisiComboBox.Size = new Size(121, 23);
            BilgisayarYetkisiComboBox.TabIndex = 8;
            BilgisayarYetkisiComboBox.SelectedIndexChanged += BilgisayarYetkisiComboBox_SelectedIndexChanged;
            // 
            // KaydetButonu
            // 
            KaydetButonu.Font = new Font("Segoe UI", 13F);
            KaydetButonu.Location = new Point(135, 282);
            KaydetButonu.Margin = new Padding(135, 20, 20, 20);
            KaydetButonu.Name = "KaydetButonu";
            KaydetButonu.Size = new Size(166, 37);
            KaydetButonu.TabIndex = 10;
            KaydetButonu.Text = "Kaydet";
            KaydetButonu.UseVisualStyleBackColor = true;
            KaydetButonu.Click += KaydetButonu_Click;
            // 
            // EditExistingAnydeskKofteci
            // 
            AcceptButton = KaydetButonu;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 346);
            Controls.Add(EditExistingAnydeskFlowLayout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditExistingAnydeskKofteci";
            Text = "Anydeski Düzenle";
            EditExistingAnydeskFlowLayout.ResumeLayout(false);
            EditExistingAnydeskFlowLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel EditExistingAnydeskFlowLayout;
        private Label AdGirinizLabel;
        private TextBox ŞubeAdıGirdisi;
        private Label NumaraGirinizLabel;
        private TextBox AnydeskNumarasıGirdisi;
        private Label ParolaGirinizLabel;
        private TextBox AnydeskParolasıGirdisi;
        private Label BilgisayarYetkiLabel;
        private ComboBox BilgisayarYetkisiComboBox;
        private Button KaydetButonu;
    }
}