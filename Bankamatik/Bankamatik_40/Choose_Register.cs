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
    public partial class Choose_Register : Form
    {
        public Choose_Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Company c=new Register_Company();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Indiviual r = new Register_Indiviual();
            r.Show();
        }
    }
}
