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
    public partial class FormSatis : Form
    {
        public Satislar satis { get; set; }

        public FormSatis()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            satis.Filmid = txtfilmad.Text;
            satis.Musteriid = txtmusteriad.Text;
            satis.SatisFiyat = txtsfiyat.Text;
            DialogResult = DialogResult.OK;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void Formulasım_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
