using System.Drawing.Text;

namespace AnydeskEasyConnect
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.Load += MainScreen_Load;
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
        }

        private void KomageneDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == KomageneDataGrid.Columns["KomageneBaglanButonu"].Index)
            {
                object anydeskNumarasi = KomageneDataGrid.Rows[e.RowIndex].Cells["SubeAnydeskNumarasi"].Value;
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
                object anydeskNumarasi = KomageneDataGrid.Rows[e.RowIndex].Cells["SubeAnydeskNumarasi"].Value;
                object anydeskParolasi = KomageneDataGrid.Rows[e.RowIndex].Cells["SubeAnydeskParolasi"].Value;
                if (anydeskNumarasi != null)
                {
                    string anydeskConnectCommand = $"echo {anydeskParolasi} | \"C:\\Program Files (x86)\\AnyDesk\\AnyDesk.exe\" {anydeskNumarasi} --with-password";
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
        }

        private void AnydeskEkleButonu_Click(object sender, EventArgs e)
        {
            AddNewAnydesk addNewAnydesk = new AddNewAnydesk();
            addNewAnydesk.Show();
        }
    }
}
