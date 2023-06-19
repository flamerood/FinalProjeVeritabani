using SixLabors.ImageSharp.Metadata;
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
using WinFormsApp1.BL;

namespace WinFormsApp1.UI
{
    public partial class FormOdeme : Form
    {
        internal static object odeme;

        public Musteriler Musteriler { get; set; }
        public Filmler Filmler { get; set; }
        public Odemeler ode { get; internal set; }

        public FormOdeme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            ode.Filmid = txtfilmad.Text;
            ode.Musteriid = txtmusteriad.Text;
            ode.Tutar = txttutar.Text;
            ode.Aciklama = txtacik.Text;
            ode.OdemeTuru = txtodmtur.Text;
            DialogResult = DialogResult.OK;


        }

        private void txtyer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstok_TextChanged(object sender, EventArgs e)
        {

        }

        private void txticerik_TextChanged(object sender, EventArgs e)
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

        private void FormOdeme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMusteri form = new FormMusteri();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Musteriler = form.Musteriler;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormFilmler form = new FormFilmler();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Filmler = form.Filmler;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            musteri mstr = new musteri("film");

            if (mstr.ShowDialog() == DialogResult.OK)
            {
                txtfilmad.Text = mstr.Musteriid;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteri mstr = new musteri("musteri");

            if (mstr.ShowDialog() == DialogResult.OK)
            {
                txtmusteriad.Text = mstr.Musteriid;
            }
        }
    }
}
