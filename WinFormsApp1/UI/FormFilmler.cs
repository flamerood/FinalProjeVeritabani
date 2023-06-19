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
    public partial class FormFilmler : Form
    {
        public Filmler Filmler { get; set; }

       
        public FormFilmler()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Filmler.Ad = txtad.Text;
            Filmler.icerik = txticerik.Text;
            Filmler.yonetmen = txtyonetmen.Text;
            Filmler.oyuncular = txtyer.Text;
            Filmler.tur = txttur.Text;
            Filmler.cikisyili = txtyil.Text;

        }

        private void txtKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void FormFilmler_Load(object sender, EventArgs e)
        {

        }

     
    }
}
