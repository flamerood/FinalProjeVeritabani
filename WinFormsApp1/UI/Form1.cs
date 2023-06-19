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
            FormFilmler FormFilmler = new FormFilmler()
            {
                Text = "Film Ekle",
                Filmler = new Filmler { FilmID = Guid.NewGuid() },
            };
        tekrar:
            var sonuc = FormFilmler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.filmekle(FormFilmler.Filmler);
                if (b)
                {
                    DataSet ds = BLogic.FilmGetir(toolStripTextBox1.Text);
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

            FormMusteri FormMusteri = new FormMusteri()
            {
                Text = "Müþteri Ekle",
                Musteriler = new Musteriler { MusteriID = Guid.NewGuid(), }
            };
        tekrar:
            var sonuc = FormMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.musteriekle(FormMusteri.Musteriler);

                DataSet ds = BLogic.musteriGetir(toolStripTextBox6.Text);
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
            FormOdeme FormOdeme = new FormOdeme()
            {
                Text = "Odeme Ekle",
                ode = new Odemeler { OdemeID = Guid.NewGuid(), }
            };
        tekrar:
            var sonuc = FormOdeme.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.odemeekle(FormOdeme.ode);
                if (b)
                {
                    DataSet ds = BLogic.odemeGetir(toolStripTextBox2.Text);
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

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

            DataSet ds = BLogic.satisGetir(txtbox.Text);
            if (ds != null)
            {
                dataGridView4.DataSource = ds.Tables[0];
            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnurunbul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.FilmGetir(toolStripTextBox1.Text);
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.musteriGetir(toolStripTextBox6.Text);
            if (ds != null)
            {
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.odemeGetir(toolStripTextBox2.Text);
            if (ds != null)
            {
                dataGridView3.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FormSatis FormSatis = new FormSatis()
            {
                Text = "Satýþ Ekle",
                satis = new Satislar { SatisID = Guid.NewGuid(), }
            };
        tekrar:
            var sonuc = FormSatis.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.satisekle(FormSatis.satis);
                if (b)
                {
                    DataSet ds = BLogic.satisekle(txtbox.Text);
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
        private void toolStripTextBox6_Click(object sender, EventArgs e)
        {
            
        }



    }
}
