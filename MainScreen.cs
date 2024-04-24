﻿using Microsoft.Identity.Client;
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
            mainTabControl.SelectedIndexChanged += mainTabControl_SelectedIndexChanged;
            this.Resize += MainScreen_Resiz;
            formOriginalSize = this.Size;
            recAnydeskEKleButonu = new Rectangle(KomageneAnydeskEkleButonu.Location, KomageneAnydeskEkleButonu.Size);
            recKomageneDataGrid = new Rectangle(KomageneDataGrid.Location, KomageneDataGrid.Size);
            recAramaButonu = new Rectangle(KomageneAramaButonu.Location, KomageneAramaButonu.Size);
            recAramaGirdisi = new Rectangle(KomageneSubeAdiTextBox.Location, KomageneSubeAdiTextBox.Size);
            recYenilemeButonu = new Rectangle(KomageneYenilemeButonu.Location, KomageneYenilemeButonu.Size);
            WindowState = FormWindowState.Maximized;
        }
        private Size formOriginalSize;
        private Rectangle recAnydeskEKleButonu;
        private Rectangle recKomageneDataGrid;
        private Rectangle recAramaButonu;
        private Rectangle recYenilemeButonu;
        private Rectangle recAramaGirdisi;

        private void MainScreen_Resiz(object sender, EventArgs e)
        {
            ResizeControl(KomageneAnydeskEkleButonu, recAnydeskEKleButonu);
            ResizeControl(KomageneDataGrid, recKomageneDataGrid);
            ResizeControl(KomageneAramaButonu, recAramaButonu);
            ResizeControl(KomageneYenilemeButonu, recYenilemeButonu);
            ResizeControl(KomageneSubeAdiTextBox, recAramaGirdisi);
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

            KomageneDataGrid.Columns[3].Width = 500;
        }
        internal void KomageneDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == KomageneDataGrid.Columns["KomageneBaglanButonu"].Index)
            {
                object anydeskNumarasi = KomageneDataGrid.Rows[e.RowIndex].Cells["ŞubeninAnydeskNumarası"].Value;
                if (anydeskNumarasi != null)
                {
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
                        MessageBox.Show("Şubenin Anydesk numarası boş!");
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
            AddNewAnydeskKomagene addNewAnydesk = new AddNewAnydeskKomagene();
            addNewAnydesk.Show();
        }

        private void KomageneYenilemeButonu_Click(object sender, EventArgs e)
        {
            KomageneYenile();
        }

        internal static void KomageneYenile()
        {
            AnydeskDAO anydeskDAO = new AnydeskDAO();
            BindingSource KomageneBindingSource = new BindingSource();
            KomageneBindingSource.DataSource = anydeskDAO.KomageneAnydeskleriniGetir();
            KomageneDataGrid.DataSource = KomageneBindingSource;
            KomageneDataGrid.Refresh();
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
            if (mainTabControl.SelectedTab == KomageneTab)
            {
                AcceptButton = KomageneAramaButonu;
            }
        }
    }
}
