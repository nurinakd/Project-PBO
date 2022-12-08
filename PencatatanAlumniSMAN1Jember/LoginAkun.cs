using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PencatatanAlumniSMAN1Jember
{
    public partial class LoginAkun : Form
    {
        public LoginAkun()
        {
            InitializeComponent();
        }

        public LoginSiswa LoginSiswa
        {
            get => default;
            set
            {
            }
        }

        public LoginAdmin LoginAdmin
        {
            get => default;
            set
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginAdmin().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginSiswa().ShowDialog();
        }
    }
}
