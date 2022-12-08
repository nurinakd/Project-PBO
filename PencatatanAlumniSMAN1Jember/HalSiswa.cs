using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PencatatanAlumniSMAN1Jember
{
    public partial class HalSiswa : Form
    {
        public HalSiswa()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G59G0LKE\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");
        private void HalSiswa_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
            dgvAlumni2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAlumni2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec dbo.Alumni_Lihat", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAlumni2.DataSource = dt;
        }

        private void btnCari2_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("exec dbo.Alumni_Cari'" + int.Parse(txtCari2.Text) + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAlumni2.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
