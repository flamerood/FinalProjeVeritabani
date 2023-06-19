using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.BL;

namespace WinFormsApp1.UI
{
    public partial class musteri : Form
    {
        public string Musteriid;
        public musteri(string type)
        {
            this.type = type;
            InitializeComponent();
        }
        private string type;
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void musteri_Load(object sender, EventArgs e)
        {
            DataSet ds = this.type == "musteri" ? BLogic.musteriGetir("") : BLogic.FilmGetir("");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;   
        }

        private void sec_Click(object sender, EventArgs e)
        {
            Musteriid = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
            DialogResult = DialogResult.OK;
        }
    }
}
