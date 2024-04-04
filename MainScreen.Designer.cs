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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            tabControl = new TabControl();
            MaydonozTab = new TabPage();
            MaydonozDataGrid = new DataGridView();
            KomageneTab = new TabPage();
            KofteciYusufTab = new TabPage();
            CajunCornerTab = new TabPage();
            HotTab = new TabPage();
            BereketTab = new TabPage();
            AdileTab = new TabPage();
            DigerTab = new TabPage();
            icons = new ImageList(components);
            KomageneDataGrid = new DataGridView();
            KofteciDataGrid = new DataGridView();
            CajunDataGrid = new DataGridView();
            HotDataGrid = new DataGridView();
            BereketDataGrid = new DataGridView();
            AdileDataGrid = new DataGridView();
            DigerDataGrid = new DataGridView();
            tabControl.SuspendLayout();
            MaydonozTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaydonozDataGrid).BeginInit();
            KomageneTab.SuspendLayout();
            KofteciYusufTab.SuspendLayout();
            CajunCornerTab.SuspendLayout();
            HotTab.SuspendLayout();
            BereketTab.SuspendLayout();
            AdileTab.SuspendLayout();
            DigerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KomageneDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KofteciDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CajunDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HotDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BereketDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdileDataGrid).BeginInit();
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
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            // 
            // MaydonozTab
            // 
            MaydonozTab.Controls.Add(MaydonozDataGrid);
            MaydonozTab.ImageKey = "m_red.ico";
            MaydonozTab.Location = new Point(4, 24);
            MaydonozTab.Name = "MaydonozTab";
            MaydonozTab.Padding = new Padding(3);
            MaydonozTab.Size = new Size(792, 422);
            MaydonozTab.TabIndex = 0;
            MaydonozTab.Text = "Maydonoz Döner";
            MaydonozTab.UseVisualStyleBackColor = true;
            // 
            // MaydonozDataGrid
            // 
            MaydonozDataGrid.AllowUserToAddRows = false;
            MaydonozDataGrid.AllowUserToDeleteRows = false;
            MaydonozDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MaydonozDataGrid.Dock = DockStyle.Fill;
            MaydonozDataGrid.Location = new Point(3, 3);
            MaydonozDataGrid.Name = "MaydonozDataGrid";
            MaydonozDataGrid.ReadOnly = true;
            MaydonozDataGrid.Size = new Size(786, 416);
            MaydonozDataGrid.TabIndex = 0;
            // 
            // KomageneTab
            // 
            KomageneTab.Controls.Add(KomageneDataGrid);
            KomageneTab.ImageIndex = 6;
            KomageneTab.Location = new Point(4, 24);
            KomageneTab.Name = "KomageneTab";
            KomageneTab.Padding = new Padding(3);
            KomageneTab.Size = new Size(792, 422);
            KomageneTab.TabIndex = 1;
            KomageneTab.Text = "Komagene";
            KomageneTab.UseVisualStyleBackColor = true;
            // 
            // KofteciYusufTab
            // 
            KofteciYusufTab.Controls.Add(KofteciDataGrid);
            KofteciYusufTab.ImageIndex = 5;
            KofteciYusufTab.Location = new Point(4, 24);
            KofteciYusufTab.Name = "KofteciYusufTab";
            KofteciYusufTab.Size = new Size(792, 422);
            KofteciYusufTab.TabIndex = 2;
            KofteciYusufTab.Text = "Köfteci Yusuf";
            KofteciYusufTab.UseVisualStyleBackColor = true;
            // 
            // CajunCornerTab
            // 
            CajunCornerTab.Controls.Add(CajunDataGrid);
            CajunCornerTab.ImageIndex = 3;
            CajunCornerTab.Location = new Point(4, 24);
            CajunCornerTab.Name = "CajunCornerTab";
            CajunCornerTab.Size = new Size(792, 422);
            CajunCornerTab.TabIndex = 3;
            CajunCornerTab.Text = "Cajun Corner";
            CajunCornerTab.UseVisualStyleBackColor = true;
            // 
            // HotTab
            // 
            HotTab.Controls.Add(HotDataGrid);
            HotTab.ImageIndex = 4;
            HotTab.Location = new Point(4, 24);
            HotTab.Name = "HotTab";
            HotTab.Size = new Size(792, 422);
            HotTab.TabIndex = 4;
            HotTab.Text = "Hot Döner";
            HotTab.UseVisualStyleBackColor = true;
            // 
            // BereketTab
            // 
            BereketTab.Controls.Add(BereketDataGrid);
            BereketTab.ImageIndex = 2;
            BereketTab.Location = new Point(4, 24);
            BereketTab.Name = "BereketTab";
            BereketTab.Size = new Size(792, 422);
            BereketTab.TabIndex = 5;
            BereketTab.Text = "Bereket Döner";
            BereketTab.UseVisualStyleBackColor = true;
            // 
            // AdileTab
            // 
            AdileTab.Controls.Add(AdileDataGrid);
            AdileTab.ImageIndex = 1;
            AdileTab.Location = new Point(4, 24);
            AdileTab.Name = "AdileTab";
            AdileTab.Size = new Size(792, 422);
            AdileTab.TabIndex = 6;
            AdileTab.Text = "Adile Sultan";
            AdileTab.UseVisualStyleBackColor = true;
            // 
            // DigerTab
            // 
            DigerTab.Controls.Add(DigerDataGrid);
            DigerTab.ImageIndex = 7;
            DigerTab.Location = new Point(4, 24);
            DigerTab.Name = "DigerTab";
            DigerTab.Size = new Size(792, 422);
            DigerTab.TabIndex = 7;
            DigerTab.Text = "Diğer";
            DigerTab.UseVisualStyleBackColor = true;
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
            // KomageneDataGrid
            // 
            KomageneDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KomageneDataGrid.Dock = DockStyle.Fill;
            KomageneDataGrid.Location = new Point(3, 3);
            KomageneDataGrid.Name = "KomageneDataGrid";
            KomageneDataGrid.Size = new Size(786, 416);
            KomageneDataGrid.TabIndex = 0;
            // 
            // KofteciDataGrid
            // 
            KofteciDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KofteciDataGrid.Dock = DockStyle.Fill;
            KofteciDataGrid.Location = new Point(0, 0);
            KofteciDataGrid.Name = "KofteciDataGrid";
            KofteciDataGrid.Size = new Size(792, 422);
            KofteciDataGrid.TabIndex = 0;
            // 
            // CajunDataGrid
            // 
            CajunDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CajunDataGrid.Dock = DockStyle.Fill;
            CajunDataGrid.Location = new Point(0, 0);
            CajunDataGrid.Name = "CajunDataGrid";
            CajunDataGrid.Size = new Size(792, 422);
            CajunDataGrid.TabIndex = 0;
            // 
            // HotDataGrid
            // 
            HotDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HotDataGrid.Dock = DockStyle.Fill;
            HotDataGrid.Location = new Point(0, 0);
            HotDataGrid.Name = "HotDataGrid";
            HotDataGrid.Size = new Size(792, 422);
            HotDataGrid.TabIndex = 0;
            // 
            // BereketDataGrid
            // 
            BereketDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BereketDataGrid.Dock = DockStyle.Fill;
            BereketDataGrid.Location = new Point(0, 0);
            BereketDataGrid.Name = "BereketDataGrid";
            BereketDataGrid.Size = new Size(792, 422);
            BereketDataGrid.TabIndex = 0;
            // 
            // AdileDataGrid
            // 
            AdileDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdileDataGrid.Dock = DockStyle.Fill;
            AdileDataGrid.Location = new Point(0, 0);
            AdileDataGrid.Name = "AdileDataGrid";
            AdileDataGrid.Size = new Size(792, 422);
            AdileDataGrid.TabIndex = 0;
            // 
            // DigerDataGrid
            // 
            DigerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DigerDataGrid.Dock = DockStyle.Fill;
            DigerDataGrid.Location = new Point(0, 0);
            DigerDataGrid.Name = "DigerDataGrid";
            DigerDataGrid.Size = new Size(792, 422);
            DigerDataGrid.TabIndex = 0;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainScreen";
            Text = "YemekPOS Anydesk Servisi";
            tabControl.ResumeLayout(false);
            MaydonozTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MaydonozDataGrid).EndInit();
            KomageneTab.ResumeLayout(false);
            KofteciYusufTab.ResumeLayout(false);
            CajunCornerTab.ResumeLayout(false);
            HotTab.ResumeLayout(false);
            BereketTab.ResumeLayout(false);
            AdileTab.ResumeLayout(false);
            DigerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)KomageneDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)KofteciDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)CajunDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)HotDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)BereketDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdileDataGrid).EndInit();
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
        private DataGridView KomageneDataGrid;
        private DataGridView KofteciDataGrid;
        private DataGridView CajunDataGrid;
        private DataGridView HotDataGrid;
        private DataGridView BereketDataGrid;
        private DataGridView AdileDataGrid;
        private DataGridView DigerDataGrid;
    }
}
