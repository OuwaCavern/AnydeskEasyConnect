using Microsoft.Identity.Client;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
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
            recAdileAnydeskEkleButonu = new Rectangle(AdileAnydeskEkleButonu.Location, AdileAnydeskEkleButonu.Size);
            recAdileDataGrid = new Rectangle(AdileDataGrid.Location, AdileDataGrid.Size);
            recAdileAramaButonu = new Rectangle(AdileAramaButonu.Location, AdileAramaButonu.Size);
            recAdileAramaGirdisi = new Rectangle(AdileAramaGirdisi.Location, AdileAramaGirdisi.Size);
            recAdileYenilemeButonu = new Rectangle(AdileYenileButonu.Location, AdileYenileButonu.Size);
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
            WindowState = FormWindowState.Maximized;
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
        private Rectangle recAdileAnydeskEkleButonu;
        private Rectangle recAdileDataGrid;
        private Rectangle recAdileAramaButonu;
        private Rectangle recAdileYenilemeButonu;
        private Rectangle recAdileAramaGirdisi;
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

        private void MainScreen_Resiz(object sender, EventArgs e)
        {
            ResizeControl(KomageneAnydeskEkleButonu, recKomageneAnydeskEkleButonu);
            ResizeControl(KomageneDataGrid, recKomageneDataGrid);
            ResizeControl(KomageneAramaButonu, recKomageneAramaButonu);
            ResizeControl(KomageneYenilemeButonu, recKomageneYenilemeButonu);
            ResizeControl(KomageneSubeAdiTextBox, recKomageneAramaGirdisi);
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
            BindingSource AdileSultanBindingSource = new BindingSource();
            BindingSource DigerBindingSource = new BindingSource();

            MaydonozBindingSource.DataSource = anydeskDAO.MaydonozAnydeskleriniGetir();
            KofteciYusufBindingSource.DataSource = anydeskDAO.KofteciYusufAnydeskleriniGetir();
            KomageneBindingSource.DataSource = anydeskDAO.KomageneAnydeskleriniGetir();
            CajunCornerBindingSource.DataSource = anydeskDAO.CajunCornerAnydeskleriniGetir();
            BereketDonerBindingSource.DataSource = anydeskDAO.BereketDonerAnydeskleriniGetir();
            HotDonerBindingSource.DataSource = anydeskDAO.HotDonerAnydeskleriniGetir();
            AdileSultanBindingSource.DataSource = anydeskDAO.AdileSultanAnydeskleriniGetir();
            DigerBindingSource.DataSource = anydeskDAO.DigerAnydeskleriniGetir();

            MaydonozDataGrid.DataSource = MaydonozBindingSource;
            KofteciDataGrid.DataSource = KofteciYusufBindingSource;
            KomageneDataGrid.DataSource = KomageneBindingSource;
            CajunDataGrid.DataSource = CajunCornerBindingSource;
            BereketDataGrid.DataSource = BereketDonerBindingSource;
            HotDataGrid.DataSource = HotDonerBindingSource;
            AdileDataGrid.DataSource = AdileSultanBindingSource;
            DigerDataGrid.DataSource = DigerBindingSource;

            SetAcceptButtonForActiveTab();
        }
        internal void KomageneDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == KomageneDataGrid.Columns["KomageneBaglanButonu"].Index)
            {
                object anydeskNumarasi = KomageneDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                if (anydeskNumarasi != null)
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
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == KomageneDataGrid.Columns["KomageneSifreyleBaglanButonu"].Index)
            {
                object anydeskNumarasi = KomageneDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                object anydeskParolasi = KomageneDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskParolası"].Value;
                if (anydeskNumarasi != null)
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
                    EditExistingAnydeskKomagene editExistingAnydeskKomagene = new EditExistingAnydeskKomagene();
                    editExistingAnydeskKomagene.SatirinBilgileriniAl(subeAdiString, anydeskNumarasiString, anydeskParolasiString, bilgisayarYetkisiString);
                    editExistingAnydeskKomagene.Show();
                }
            }
        }
        private void KomageneAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydeskKomagene addNewAnydesk = new();
            addNewAnydesk.Show();
        }
        private void AdileAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydeskAdile addNewAnydesk = new();
            addNewAnydesk.Show();
        }
        private void MaydonozAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydeskMaydonoz addNewAnydesk = new();
            addNewAnydesk.Show();
        }
        private void BereketAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydeskBereket addNewAnydesk = new();
            addNewAnydesk.Show();
        }
        private void HotAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydeskHot addNewAnydesk = new();
            addNewAnydesk.Show();
        }
        private void KofteciAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydeskKofteci addNewAnydesk = new();
            addNewAnydesk.Show();
        }
        private void DigerAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydeskDiger addNewAnydesk = new();
            addNewAnydesk.Show();
        }
        private void CajunAnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydeskCajun addNewAnydesk = new();
            addNewAnydesk.Show();
        }
        private void KomageneYenilemeButonu_Click(object sender, EventArgs e)
        {
            KomageneYenile();
        }
        private void AdileYenilemeButonu_Click(object sender, EventArgs e)
        {
            AdileYenile();
        }
        private void MaydonozYenilemeButonu_Click(object sender, EventArgs e)
        {
            MaydonozYenile();
        }
        private void HotYenilemeButonu_Click(object sender, EventArgs e)
        {
            HotYenile();
        }
        private void BereketYenilemeButonu_Click(object sender, EventArgs e)
        {
            BereketYenile();
        }
        private void CajunYenilemeButonu_Click(object sender, EventArgs e)
        {
            CajunYenile();
        }

        internal static void AdileYenile()
        {
            AnydeskDAO anydeskDAO = new AnydeskDAO();
            BindingSource AdileBindingSource = new BindingSource();
            AdileBindingSource.DataSource = anydeskDAO.AdileSultanAnydeskleriniGetir();
            AdileDataGrid.DataSource = AdileBindingSource;
            AdileDataGrid.Refresh();
        }
        internal static void CajunYenile()
        {
            AnydeskDAO anydeskDAO = new AnydeskDAO();
            BindingSource CajunBindingSource = new BindingSource();
            CajunBindingSource.DataSource = anydeskDAO.CajunCornerAnydeskleriniGetir();
            CajunDataGrid.DataSource = CajunBindingSource;
            CajunDataGrid.Refresh();
        }
        internal static void MaydonozYenile()
        {
            AnydeskDAO anydeskDAO = new AnydeskDAO();
            BindingSource MaydonozBindingSource = new BindingSource();
            MaydonozBindingSource.DataSource = anydeskDAO.MaydonozAnydeskleriniGetir();
            MaydonozDataGrid.DataSource = MaydonozBindingSource;
            MaydonozDataGrid.Refresh();
        }

        internal static void BereketYenile()
        {
            AnydeskDAO anydeskDAO = new AnydeskDAO();
            BindingSource BereketBindingSource = new BindingSource();
            BereketBindingSource.DataSource = anydeskDAO.BereketDonerAnydeskleriniGetir();
            BereketDataGrid.DataSource = BereketBindingSource;
            AdileDataGrid.Refresh();
        }

        internal static void HotYenile()
        {
            AnydeskDAO anydeskDAO = new AnydeskDAO();
            BindingSource HotBindingSource = new BindingSource();
            HotBindingSource.DataSource = anydeskDAO.HotDonerAnydeskleriniGetir();
            HotDataGrid.DataSource = HotBindingSource;
            HotDataGrid.Refresh();
        }

        internal static void DigerYenile()
        {
            AnydeskDAO anydeskDAO = new AnydeskDAO();
            BindingSource DigerBindingSource = new BindingSource();
            DigerBindingSource.DataSource = anydeskDAO.DigerAnydeskleriniGetir();
            DigerDataGrid.DataSource = DigerBindingSource;
            DigerDataGrid.Refresh();
        }

        internal static void KomageneYenile()
        {
            AnydeskDAO anydeskDAO = new AnydeskDAO();
            BindingSource KomageneBindingSource = new BindingSource();
            KomageneBindingSource.DataSource = anydeskDAO.KomageneAnydeskleriniGetir();
            KomageneDataGrid.DataSource = KomageneBindingSource;
            KomageneDataGrid.Refresh();
        }
        internal static void KofteciYenile()
        {
            AnydeskDAO anydeskDAO = new AnydeskDAO();
            BindingSource KofteciBindingSource = new BindingSource();
            KofteciBindingSource.DataSource = anydeskDAO.KofteciYusufAnydeskleriniGetir();
            KofteciDataGrid.DataSource = KofteciBindingSource;
            KofteciDataGrid.Refresh();
        }

        public static string? subeAdiylaAramaGirdisi;
        private void KomageneSubeAdiTextBox_TextChanged(object sender, EventArgs e)
        {
            subeAdiylaAramaGirdisi = KomageneSubeAdiTextBox.Text;
        }

        private void KomageneAramaButonu_Click(object sender, EventArgs e)
        {
            SearchFunctionKomagene.BindSearchData(KomageneDataGrid);
            KomageneDataGrid.Refresh();
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
            }
        }
    }
}
