using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
namespace WinFormsApp1.UI
{
    public partial class Formdenetmen : Form
    {
        internal static object denetmen;

        public Denetmen d { get; internal set; }

        public Formdenetmen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            d.Ad = txtad.Text;
            d.Maaş = txtmaas.Text;
            d.Soyad = txtsoyad.Text;
            d.İşeGirişTarihi = txttarih.Text;

        }

        private void txtyer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstok_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdugme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void Formdenetmen_Load(object sender, EventArgs e)
        {

        }
    }
}
