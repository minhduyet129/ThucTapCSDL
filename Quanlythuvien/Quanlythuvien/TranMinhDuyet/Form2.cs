using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Quanlythuvien.Model;

namespace Quanlythuvien.TranMinhDuyet
{
    public partial class Form2 : Form
    {
        QuanlythuvienEntities db = new QuanlythuvienEntities();
        public Form2()
        {
            InitializeComponent();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CboxDocGia.DataSource = db.DOCGIAs.ToList();
            CboxDocGia.DisplayMember = "TenDG";
            CboxDocGia.ValueMember = "MaDG";

        }
        void LoadMuonTra()
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DOCGIA DG=db.DOCGIAs.SingleOrDefault(x=>x.MaDG==CboxDocGia.)
        }
    }
}
