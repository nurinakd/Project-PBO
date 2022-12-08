using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace PencatatanAlumniSMAN1Jember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G59G0LKE\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
            dgvAlumni.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAlumni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec dbo.Alumni_Lihat", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAlumni.DataSource = dt;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.Alumni_Hapus '" + int.Parse(txtCari.Text) + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil dihapus!");
            LoadAllRecords();
        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            Form2 finfo = new Form2(this);
            finfo.Show();
        }

        private void dgvAlumni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3(this);
            myForm.txtId2.Text = dgvAlumni.CurrentRow.Cells[0].Value.ToString();
            myForm.txtNama2.Text = dgvAlumni.CurrentRow.Cells[1].Value.ToString();
            myForm.txtNo2.Text = dgvAlumni.CurrentRow.Cells[2].Value.ToString();
            myForm.txtJalur2.Text = dgvAlumni.CurrentRow.Cells[3].Value.ToString();
            myForm.txtSkor2.Text = dgvAlumni.CurrentRow.Cells[4].Value.ToString();
            myForm.txtPerguruan2.Text = dgvAlumni.CurrentRow.Cells[5].Value.ToString();
            myForm.txtJurusan2.Text = dgvAlumni.CurrentRow.Cells[6].Value.ToString();

            myForm.ShowDialog();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("exec dbo.Alumni_Cari'"+int.Parse(txtCari.Text)+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAlumni.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
