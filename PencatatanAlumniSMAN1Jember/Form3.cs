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
    public partial class Form3 : Form
    {
        Form1 fgrid;
        public Form3(Form1 fgrid)
        {
            InitializeComponent();
            this.fgrid = fgrid;
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G59G0LKE\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bersih()
        {
            txtId2.Clear();
            txtNama2.Clear();
            txtNo2.Clear();
            txtJalur2.Clear();
            txtSkor2.Clear();
            txtPerguruan2.Clear();
            txtJurusan2.Clear();
            txtNama2.Focus();
        }

        private void btnSegarkan_Click(object sender, EventArgs e)
        {
            bersih();
        }

        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec dbo.Alumni_Lihat", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fgrid.dgvAlumni.DataSource = dt;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.Alumni_Edit '" + int.Parse(txtId2.Text) + "','" + txtNama2.Text + "', '" + txtNo2.Text + "','" + txtJalur2.Text + "','" + txtSkor2.Text + "','" + txtPerguruan2.Text + "','" + txtJurusan2.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil diubah!");
            LoadAllRecords();

            bersih();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
