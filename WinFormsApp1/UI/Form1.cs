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
            Form�r�nler Form�r�nler = new Form�r�nler()
            {
                Text = "�r�n Ekle",
                �r�nler = new �r�nler { UrunKodu = Guid.NewGuid(), }
            };
            tekrar:
            var sonuc = Form�r�nler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
               bool b=BLogic.�r�nekle(Form�r�nler.�r�nler);
                if (b)
                {
                DataSet ds = BLogic.�r�nGetir(toolStripTextBox1.Text);
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

            FormD�kkan formD�kkan = new FormD�kkan()
            {
                Text = "D�kkan Ekle",
                d�kkan = new D�kkan { M�d�r = Guid.NewGuid(), }
            };
            tekrar:
            var sonuc = formD�kkan.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b=BLogic.d�kkanekle(formD�kkan.d�kkan);

                DataSet ds = BLogic.d�kkanGetir(toolStripTextBox6.Text);
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
                Text = "�al��an Ekle",
                calisan = new �al��an { Pozisyon = Guid.NewGuid(), }
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
            Formulas�m formulas�m = new Formulas�m()
            {
                Text = "Ula��m Ekle",
                ula��m = new Ula��m { Ara�numaras� = Guid.NewGuid(), }
            };  
            tekrar:
            var sonuc = formulas�m.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ula��mekle(formulas�m.ula��m);
              
                if (b)
                {
                    DataSet ds = BLogic.ula��mekle(toolStripTextBox4.Text);
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
            DataSet ds = BLogic.�r�nGetir(toolStripTextBox1.Text);
            if(ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];          
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.d�kkanGetir(toolStripTextBox6.Text);
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
            DataSet ds = BLogic.ulas�mGetir(toolStripTextBox4.Text);
            if (ds != null)
            {
                dataGridView5.DataSource = ds.Tables[0];
            }
        }

        
    }
}
