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
    public partial class FormMusteri : Form
    {
        public Musteriler Musteriler { get; internal set; }

        public FormMusteri()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {

        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Musteriler.Ad = txtmad.Text;
            Musteriler.Soyad = txtmsoy.Text;
            Musteriler.Adres = txtadr.Text;
            Musteriler.Telefon = txttelno.Text;
            Musteriler.Mail = txtmail.Text;
            DialogResult = DialogResult.OK;


        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
