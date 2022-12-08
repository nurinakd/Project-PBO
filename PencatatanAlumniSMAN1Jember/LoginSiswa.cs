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

namespace PencatatanAlumniSMAN1Jember
{
    public partial class LoginSiswa : Form
    {
        public LoginSiswa()
        {
            InitializeComponent();
        }

        public HalSiswa HalSiswa
        {
            get => default;
            set
            {
            }
        }

        internal Properties.Resources Resources
        {
            get => default;
            set
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-G59G0LKE\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Data_Siswa where Username = '"+textBox1.Text+"' and Password = '"+textBox2.Text+"'", koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                HalSiswa panggil = new HalSiswa();
                panggil.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password anda salah \nSilahkan masukkan kembali Username dan Password anda");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
