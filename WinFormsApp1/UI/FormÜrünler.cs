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
    public partial class FormÜrünler : Form
    {
        public Ürünler ürünler { get; set; }
        public FormÜrünler()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {   
            DialogResult =DialogResult.OK;
            ürünler.Adi = txtad.Text;
            ürünler.DüğmeSayisi = txtdugme.Text;
            ürünler.stok = txtstok.Text;
            ürünler.YapildiğiYer = txtyer.Text;

        }

        private void txtKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void FormÜrünler_Load(object sender, EventArgs e)
        {

        }
    }
}
