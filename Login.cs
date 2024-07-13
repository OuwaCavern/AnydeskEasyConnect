using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnydeskEasyConnect
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string? kullaniciAdi;
        public string? kullaniciParolasi;

        private void KullaniciAdiGirdisi_TextChanged(object sender, EventArgs e)
        {
            kullaniciAdi = KullaniciAdiGirdisi.Text;
        }

        private void KullaniciParolasiGirdisi_TextChanged(object sender, EventArgs e)
        {
            kullaniciParolasi = KullaniciParolasiGirdisi.Text;
        }
    }
}
