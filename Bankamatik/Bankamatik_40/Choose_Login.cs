using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankamatik_40
{
    public partial class Choose_Login : Form
    {
        public Choose_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Indiviual_Login m = new Indiviual_Login();
            m.Show();
        }

        private void btn_kurumsal_rgr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Company_Login c = new Company_Login();
            c.Show();
        }
    }
}
