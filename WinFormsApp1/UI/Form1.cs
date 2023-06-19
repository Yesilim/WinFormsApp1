using System.Data;
using WinFormsApp1.BL;
using WinFormsApp1.UI;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FormÜrünler FormÜrünler = new FormÜrünler()
            {
                Text = "Ürün Ekle",
                ürünler = new Ürünler { UrunKodu = Guid.NewGuid(), }
            };
            tekrar:
            var sonuc = FormÜrünler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
               bool b=BLogic.ürünekle(FormÜrünler.ürünler);
                if (b)
                {
                DataSet ds = BLogic.ÜrünGetir(toolStripTextBox1.Text);
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                else
                    {
                        goto tekrar;
                    }
                }
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            FormDükkan formDükkan = new FormDükkan()
            {
                Text = "Dükkan Ekle",
                dükkan = new Dükkan { Müdür = Guid.NewGuid(), }
            };
            tekrar:
            var sonuc = formDükkan.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b=BLogic.dükkanekle(formDükkan.dükkan);

                DataSet ds = BLogic.dükkanGetir(toolStripTextBox6.Text);
                if (b)
                {
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Formdenetmen Formdenetmen = new Formdenetmen()
            {
                Text = "Denetmen Ekle",
                d = new Denetmen { Pozisyon = Guid.NewGuid(), }
            };
            tekrar:
            var sonuc = Formdenetmen.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.denetmenekle(Formdenetmen.d);
                if (b)
                {
                    DataSet ds = BLogic.denetmengetir(toolStripTextBox2.Text);
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

            }

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Formcalisan formcalisan = new Formcalisan()
            {
                Text = "Çalýþan Ekle",
                calisan = new Çalýþan { Pozisyon = Guid.NewGuid(), }
            };
            tekrar:
            var sonuc = formcalisan.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.calisanekle(formcalisan.calisan);
                if (b)
                {
                    DataSet ds = BLogic.calisanekle(calisanAra.Text);
                    if (ds != null)
                    {
                        dataGridView4.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

            }


        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Formulasým formulasým = new Formulasým()
            {
                Text = "Ulaþým Ekle",
                ulaþým = new Ulaþým { Araçnumarasý = Guid.NewGuid(), }
            };  
            tekrar:
            var sonuc = formulasým.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ulaþýmekle(formulasým.ulaþým);
              
                if (b)
                {
                    DataSet ds = BLogic.ulaþýmekle(toolStripTextBox4.Text);
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        goto tekrar;
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnurunbul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.ÜrünGetir(toolStripTextBox1.Text);
            if(ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];          
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.dükkanGetir(toolStripTextBox6.Text);
            if (ds != null)
            {
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.denetmengetir(toolStripTextBox2.Text);
            if (ds != null)
            {
                dataGridView3.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.calisangetir(calisanAra.Text);
            if (ds != null)
            {
                dataGridView4.DataSource = ds.Tables[0];
            }
        }
        private void toolStripTextBox6_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.ulasýmGetir(toolStripTextBox4.Text);
            if (ds != null)
            {
                dataGridView5.DataSource = ds.Tables[0];
            }
        }

        
    }
}
