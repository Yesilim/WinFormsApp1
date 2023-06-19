using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.UI
{
    public partial class Formcalisan : Form
    {
        internal Çalışan calisan;

        public Formcalisan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Formcalisan_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            calisan.Ad = txtisad.Text;
            calisan.Soyad = txtissoy.Text;
            calisan.TCNumarası = txttcno.Text;
            calisan.Yaş = txtyas.Text;
            calisan.Maaş = txtmaas.Text;
            calisan.TelefonNo = txttelno.Text;
            calisan.VardiyalıMı = txtvardi.Text;

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
