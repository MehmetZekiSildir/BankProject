
using Bankamatik_40.ORM.Context;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProjeContext db;
        private void Form1_Load(object sender, EventArgs e)
        {

            db = new ProjeContext();
            db.Companies.ToList();
          

        }

        private void grp_main_Enter(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choose_Login secim = new Choose_Login();
            secim.Show();
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choose_Register secim = new Choose_Register();
            secim.Show();
        }
    }
}
