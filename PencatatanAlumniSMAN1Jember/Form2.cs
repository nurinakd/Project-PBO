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

namespace PencatatanAlumniSMAN1Jember
{
    public partial class Form2 : Form
    {
        Form1 fgrid; 
        public Form2(Form1 fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G59G0LKE\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void bersih()
        {
            txtId.Clear();
            txtNama.Clear();
            txtNo.Clear();
            txtJalur.Clear();
            txtSkor.Clear();
            txtPerguruan.Clear();
            txtJurusan.Clear();
            /*dgvAlumni.Clear();*/
            txtNama.Focus();
        }

        private void btnBatal_Click(object sender, EventArgs e)
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
        private void btnTambah_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.Alumni_Tambah '" + int.Parse(txtId.Text) + "','" + txtNama.Text + "', '" + txtNo.Text + "','" + txtJalur.Text + "','" + txtSkor.Text + "','" + txtPerguruan.Text + "','" + txtJurusan.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil ditambahkan!");
            LoadAllRecords();

            /*int count = fgrid.dgvAlumni.Rows.Count;
            fgrid.dgvAlumni.Rows.Add();
            fgrid.dgvAlumni.Rows[count].Cells[0].Value = txtId.Text;
            fgrid.dgvAlumni.Rows[count].Cells[1].Value = txtNama.Text;
            fgrid.dgvAlumni.Rows[count].Cells[2].Value = txtNo.Text;
            fgrid.dgvAlumni.Rows[count].Cells[3].Value = txtJalur.Text;
            fgrid.dgvAlumni.Rows[count].Cells[4].Value = txtSkor.Text;
            fgrid.dgvAlumni.Rows[count].Cells[5].Value = txtPerguruan.Text;
            fgrid.dgvAlumni.Rows[count].Cells[6].Value = txtJurusan.Text;*/

            bersih();
            this.Hide();

        }
    }
}
