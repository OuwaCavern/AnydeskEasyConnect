﻿using System.ComponentModel;
using System.Windows.Forms;

namespace AnydeskEasyConnect
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.Load += MainScreen_Load;
            maınTabControl.SelectedIndexChanged += mainTabControl_SelectedIndexChanged;
            this.Resize += MainScreen_Resiz;
            formOriginalSize = this.Size;
            WindowState = FormWindowState.Maximized;
            recKomageneAnydeskEkleButonu = new Rectangle(KomageneAnydeskEkleButonu.Location, KomageneAnydeskEkleButonu.Size);
            recKomageneDataGrid = new Rectangle(KomageneDataGrid.Location, KomageneDataGrid.Size);
            recKomageneAramaButonu = new Rectangle(KomageneAramaButonu.Location, KomageneAramaButonu.Size);
            recKomageneAramaGirdisi = new Rectangle(KomageneSubeAdiTextBox.Location, KomageneSubeAdiTextBox.Size);
            recKomageneYenilemeButonu = new Rectangle(KomageneYenilemeButonu.Location, KomageneYenilemeButonu.Size);
            recCajunAnydeskEkleButonu = new Rectangle(CajunAnydeskEkleButonu.Location, CajunAnydeskEkleButonu.Size);
            recCajunDataGrid = new Rectangle(CajunDataGrid.Location, CajunDataGrid.Size);
            recCajunAramaButonu = new Rectangle(CajunAramaButonu.Location, CajunAramaButonu.Size);
            recCajunAramaGirdisi = new Rectangle(CajunAramaGirdisi.Location, CajunAramaGirdisi.Size);
            recCajunYenilemeButonu = new Rectangle(CajunYenileButonu.Location, CajunYenileButonu.Size);
            recHotAnydeskEkleButonu = new Rectangle(HotAnydeskEkleButonu.Location, HotAnydeskEkleButonu.Size);
            recHotDataGrid = new Rectangle(HotDataGrid.Location, HotDataGrid.Size);
            recHotAramaButonu = new Rectangle(HotAramaButonu.Location, HotAramaButonu.Size);
            recHotAramaGirdisi = new Rectangle(HotAramaGirdisi.Location, HotAramaGirdisi.Size);
            recHotYenilemeButonu = new Rectangle(HotYenileButonu.Location, HotYenileButonu.Size);
            recBereketAnydeskEkleButonu = new Rectangle(BereketAnydeskEkleButonu.Location, BereketAnydeskEkleButonu.Size);
            recBereketDataGrid = new Rectangle(BereketDataGrid.Location, BereketDataGrid.Size);
            recBereketAramaButonu = new Rectangle(BereketAramaButonu.Location, BereketAramaButonu.Size);
            recBereketAramaGirdisi = new Rectangle(BereketAramaGirdisi.Location, BereketAramaGirdisi.Size);
            recBereketYenilemeButonu = new Rectangle(BereketYenileButonu.Location, BereketYenileButonu.Size);
            recKofteciAnydeskEkleButonu = new Rectangle(KofteciAnydeskEkleButonu.Location, KofteciAnydeskEkleButonu.Size);
            recKofteciDataGrid = new Rectangle(KofteciDataGrid.Location, KofteciDataGrid.Size);
            recKofteciAramaButonu = new Rectangle(KofteciAramaButonu.Location, KofteciAramaButonu.Size);
            recKofteciAramaGirdisi = new Rectangle(KofteciAramaGirdisi.Location, KofteciAramaGirdisi.Size);
            recKofteciYenilemeButonu = new Rectangle(KofteciYenileButonu.Location, KofteciYenileButonu.Size);
            recMaydonozAnydeskEkleButonu = new Rectangle(MaydonozAnydeskEkleButonu.Location, MaydonozAnydeskEkleButonu.Size);
            recMaydonozDataGrid = new Rectangle(MaydonozDataGrid.Location, MaydonozDataGrid.Size);
            recMaydonozAramaButonu = new Rectangle(MaydonozAramaButonu.Location, MaydonozAramaButonu.Size);
            recMaydonozAramaGirdisi = new Rectangle(MaydonozAramaGirdisi.Location, MaydonozAramaGirdisi.Size);
            recMaydonozYenilemeButonu = new Rectangle(MaydonozYenileButonu.Location, MaydonozYenileButonu.Size);
            recDigerAnydeskEkleButonu = new Rectangle(DigerAnydeskEkleButonu.Location, DigerAnydeskEkleButonu.Size);
            recDigerDataGrid = new Rectangle(DigerDataGrid.Location, DigerDataGrid.Size);
            recDigerAramaButonu = new Rectangle(DigerAramaButonu.Location, DigerAramaButonu.Size);
            recDigerAramaGirdisi = new Rectangle(DigerAramaGirdisi.Location, DigerAramaGirdisi.Size);
            recDigerYenilemeButonu = new Rectangle(DigerYenileButonu.Location, DigerYenileButonu.Size);
            recHeyAnydeskEkleButonu = new Rectangle(HeyAnydeskEkleButonu.Location, HeyAnydeskEkleButonu.Size);
            recHeyDataGrid = new Rectangle(HeyDataGrid.Location, HeyDataGrid.Size);
            recHeyAramaButonu = new Rectangle(HeyAramaButonu.Location, HeyAramaButonu.Size);
            recHeyAramaGirdisi = new Rectangle(HeyAramaGirdisi.Location, HeyAramaGirdisi.Size);
            recHeyYenilemeButonu = new Rectangle(HeyYenileButonu.Location, HeyYenileButonu.Size);
        }
        private Size formOriginalSize;
        private Rectangle recKomageneAnydeskEkleButonu;
        private Rectangle recKomageneDataGrid;
        private Rectangle recKomageneAramaButonu;
        private Rectangle recKomageneYenilemeButonu;
        private Rectangle recKomageneAramaGirdisi;
        private Rectangle recCajunAnydeskEkleButonu;
        private Rectangle recCajunDataGrid;
        private Rectangle recCajunAramaButonu;
        private Rectangle recCajunYenilemeButonu;
        private Rectangle recCajunAramaGirdisi;
        private Rectangle recBereketAnydeskEkleButonu;
        private Rectangle recBereketDataGrid;
        private Rectangle recBereketAramaButonu;
        private Rectangle recBereketYenilemeButonu;
        private Rectangle recBereketAramaGirdisi;
        private Rectangle recHotAnydeskEkleButonu;
        private Rectangle recHotDataGrid;
        private Rectangle recHotAramaButonu;
        private Rectangle recHotYenilemeButonu;
        private Rectangle recHotAramaGirdisi;
        private Rectangle recKofteciAnydeskEkleButonu;
        private Rectangle recKofteciDataGrid;
        private Rectangle recKofteciAramaButonu;
        private Rectangle recKofteciYenilemeButonu;
        private Rectangle recKofteciAramaGirdisi;
        private Rectangle recDigerAnydeskEkleButonu;
        private Rectangle recDigerDataGrid;
        private Rectangle recDigerAramaButonu;
        private Rectangle recDigerYenilemeButonu;
        private Rectangle recDigerAramaGirdisi;
        private Rectangle recMaydonozAnydeskEkleButonu;
        private Rectangle recMaydonozDataGrid;
        private Rectangle recMaydonozAramaButonu;
        private Rectangle recMaydonozYenilemeButonu;
        private Rectangle recMaydonozAramaGirdisi;
        private Rectangle recHeyAnydeskEkleButonu;
        private Rectangle recHeyDataGrid;
        private Rectangle recHeyAramaButonu;
        private Rectangle recHeyYenilemeButonu;
        private Rectangle recHeyAramaGirdisi;

        private void MainScreen_Resiz(object sender, EventArgs e)
        {
            ResizeControl(KomageneAnydeskEkleButonu, recKomageneAnydeskEkleButonu);
            ResizeControl(KomageneDataGrid, recKomageneDataGrid);
            ResizeControl(KomageneAramaButonu, recKomageneAramaButonu);
            ResizeControl(KomageneYenilemeButonu, recKomageneYenilemeButonu);
            ResizeControl(KomageneSubeAdiTextBox, recKomageneAramaGirdisi);
            ResizeControl(MaydonozAnydeskEkleButonu, recMaydonozAnydeskEkleButonu);
            ResizeControl(MaydonozDataGrid, recMaydonozDataGrid);
            ResizeControl(MaydonozAramaButonu, recMaydonozAramaButonu);
            ResizeControl(MaydonozYenileButonu, recMaydonozYenilemeButonu);
            ResizeControl(MaydonozAramaGirdisi, recMaydonozAramaGirdisi);
            ResizeControl(KofteciAnydeskEkleButonu, recKofteciAnydeskEkleButonu);
            ResizeControl(KofteciDataGrid, recKofteciDataGrid);
            ResizeControl(KofteciAramaButonu, recKofteciAramaButonu);
            ResizeControl(KofteciYenileButonu, recKofteciYenilemeButonu);
            ResizeControl(KofteciAramaGirdisi, recKofteciAramaGirdisi);
            ResizeControl(HotAnydeskEkleButonu, recHotAnydeskEkleButonu);
            ResizeControl(HotDataGrid, recHotDataGrid);
            ResizeControl(HotAramaButonu, recHotAramaButonu);
            ResizeControl(HotYenileButonu, recHotYenilemeButonu);
            ResizeControl(HotAramaGirdisi, recHotAramaGirdisi);
            ResizeControl(CajunAnydeskEkleButonu, recCajunAnydeskEkleButonu);
            ResizeControl(CajunDataGrid, recCajunDataGrid);
            ResizeControl(CajunAramaButonu, recCajunAramaButonu);
            ResizeControl(CajunYenileButonu, recCajunYenilemeButonu);
            ResizeControl(CajunAramaGirdisi, recCajunAramaGirdisi);
            ResizeControl(BereketAnydeskEkleButonu, recBereketAnydeskEkleButonu);
            ResizeControl(BereketDataGrid, recBereketDataGrid);
            ResizeControl(BereketAramaButonu, recBereketAramaButonu);
            ResizeControl(BereketYenileButonu, recBereketYenilemeButonu);
            ResizeControl(BereketAramaGirdisi, recBereketAramaGirdisi);
            ResizeControl(DigerAnydeskEkleButonu, recDigerAnydeskEkleButonu);
            ResizeControl(DigerDataGrid, recDigerDataGrid);
            ResizeControl(DigerAramaButonu, recDigerAramaButonu);
            ResizeControl(DigerYenileButonu, recDigerYenilemeButonu);
            ResizeControl(DigerAramaGirdisi, recDigerAramaGirdisi);
            ResizeControl(HeyAnydeskEkleButonu, recHeyAnydeskEkleButonu);
            ResizeControl(HeyDataGrid, recHeyDataGrid);
            ResizeControl(HeyAramaButonu, recHeyAramaButonu);
            ResizeControl(HeyYenileButonu, recHeyYenilemeButonu);
            ResizeControl(HeyAramaGirdisi, recHeyAramaGirdisi);
        }

        private void ResizeControl(Control control, Rectangle rect)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(rect.X * xRatio);
            int newY = (int)(rect.Y * yRatio);

            int newWidth = (int)(rect.Width * xRatio);
            int newHeight = (int)(rect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            AnydeskDAO anydeskDAO = new AnydeskDAO();
            BindingSource MaydonozBindingSource = new BindingSource();
            BindingSource KofteciYusufBindingSource = new BindingSource();
            BindingSource KomageneBindingSource = new BindingSource();
            BindingSource CajunCornerBindingSource = new BindingSource();
            BindingSource BereketDonerBindingSource = new BindingSource();
            BindingSource HotDonerBindingSource = new BindingSource();
            BindingSource HeyDonerBindingSource = new BindingSource();
            BindingSource DigerBindingSource = new BindingSource();

            MaydonozBindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Maydonoz");
            KofteciYusufBindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Kofteci");
            KomageneBindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Komagene");
            CajunCornerBindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Cajun");
            BereketDonerBindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Bereket");
            HotDonerBindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Hot");
            HeyDonerBindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Hey");
            DigerBindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Diger");

            MaydonozDataGrid.DataSource = MaydonozBindingSource;
            KofteciDataGrid.DataSource = KofteciYusufBindingSource;
            KomageneDataGrid.DataSource = KomageneBindingSource;
            CajunDataGrid.DataSource = CajunCornerBindingSource;
            BereketDataGrid.DataSource = BereketDonerBindingSource;
            HotDataGrid.DataSource = HotDonerBindingSource;
            HeyDataGrid.DataSource = HeyDonerBindingSource;
            DigerDataGrid.DataSource = DigerBindingSource;

            KomageneDataGrid.DataBindingComplete += KomageneDataGrid_DataBindingComplete;

            SetAcceptButtonForActiveTab();
        }
        internal void AnydeskiBaslat(object anydeskNumarasi)
        {
            try
            {
                anydeskNumarasi = anydeskNumarasi.ToString().Replace(" ", "");
                string anydeskConnectCommand = $"\"C:\\Program Files (x86)\\AnyDesk\\AnyDesk.exe\" {anydeskNumarasi}";
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + anydeskConnectCommand,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                System.Diagnostics.Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void AnydeskiSifreyleBaslat(object anydeskNumarasi, object anydeskParolasi)
        {
            try
            {
                anydeskNumarasi = anydeskNumarasi.ToString().Replace(" ", "");
                string anydeskConnectCommand = $"echo {anydeskParolasi} | \"C:\\Program Files (x86)\\AnyDesk\\AnyDesk.exe\" {anydeskNumarasi} --with-password";
                System.Diagnostics.ProcessStartInfo startInfo = new()
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + anydeskConnectCommand,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                System.Diagnostics.Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void KomageneDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = KomageneDataGrid.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = KomageneDataGrid.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    KomageneDataGrid.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            KomageneDataGrid.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void KomageneDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in KomageneDataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }
        private void BereketDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = BereketDataGrid.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = BereketDataGrid.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    BereketDataGrid.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            BereketDataGrid.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void BereketDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in BereketDataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void CajunDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = CajunDataGrid.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = CajunDataGrid.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    CajunDataGrid.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            CajunDataGrid.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void CajunDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in CajunDataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void HotDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = HotDataGrid.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = HotDataGrid.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    HotDataGrid.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            HotDataGrid.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void HotDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in HotDataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }
        private void HeyDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = HeyDataGrid.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = HeyDataGrid.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {

                if (oldColumn == newColumn &&
                    HeyDataGrid.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }
            HeyDataGrid.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void HeyDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in HeyDataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }
        private void KofteciDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = KofteciDataGrid.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = KofteciDataGrid.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    KofteciDataGrid.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            KofteciDataGrid.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void KofteciDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in KofteciDataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }
        private void DigerDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = DigerDataGrid.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = DigerDataGrid.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    DigerDataGrid.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            DigerDataGrid.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void DigerDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in DigerDataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }





        internal void KomageneDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == KomageneDataGrid.Columns["KomageneBaglanButonu"].Index)
            {
                object anydeskNumarasi = KomageneDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiBaslat(anydeskNumarasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == KomageneDataGrid.Columns["KomageneSifreyleBaglanButonu"].Index)
            {
                object anydeskNumarasi = KomageneDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = KomageneDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiSifreyleBaslat(anydeskNumarasi, anydeskParolasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == KomageneDataGrid.Columns["KomageneDuzenleButonu"].Index)
            {
                object bilgisayarYetkisi = KomageneDataGrid.Rows[e.RowIndex].Cells["BilgisayarYetkisi"].Value;
                object subeAdi = KomageneDataGrid.Rows[e.RowIndex].Cells["ŞubeninAdı"].Value;
                object anydeskNumarasi = KomageneDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = KomageneDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    string? anydeskParolasiString = "";
                    string? subeAdiString = "";
                    string? bilgisayarYetkisiString = "";
                    try
                    {
                        anydeskParolasiString = anydeskParolasi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Parolası null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        subeAdiString = subeAdi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Şube adı null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        bilgisayarYetkisiString = bilgisayarYetkisi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Bilgisayar Yetkisi null olan en az 1 girdi bulundu.");
                    }
                    string anydeskNumarasiString = anydeskNumarasi.ToString();
                    EditExistingAnydesk editExistingAnydeskKomagene = new EditExistingAnydesk("Komagene");
                    editExistingAnydeskKomagene.SatirinBilgileriniAl(subeAdiString, anydeskNumarasiString, anydeskParolasiString, bilgisayarYetkisiString);
                    editExistingAnydeskKomagene.Show();
                }
            }
        }
        internal void CajunDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == CajunDataGrid.Columns["CajunBaglanButonu"].Index)
            {
                object anydeskNumarasi = CajunDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiBaslat(anydeskNumarasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == CajunDataGrid.Columns["CajunSifreyleBaglanButonu"].Index)
            {
                object anydeskNumarasi = CajunDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = CajunDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiSifreyleBaslat(anydeskNumarasi, anydeskParolasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == CajunDataGrid.Columns["CajunDuzenleButonu"].Index)
            {
                object bilgisayarYetkisi = CajunDataGrid.Rows[e.RowIndex].Cells["BilgisayarYetkisi"].Value;
                object subeAdi = CajunDataGrid.Rows[e.RowIndex].Cells["ŞubeninAdı"].Value;
                object anydeskNumarasi = CajunDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = CajunDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    string? anydeskParolasiString = "";
                    string? subeAdiString = "";
                    string? bilgisayarYetkisiString = "";
                    try
                    {
                        anydeskParolasiString = anydeskParolasi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Parolası null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        subeAdiString = subeAdi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Şube adı null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        bilgisayarYetkisiString = bilgisayarYetkisi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Bilgisayar Yetkisi null olan en az 1 girdi bulundu.");
                    }
                    string anydeskNumarasiString = anydeskNumarasi.ToString();
                    EditExistingAnydesk editExistingAnydeskCajun = new EditExistingAnydesk("Cajun");
                    editExistingAnydeskCajun.SatirinBilgileriniAl(subeAdiString, anydeskNumarasiString, anydeskParolasiString, bilgisayarYetkisiString);
                    editExistingAnydeskCajun.Show();
                }
            }
        }
        internal void KofteciDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == KofteciDataGrid.Columns["KofteciBaglanButonu"].Index)
            {
                object anydeskNumarasi = KofteciDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiBaslat(anydeskNumarasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == KofteciDataGrid.Columns["KofteciSifreyleBaglanButonu"].Index)
            {
                object anydeskNumarasi = KofteciDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = KofteciDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiSifreyleBaslat(anydeskNumarasi, anydeskParolasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == KofteciDataGrid.Columns["KofteciDuzenleButonu"].Index)
            {
                object bilgisayarYetkisi = KofteciDataGrid.Rows[e.RowIndex].Cells["BilgisayarYetkisi"].Value;
                object subeAdi = KofteciDataGrid.Rows[e.RowIndex].Cells["ŞubeninAdı"].Value;
                object anydeskNumarasi = KofteciDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = KofteciDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    string? anydeskParolasiString = "";
                    string? subeAdiString = "";
                    string? bilgisayarYetkisiString = "";
                    try
                    {
                        anydeskParolasiString = anydeskParolasi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Parolası null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        subeAdiString = subeAdi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Şube adı null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        bilgisayarYetkisiString = bilgisayarYetkisi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Bilgisayar Yetkisi null olan en az 1 girdi bulundu.");
                    }
                    string anydeskNumarasiString = anydeskNumarasi.ToString();
                    EditExistingAnydesk editExistingAnydeskKofteci = new EditExistingAnydesk("Kofteci");
                    editExistingAnydeskKofteci.SatirinBilgileriniAl(subeAdiString, anydeskNumarasiString, anydeskParolasiString, bilgisayarYetkisiString);
                    editExistingAnydeskKofteci.Show();
                }
            }
        }
        internal void BereketDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == BereketDataGrid.Columns["BereketBaglanButonu"].Index)
            {
                object anydeskNumarasi = BereketDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiBaslat(anydeskNumarasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == BereketDataGrid.Columns["BereketSifreyleBaglanButonu"].Index)
            {
                object anydeskNumarasi = BereketDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = BereketDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiSifreyleBaslat(anydeskNumarasi, anydeskParolasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == BereketDataGrid.Columns["BereketDuzenleButonu"].Index)
            {
                object bilgisayarYetkisi = BereketDataGrid.Rows[e.RowIndex].Cells["BilgisayarYetkisi"].Value;
                object subeAdi = BereketDataGrid.Rows[e.RowIndex].Cells["ŞubeninAdı"].Value;
                object anydeskNumarasi = BereketDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = BereketDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    string? anydeskParolasiString = "";
                    string? subeAdiString = "";
                    string? bilgisayarYetkisiString = "";
                    try
                    {
                        anydeskParolasiString = anydeskParolasi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Parolası null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        subeAdiString = subeAdi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Şube adı null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        bilgisayarYetkisiString = bilgisayarYetkisi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Bilgisayar Yetkisi null olan en az 1 girdi bulundu.");
                    }
                    string anydeskNumarasiString = anydeskNumarasi.ToString();
                    EditExistingAnydesk editExistingAnydeskBereket = new EditExistingAnydesk("Bereket");
                    editExistingAnydeskBereket.SatirinBilgileriniAl(subeAdiString, anydeskNumarasiString, anydeskParolasiString, bilgisayarYetkisiString);
                    editExistingAnydeskBereket.Show();
                }
            }
        }
        internal void HotDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == HotDataGrid.Columns["HotBaglanButonu"].Index)
            {
                object anydeskNumarasi = HotDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiBaslat(anydeskNumarasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == HotDataGrid.Columns["HotSifreyleBaglanButonu"].Index)
            {
                object anydeskNumarasi = HotDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = HotDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiSifreyleBaslat(anydeskNumarasi, anydeskParolasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == HotDataGrid.Columns["HotDuzenleButonu"].Index)
            {
                object bilgisayarYetkisi = HotDataGrid.Rows[e.RowIndex].Cells["BilgisayarYetkisi"].Value;
                object subeAdi = HotDataGrid.Rows[e.RowIndex].Cells["ŞubeninAdı"].Value;
                object anydeskNumarasi = HotDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = HotDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    string? anydeskParolasiString = "";
                    string? subeAdiString = "";
                    string? bilgisayarYetkisiString = "";
                    try
                    {
                        anydeskParolasiString = anydeskParolasi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Parolası null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        subeAdiString = subeAdi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Şube adı null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        bilgisayarYetkisiString = bilgisayarYetkisi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Bilgisayar Yetkisi null olan en az 1 girdi bulundu.");
                    }
                    string anydeskNumarasiString = anydeskNumarasi.ToString();
                    EditExistingAnydesk editExistingAnydeskHot = new EditExistingAnydesk("Hot");
                    editExistingAnydeskHot.SatirinBilgileriniAl(subeAdiString, anydeskNumarasiString, anydeskParolasiString, bilgisayarYetkisiString);
                    editExistingAnydeskHot.Show();
                }
            }
        }
        internal void MaydonozDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == MaydonozDataGrid.Columns["MaydonozBaglanButonu"].Index)
            {
                object anydeskNumarasi = MaydonozDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiBaslat(anydeskNumarasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == MaydonozDataGrid.Columns["MaydonozSifreyleBaglanButonu"].Index)
            {
                object anydeskNumarasi = MaydonozDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = MaydonozDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiSifreyleBaslat(anydeskNumarasi, anydeskParolasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == MaydonozDataGrid.Columns["MaydonozDuzenleButonu"].Index)
            {
                object bilgisayarYetkisi = MaydonozDataGrid.Rows[e.RowIndex].Cells["BilgisayarYetkisi"].Value;
                object subeAdi = MaydonozDataGrid.Rows[e.RowIndex].Cells["ŞubeninAdı"].Value;
                object anydeskNumarasi = MaydonozDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = MaydonozDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    string? anydeskParolasiString = "";
                    string? subeAdiString = "";
                    string? bilgisayarYetkisiString = "";
                    try
                    {
                        anydeskParolasiString = anydeskParolasi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Parolası null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        subeAdiString = subeAdi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Şube adı null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        bilgisayarYetkisiString = bilgisayarYetkisi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Bilgisayar Yetkisi null olan en az 1 girdi bulundu.");
                    }
                    string anydeskNumarasiString = anydeskNumarasi.ToString();
                    EditExistingAnydesk editExistingAnydeskMaydonoz = new EditExistingAnydesk("Maydonoz");
                    editExistingAnydeskMaydonoz.SatirinBilgileriniAl(subeAdiString, anydeskNumarasiString, anydeskParolasiString, bilgisayarYetkisiString);
                    editExistingAnydeskMaydonoz.Show();
                }
            }
        }

        internal void HeyDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == HeyDataGrid.Columns["HeyBaglanButonu"].Index)
            {
                object anydeskNumarasi = HeyDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiBaslat(anydeskNumarasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == HeyDataGrid.Columns["HeySifreyleBaglanButonu"].Index)
            {
                object anydeskNumarasi = HeyDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = HeyDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiSifreyleBaslat(anydeskNumarasi, anydeskParolasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == HeyDataGrid.Columns["HeyDuzenleButonu"].Index)
            {
                object bilgisayarYetkisi = HeyDataGrid.Rows[e.RowIndex].Cells["BilgisayarYetkisi"].Value;
                object subeAdi = HeyDataGrid.Rows[e.RowIndex].Cells["ŞubeninAdı"].Value;
                object anydeskNumarasi = HeyDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = HeyDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    string? anydeskParolasiString = "";
                    string? subeAdiString = "";
                    string? bilgisayarYetkisiString = "";
                    try
                    {
                        anydeskParolasiString = anydeskParolasi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Parolası null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        subeAdiString = subeAdi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Şube adı null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        bilgisayarYetkisiString = bilgisayarYetkisi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Bilgisayar Yetkisi null olan en az 1 girdi bulundu.");
                    }
                    string anydeskNumarasiString = anydeskNumarasi.ToString();
                    EditExistingAnydesk editExistingAnydeskHey = new EditExistingAnydesk("Hey");
                    editExistingAnydeskHey.SatirinBilgileriniAl(subeAdiString, anydeskNumarasiString, anydeskParolasiString, bilgisayarYetkisiString);
                    editExistingAnydeskHey.Show();
                }
            }
        }
        internal void DigerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DigerDataGrid.Columns["DigerBaglanButonu"].Index)
            {
                object anydeskNumarasi = DigerDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiBaslat(anydeskNumarasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == DigerDataGrid.Columns["DigerSifreyleBaglanButonu"].Index)
            {
                object anydeskNumarasi = DigerDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = DigerDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    AnydeskiSifreyleBaslat(anydeskNumarasi, anydeskParolasi);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == DigerDataGrid.Columns["DigerDuzenleButonu"].Index)
            {
                object bilgisayarYetkisi = DigerDataGrid.Rows[e.RowIndex].Cells["BilgisayarYetkisi"].Value;
                object subeAdi = DigerDataGrid.Rows[e.RowIndex].Cells["ŞubeninAdı"].Value;
                object anydeskNumarasi = DigerDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = DigerDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
                {
                    string? anydeskParolasiString = "";
                    string? subeAdiString = "";
                    string? bilgisayarYetkisiString = "";
                    try
                    {
                        anydeskParolasiString = anydeskParolasi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Parolası null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        subeAdiString = subeAdi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Şube adı null olan en az 1 girdi bulundu.");
                    }
                    try
                    {
                        bilgisayarYetkisiString = bilgisayarYetkisi.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Null Reference Exception: Bilgisayar Yetkisi null olan en az 1 girdi bulundu.");
                    }
                    string anydeskNumarasiString = anydeskNumarasi.ToString();
                    EditExistingAnydesk editExistingAnydeskDiger = new EditExistingAnydesk("Diger");
                    editExistingAnydeskDiger.SatirinBilgileriniAl(subeAdiString, anydeskNumarasiString, anydeskParolasiString, bilgisayarYetkisiString);
                    editExistingAnydeskDiger.Show();
                }
            }
        }

        private void KomageneAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydesk addNewAnydesk = new("Komagene");
            addNewAnydesk.Show();
        }
        private void MaydonozAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydesk addNewAnydesk = new("Maydonoz");
            addNewAnydesk.Show();
        }
        private void BereketAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydesk addNewAnydesk = new("Bereket");
            addNewAnydesk.Show();
        }
        private void HotAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydesk addNewAnydesk = new("Hot");
            addNewAnydesk.Show();
        }
        private void KofteciAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydesk addNewAnydesk = new("Kofteci");
            addNewAnydesk.Show();
        }
        private void DigerAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydesk addNewAnydesk = new("Diger");
            addNewAnydesk.Show();
        }
        private void CajunAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydesk addNewAnydesk = new("Cajun");
            addNewAnydesk.Show();
        }
        private void HeyAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydesk addNewAnydesk = new("Hey");
            addNewAnydesk.Show();
        }
        private void KomageneYenilemeButonu_Click(object sender, EventArgs e)
        {
            SayfaYenile("Komagene");
        }
        private void MaydonozYenilemeButonu_Click(object sender, EventArgs e)
        {
            SayfaYenile("Maydonoz");
        }
        private void HotYenilemeButonu_Click(object sender, EventArgs e)
        {
            SayfaYenile("Hot");
        }
        private void BereketYenilemeButonu_Click(object sender, EventArgs e)
        {
            SayfaYenile("Bereket");
        }
        private void CajunYenilemeButonu_Click(object sender, EventArgs e)
        {
            SayfaYenile("Cajun");
        }
        private void DigerYenilemeButonu_Click(object sender, EventArgs e)
        {
            SayfaYenile("Diger");
        }
        private void HeyYenilemeButonu_Click(object sender, EventArgs e)
        {
            SayfaYenile("Hey");
        }
        
        internal static void SayfaYenile(string sirketAdi)
        {
            AnydeskDAO anydeskDAO = new AnydeskDAO();
            BindingSource bindingSource = new BindingSource();
            switch (sirketAdi)
            {
                case "Bereket":
                    bindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Bereket");
                    BereketDataGrid.DataSource = bindingSource;
                    BereketDataGrid.Refresh();
                    break;
                case "Cajun":
                    bindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Cajun");
                    CajunDataGrid.DataSource = bindingSource;
                    CajunDataGrid.Refresh();
                    break;
                case "Diger":
                    bindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Diger");
                    DigerDataGrid.DataSource = bindingSource;
                    DigerDataGrid.Refresh();
                    break;
                case "Hey":
                    bindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Hey");
                    HeyDataGrid.DataSource = bindingSource;
                    HeyDataGrid.Refresh();
                    break;
                case "Hot":
                    bindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Hot");
                    HotDataGrid.DataSource = bindingSource;
                    HotDataGrid.Refresh();
                    break;
                case "Kofteci":
                    bindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Kofteci");
                    KofteciDataGrid.DataSource = bindingSource;
                    KofteciDataGrid.Refresh();
                    break;
                case "Komagene":
                    bindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Komagene");
                    KomageneDataGrid.DataSource = bindingSource;
                    KomageneDataGrid.Refresh();
                    break;
                case "Maydonoz":
                    bindingSource.DataSource = anydeskDAO.AnydeskleriGetir("Maydonoz");
                    MaydonozDataGrid.DataSource = bindingSource;
                    MaydonozDataGrid.Refresh();
                    break;
            }
        }

        public static string? subeAdiylaAramaGirdisi;
        private void KomageneSubeAdiTextBox_TextChanged(object sender, EventArgs e)
        {
            subeAdiylaAramaGirdisi = KomageneSubeAdiTextBox.Text;
        }
        private void CajunAramaGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAdiylaAramaGirdisi = CajunAramaGirdisi.Text;
        }
        private void MaydonozAramaGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAdiylaAramaGirdisi = MaydonozAramaGirdisi.Text;
        }
        private void HotAramaGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAdiylaAramaGirdisi = HotAramaGirdisi.Text;
        }
        private void BereketAramaGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAdiylaAramaGirdisi = BereketAramaGirdisi.Text;
        }
        private void KofteciAramaGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAdiylaAramaGirdisi = KofteciAramaGirdisi.Text;
        }
        private void HeyAramaGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAdiylaAramaGirdisi = HeyAramaGirdisi.Text;
        }
        private void DigerAramaGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAdiylaAramaGirdisi = DigerAramaGirdisi.Text;
        }

        private void KomageneAramaButonu_Click(object sender, EventArgs e)
        {
            SearchFunction.BindSearchData(KomageneDataGrid, "Komagene");
            KomageneDataGrid.Refresh();
        }
        private void CajunAramaButonu_Click(object sender, EventArgs e)
        {
            SearchFunction.BindSearchData(CajunDataGrid, "Cajun");
            CajunDataGrid.Refresh();
        }
        private void KofteciAramaButonu_Click(object sender, EventArgs e)
        {
            SearchFunction.BindSearchData(KofteciDataGrid, "Kofteci");
            KofteciDataGrid.Refresh();
        }
        private void BereketAramaButonu_Click(object sender, EventArgs e)
        {
            SearchFunction.BindSearchData(BereketDataGrid, "Bereket");
            KomageneDataGrid.Refresh();
        }
        private void HotAramaButonu_Click(object sender, EventArgs e)
        {
            SearchFunction.BindSearchData(HotDataGrid, "Hot");
            HotDataGrid.Refresh();
        }
        private void MaydonozAramaButonu_Click(object sender, EventArgs e)
        {
            SearchFunction.BindSearchData(MaydonozDataGrid, "Maydonoz");
            MaydonozDataGrid.Refresh();
        }
        private void HeyAramaButonu_Click(object sender, EventArgs e)
        {
            SearchFunction.BindSearchData(HeyDataGrid, "Hey");
            HeyDataGrid.Refresh();
        }
        private void DigerAramaButonu_Click(object sender, EventArgs e)
        {
            SearchFunction.BindSearchData(DigerDataGrid, "Diger");
            DigerDataGrid.Refresh();
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAcceptButtonForActiveTab();
        }

        private void SetAcceptButtonForActiveTab()
        {
            if (maınTabControl.SelectedTab == KomageneTab)
            {
                AcceptButton = KomageneAramaButonu;
                KomageneSubeAdiTextBox.Focus();
            }
            else if (maınTabControl.SelectedTab == CajunTab)
            {
                AcceptButton = CajunAramaButonu;
                CajunAramaGirdisi.Focus();
            }
            else if (maınTabControl.SelectedTab == HotTab)
            {
                AcceptButton = HotAramaButonu;
                HotAramaGirdisi.Focus();
            }
            else if (maınTabControl.SelectedTab == BereketTab)
            {
                AcceptButton = BereketAramaButonu;
                BereketAramaGirdisi.Focus();
            }
            else if (maınTabControl.SelectedTab == KofteciTab)
            {
                AcceptButton = KofteciAramaButonu;
                KofteciAramaGirdisi.Focus();
            }
            else if (maınTabControl.SelectedTab == MaydonozTab)
            {
                AcceptButton = MaydonozAramaButonu;
                MaydonozAramaGirdisi.Focus();
            }
            else if (maınTabControl.SelectedTab == DigerTab)
            {
                AcceptButton = DigerAramaButonu;
                DigerAramaGirdisi.Focus();
            }
            else if (maınTabControl.SelectedTab == HeyTab)
            {
                AcceptButton = HeyAramaButonu;
                HeyAramaGirdisi.Focus();
            }
        }
    }
}