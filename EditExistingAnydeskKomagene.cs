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
    public partial class EditExistingAnydeskKomagene : Form
    {
        public EditExistingAnydeskKomagene()
        {
            InitializeComponent();
            AnydeskNumarasıGirdisi.Text = satirinAnydeskNumarasi;
            AnydeskParolasıGirdisi.Text = satirinAnydeskParolasi;
            ŞubeAdıGirdisi.Text = satirinSubeAdi;
            BilgisayarYetkisiComboBox.Text = satirinBilgisayarYetkisi;
        }
        string satirinAnydeskNumarasi = "";
        string satirinAnydeskParolasi = "";
        string satirinSubeAdi = "";
        string satirinBilgisayarYetkisi = "";
        internal void SatirinBilgileriniAl(string subeAdi, string anydeskNumarasi, string anydeskParolasi, string bilgisayarYetkisi)
        {
            satirinAnydeskNumarasi = subeAdi;
            satirinAnydeskParolasi = anydeskNumarasi;
            satirinSubeAdi = anydeskParolasi;
            satirinBilgisayarYetkisi = bilgisayarYetkisi;
        }
    }
}
