using System.Windows.Forms;

namespace AnydeskEasyConnect
{
    partial class MainScreen
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            tabControl = new TabControl();
            MaydonozTab = new TabPage();
            MaydonozDataGrid = new DataGridView();
            MaydonozBaglanTusu = new DataGridViewButtonColumn();
            KomageneTab = new TabPage();
            KomageneMainFlowLayout = new FlowLayoutPanel();
            KomageneAraVeYenileFlow = new FlowLayoutPanel();
            KomageneSubeAdiTextBox = new TextBox();
            KomageneAramaButonu = new Button();
            KomageneYenilemeButonu = new Button();
            KomageneDataGrid = new DataGridView();
            KomageneBaglanButonu = new DataGridViewButtonColumn();
            KomageneSifreyleBaglanButonu = new DataGridViewButtonColumn();
            KomageneDuzenleButonu = new DataGridViewButtonColumn();
            KomageneAnydeskEkleButonu = new Button();
            KofteciYusufTab = new TabPage();
            KofteciDataGrid = new DataGridView();
            CajunCornerTab = new TabPage();
            CajunDataGrid = new DataGridView();
            HotTab = new TabPage();
            HotDataGrid = new DataGridView();
            BereketTab = new TabPage();
            BereketDataGrid = new DataGridView();
            AdileTab = new TabPage();
            AdileDataGrid = new DataGridView();
            DigerTab = new TabPage();
            DigerDataGrid = new DataGridView();
            icons = new ImageList(components);
            tabControl.SuspendLayout();
            MaydonozTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaydonozDataGrid).BeginInit();
            KomageneTab.SuspendLayout();
            KomageneMainFlowLayout.SuspendLayout();
            KomageneAraVeYenileFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KomageneDataGrid).BeginInit();
            KofteciYusufTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KofteciDataGrid).BeginInit();
            CajunCornerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CajunDataGrid).BeginInit();
            HotTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HotDataGrid).BeginInit();
            BereketTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BereketDataGrid).BeginInit();
            AdileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdileDataGrid).BeginInit();
            DigerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DigerDataGrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(MaydonozTab);
            tabControl.Controls.Add(KomageneTab);
            tabControl.Controls.Add(KofteciYusufTab);
            tabControl.Controls.Add(CajunCornerTab);
            tabControl.Controls.Add(HotTab);
            tabControl.Controls.Add(BereketTab);
            tabControl.Controls.Add(AdileTab);
            tabControl.Controls.Add(DigerTab);
            tabControl.Dock = DockStyle.Fill;
            tabControl.ImageList = icons;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(825, 455);
            tabControl.TabIndex = 0;
            // 
            // MaydonozTab
            // 
            MaydonozTab.Controls.Add(MaydonozDataGrid);
            MaydonozTab.ImageKey = "m_red.ico";
            MaydonozTab.Location = new Point(4, 24);
            MaydonozTab.Name = "MaydonozTab";
            MaydonozTab.Padding = new Padding(3);
            MaydonozTab.Size = new Size(817, 427);
            MaydonozTab.TabIndex = 0;
            MaydonozTab.Text = "Maydonoz Döner";
            MaydonozTab.UseVisualStyleBackColor = true;
            // 
            // MaydonozDataGrid
            // 
            MaydonozDataGrid.AllowUserToAddRows = false;
            MaydonozDataGrid.AllowUserToDeleteRows = false;
            MaydonozDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MaydonozDataGrid.Columns.AddRange(new DataGridViewColumn[] { MaydonozBaglanTusu });
            MaydonozDataGrid.Dock = DockStyle.Fill;
            MaydonozDataGrid.Location = new Point(3, 3);
            MaydonozDataGrid.Name = "MaydonozDataGrid";
            MaydonozDataGrid.ReadOnly = true;
            MaydonozDataGrid.Size = new Size(811, 421);
            MaydonozDataGrid.TabIndex = 0;
            // 
            // MaydonozBaglanTusu
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaydonozBaglanTusu.DefaultCellStyle = dataGridViewCellStyle1;
            MaydonozBaglanTusu.HeaderText = "";
            MaydonozBaglanTusu.Name = "MaydonozBaglanTusu";
            MaydonozBaglanTusu.ReadOnly = true;
            MaydonozBaglanTusu.Text = "BAĞLAN";
            MaydonozBaglanTusu.UseColumnTextForButtonValue = true;
            // 
            // KomageneTab
            // 
            KomageneTab.Controls.Add(KomageneMainFlowLayout);
            KomageneTab.ImageIndex = 6;
            KomageneTab.Location = new Point(4, 24);
            KomageneTab.Name = "KomageneTab";
            KomageneTab.Padding = new Padding(3);
            KomageneTab.Size = new Size(817, 427);
            KomageneTab.TabIndex = 1;
            KomageneTab.Text = "Komagene";
            KomageneTab.UseVisualStyleBackColor = true;
            // 
            // KomageneMainFlowLayout
            // 
            KomageneMainFlowLayout.AutoSize = true;
            KomageneMainFlowLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            KomageneMainFlowLayout.Controls.Add(KomageneAraVeYenileFlow);
            KomageneMainFlowLayout.Controls.Add(KomageneDataGrid);
            KomageneMainFlowLayout.Controls.Add(KomageneAnydeskEkleButonu);
            KomageneMainFlowLayout.Dock = DockStyle.Fill;
            KomageneMainFlowLayout.FlowDirection = FlowDirection.TopDown;
            KomageneMainFlowLayout.Location = new Point(3, 3);
            KomageneMainFlowLayout.Name = "KomageneMainFlowLayout";
            KomageneMainFlowLayout.Size = new Size(811, 421);
            KomageneMainFlowLayout.TabIndex = 3;
            // 
            // KomageneAraVeYenileFlow
            // 
            KomageneAraVeYenileFlow.AutoSize = true;
            KomageneAraVeYenileFlow.Controls.Add(KomageneSubeAdiTextBox);
            KomageneAraVeYenileFlow.Controls.Add(KomageneAramaButonu);
            KomageneAraVeYenileFlow.Controls.Add(KomageneYenilemeButonu);
            KomageneAraVeYenileFlow.Dock = DockStyle.Top;
            KomageneAraVeYenileFlow.Location = new Point(3, 3);
            KomageneAraVeYenileFlow.Name = "KomageneAraVeYenileFlow";
            KomageneAraVeYenileFlow.Size = new Size(810, 31);
            KomageneAraVeYenileFlow.TabIndex = 3;
            // 
            // KomageneSubeAdiTextBox
            // 
            KomageneSubeAdiTextBox.Dock = DockStyle.Left;
            KomageneSubeAdiTextBox.Location = new Point(3, 3);
            KomageneSubeAdiTextBox.Name = "KomageneSubeAdiTextBox";
            KomageneSubeAdiTextBox.PlaceholderText = "Buraya Şube Adını Giriniz (Wildcard Kullanabilirsiniz)";
            KomageneSubeAdiTextBox.Size = new Size(449, 23);
            KomageneSubeAdiTextBox.TabIndex = 0;
            KomageneSubeAdiTextBox.TextChanged += KomageneSubeAdiTextBox_TextChanged;
            // 
            // KomageneAramaButonu
            // 
            KomageneAramaButonu.AutoSize = true;
            KomageneAramaButonu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            KomageneAramaButonu.Dock = DockStyle.Fill;
            KomageneAramaButonu.Location = new Point(458, 3);
            KomageneAramaButonu.MinimumSize = new Size(100, 25);
            KomageneAramaButonu.Name = "KomageneAramaButonu";
            KomageneAramaButonu.Size = new Size(100, 25);
            KomageneAramaButonu.TabIndex = 1;
            KomageneAramaButonu.Text = "Ara";
            KomageneAramaButonu.UseVisualStyleBackColor = true;
            KomageneAramaButonu.Click += KomageneAramaButonu_Click;
            // 
            // KomageneYenilemeButonu
            // 
            KomageneYenilemeButonu.AutoSize = true;
            KomageneYenilemeButonu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            KomageneYenilemeButonu.Dock = DockStyle.Right;
            KomageneYenilemeButonu.Location = new Point(564, 3);
            KomageneYenilemeButonu.MinimumSize = new Size(100, 25);
            KomageneYenilemeButonu.Name = "KomageneYenilemeButonu";
            KomageneYenilemeButonu.Size = new Size(100, 25);
            KomageneYenilemeButonu.TabIndex = 2;
            KomageneYenilemeButonu.Text = "Yenile (F5)";
            KomageneYenilemeButonu.UseVisualStyleBackColor = true;
            KomageneYenilemeButonu.Click += KomageneYenilemeButonu_Click;
            // 
            // KomageneDataGrid
            // 
            KomageneDataGrid.AllowUserToAddRows = false;
            KomageneDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            KomageneDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            KomageneDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            KomageneDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            KomageneDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KomageneDataGrid.Columns.AddRange(new DataGridViewColumn[] { KomageneBaglanButonu, KomageneSifreyleBaglanButonu, KomageneDuzenleButonu });
            KomageneDataGrid.Dock = DockStyle.Fill;
            KomageneDataGrid.Location = new Point(3, 40);
            KomageneDataGrid.Name = "KomageneDataGrid";
            KomageneDataGrid.ReadOnly = true;
            KomageneDataGrid.RowHeadersVisible = false;
            KomageneDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            KomageneDataGrid.RowTemplate.Height = 35;
            KomageneDataGrid.ShowCellErrors = false;
            KomageneDataGrid.ShowCellToolTips = false;
            KomageneDataGrid.ShowEditingIcon = false;
            KomageneDataGrid.ShowRowErrors = false;
            KomageneDataGrid.Size = new Size(810, 340);
            KomageneDataGrid.TabIndex = 5;
            KomageneDataGrid.CellContentClick += KomageneDataGrid_CellContentClick;
            // 
            // KomageneBaglanButonu
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KomageneBaglanButonu.DefaultCellStyle = dataGridViewCellStyle2;
            KomageneBaglanButonu.HeaderText = "";
            KomageneBaglanButonu.MinimumWidth = 51;
            KomageneBaglanButonu.Name = "KomageneBaglanButonu";
            KomageneBaglanButonu.ReadOnly = true;
            KomageneBaglanButonu.Text = "BAĞLAN";
            KomageneBaglanButonu.UseColumnTextForButtonValue = true;
            KomageneBaglanButonu.Width = 51;
            // 
            // KomageneSifreyleBaglanButonu
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KomageneSifreyleBaglanButonu.DefaultCellStyle = dataGridViewCellStyle3;
            KomageneSifreyleBaglanButonu.HeaderText = "";
            KomageneSifreyleBaglanButonu.Name = "KomageneSifreyleBaglanButonu";
            KomageneSifreyleBaglanButonu.ReadOnly = true;
            KomageneSifreyleBaglanButonu.Text = "ŞIFREYLE BAĞLAN";
            KomageneSifreyleBaglanButonu.UseColumnTextForButtonValue = true;
            KomageneSifreyleBaglanButonu.Width = 5;
            // 
            // KomageneDuzenleButonu
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KomageneDuzenleButonu.DefaultCellStyle = dataGridViewCellStyle4;
            KomageneDuzenleButonu.HeaderText = "";
            KomageneDuzenleButonu.Name = "KomageneDuzenleButonu";
            KomageneDuzenleButonu.ReadOnly = true;
            KomageneDuzenleButonu.Resizable = DataGridViewTriState.True;
            KomageneDuzenleButonu.Text = "DÜZENLE";
            KomageneDuzenleButonu.UseColumnTextForButtonValue = true;
            KomageneDuzenleButonu.Width = 5;
            // 
            // KomageneAnydeskEkleButonu
            // 
            KomageneAnydeskEkleButonu.AutoSize = true;
            KomageneAnydeskEkleButonu.Dock = DockStyle.Fill;
            KomageneAnydeskEkleButonu.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KomageneAnydeskEkleButonu.Location = new Point(3, 386);
            KomageneAnydeskEkleButonu.Name = "KomageneAnydeskEkleButonu";
            KomageneAnydeskEkleButonu.Size = new Size(810, 28);
            KomageneAnydeskEkleButonu.TabIndex = 6;
            KomageneAnydeskEkleButonu.Text = "Yeni Anydesk Ekle";
            KomageneAnydeskEkleButonu.UseVisualStyleBackColor = true;
            KomageneAnydeskEkleButonu.Click += KomageneAnydeskEkleButonu_Click;
            // 
            // KofteciYusufTab
            // 
            KofteciYusufTab.Controls.Add(KofteciDataGrid);
            KofteciYusufTab.ImageIndex = 5;
            KofteciYusufTab.Location = new Point(4, 24);
            KofteciYusufTab.Name = "KofteciYusufTab";
            KofteciYusufTab.Size = new Size(817, 427);
            KofteciYusufTab.TabIndex = 2;
            KofteciYusufTab.Text = "Köfteci Yusuf";
            KofteciYusufTab.UseVisualStyleBackColor = true;
            // 
            // KofteciDataGrid
            // 
            KofteciDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KofteciDataGrid.Dock = DockStyle.Fill;
            KofteciDataGrid.Location = new Point(0, 0);
            KofteciDataGrid.Name = "KofteciDataGrid";
            KofteciDataGrid.Size = new Size(817, 427);
            KofteciDataGrid.TabIndex = 0;
            // 
            // CajunCornerTab
            // 
            CajunCornerTab.Controls.Add(CajunDataGrid);
            CajunCornerTab.ImageIndex = 3;
            CajunCornerTab.Location = new Point(4, 24);
            CajunCornerTab.Name = "CajunCornerTab";
            CajunCornerTab.Size = new Size(817, 427);
            CajunCornerTab.TabIndex = 3;
            CajunCornerTab.Text = "Cajun Corner";
            CajunCornerTab.UseVisualStyleBackColor = true;
            // 
            // CajunDataGrid
            // 
            CajunDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CajunDataGrid.Dock = DockStyle.Fill;
            CajunDataGrid.Location = new Point(0, 0);
            CajunDataGrid.Name = "CajunDataGrid";
            CajunDataGrid.Size = new Size(817, 427);
            CajunDataGrid.TabIndex = 0;
            // 
            // HotTab
            // 
            HotTab.Controls.Add(HotDataGrid);
            HotTab.ImageIndex = 4;
            HotTab.Location = new Point(4, 24);
            HotTab.Name = "HotTab";
            HotTab.Size = new Size(817, 427);
            HotTab.TabIndex = 4;
            HotTab.Text = "Hot Döner";
            HotTab.UseVisualStyleBackColor = true;
            // 
            // HotDataGrid
            // 
            HotDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HotDataGrid.Dock = DockStyle.Fill;
            HotDataGrid.Location = new Point(0, 0);
            HotDataGrid.Name = "HotDataGrid";
            HotDataGrid.Size = new Size(817, 427);
            HotDataGrid.TabIndex = 0;
            // 
            // BereketTab
            // 
            BereketTab.Controls.Add(BereketDataGrid);
            BereketTab.ImageIndex = 2;
            BereketTab.Location = new Point(4, 24);
            BereketTab.Name = "BereketTab";
            BereketTab.Size = new Size(817, 427);
            BereketTab.TabIndex = 5;
            BereketTab.Text = "Bereket Döner";
            BereketTab.UseVisualStyleBackColor = true;
            // 
            // BereketDataGrid
            // 
            BereketDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BereketDataGrid.Dock = DockStyle.Fill;
            BereketDataGrid.Location = new Point(0, 0);
            BereketDataGrid.Name = "BereketDataGrid";
            BereketDataGrid.Size = new Size(817, 427);
            BereketDataGrid.TabIndex = 0;
            // 
            // AdileTab
            // 
            AdileTab.Controls.Add(AdileDataGrid);
            AdileTab.ImageIndex = 1;
            AdileTab.Location = new Point(4, 24);
            AdileTab.Name = "AdileTab";
            AdileTab.Size = new Size(817, 427);
            AdileTab.TabIndex = 6;
            AdileTab.Text = "Adile Sultan";
            AdileTab.UseVisualStyleBackColor = true;
            // 
            // AdileDataGrid
            // 
            AdileDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdileDataGrid.Dock = DockStyle.Fill;
            AdileDataGrid.Location = new Point(0, 0);
            AdileDataGrid.Name = "AdileDataGrid";
            AdileDataGrid.Size = new Size(817, 427);
            AdileDataGrid.TabIndex = 0;
            // 
            // DigerTab
            // 
            DigerTab.Controls.Add(DigerDataGrid);
            DigerTab.ImageIndex = 7;
            DigerTab.Location = new Point(4, 24);
            DigerTab.Name = "DigerTab";
            DigerTab.Size = new Size(817, 427);
            DigerTab.TabIndex = 7;
            DigerTab.Text = "Diğer";
            DigerTab.UseVisualStyleBackColor = true;
            // 
            // DigerDataGrid
            // 
            DigerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DigerDataGrid.Dock = DockStyle.Fill;
            DigerDataGrid.Location = new Point(0, 0);
            DigerDataGrid.Name = "DigerDataGrid";
            DigerDataGrid.Size = new Size(817, 427);
            DigerDataGrid.TabIndex = 0;
            // 
            // icons
            // 
            icons.ColorDepth = ColorDepth.Depth32Bit;
            icons.ImageStream = (ImageListStreamer)resources.GetObject("icons.ImageStream");
            icons.TransparentColor = Color.Transparent;
            icons.Images.SetKeyName(0, "m_red.ico");
            icons.Images.SetKeyName(1, "a_red.ico");
            icons.Images.SetKeyName(2, "b_red.ico");
            icons.Images.SetKeyName(3, "C_red.ico");
            icons.Images.SetKeyName(4, "H_red_BiG.ico");
            icons.Images.SetKeyName(5, "K_blue.ico");
            icons.Images.SetKeyName(6, "k_red.ico");
            icons.Images.SetKeyName(7, "Mercan.ico");
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 455);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainScreen";
            Text = "YemekPOS Anydesk Servisi";
            tabControl.ResumeLayout(false);
            MaydonozTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MaydonozDataGrid).EndInit();
            KomageneTab.ResumeLayout(false);
            KomageneTab.PerformLayout();
            KomageneMainFlowLayout.ResumeLayout(false);
            KomageneMainFlowLayout.PerformLayout();
            KomageneAraVeYenileFlow.ResumeLayout(false);
            KomageneAraVeYenileFlow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)KomageneDataGrid).EndInit();
            KofteciYusufTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)KofteciDataGrid).EndInit();
            CajunCornerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CajunDataGrid).EndInit();
            HotTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HotDataGrid).EndInit();
            BereketTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BereketDataGrid).EndInit();
            AdileTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdileDataGrid).EndInit();
            DigerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DigerDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage MaydonozTab;
        private TabPage KomageneTab;
        private TabPage KofteciYusufTab;
        private TabPage CajunCornerTab;
        private TabPage HotTab;
        private TabPage BereketTab;
        private TabPage AdileTab;
        private TabPage DigerTab;
        private ImageList icons;
        private DataGridView MaydonozDataGrid;
        private DataGridView KofteciDataGrid;
        private DataGridView CajunDataGrid;
        private DataGridView HotDataGrid;
        private DataGridView BereketDataGrid;
        private DataGridView AdileDataGrid;
        private DataGridView DigerDataGrid;
        private DataGridViewButtonColumn MaydonozBaglanTusu;
        private FlowLayoutPanel KomageneMainFlowLayout;
        private FlowLayoutPanel KomageneAraVeYenileFlow;
        private TextBox KomageneSubeAdiTextBox;
        private Button KomageneAramaButonu;
        private Button KomageneYenilemeButonu;
        private DataGridViewButtonColumn KomageneBaglanButonu;
        private DataGridViewButtonColumn KomageneSifreyleBaglanButonu;
        private DataGridViewButtonColumn KomageneDuzenleButonu;
        private Button KomageneAnydeskEkleButonu;
        internal static DataGridView KomageneDataGrid;
    }
}
