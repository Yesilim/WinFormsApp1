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
    public partial class FormDükkan : Form
    {
        public Dükkan dükkan { get; internal set; }

        public FormDükkan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormDükkan_Load(object sender, EventArgs e)
        {

        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            dükkan.PaketAdi = txtpaket.Text;
            dükkan.Adres = txtadr.Text;
            dükkan.İşçiSayisi = txtişcisay.Text;
            dükkan.TelefonNumarasi = txttelno.Text;

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
