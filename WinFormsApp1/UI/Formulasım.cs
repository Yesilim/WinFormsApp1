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
    public partial class Formulasım : Form
    {
        public Ulaşım ulaşım { get; internal set; }

        public Formulasım()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ulaşım.UlaşımTürü = txtulas.Text;
            ulaşım.KalkışŞehri = txtkalkıs.Text;
            ulaşım.Şoföradı = txtsoför.Text;
            ulaşım.VarışŞehri = txtvarıs.Text;


        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void Formulasım_Load(object sender, EventArgs e)
        {

        }
    }
}
