using Bankamatik_40.ORM.Context;
using Bankamatik_40.ORM.Entities;
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
    public partial class Company_Login : Form
    {
        public Company_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string musterino = mtb_customerno_kgiris.Text;
            string sifre = txt_password_kgiriş.Text;

            ProjeContext db = new ProjeContext();
            Company b = db.Companies.Where(i => i.CustomerNO == musterino  && i.Password == sifre).FirstOrDefault();
            if (b != null)
            {
                MessageBox.Show("Giriş Başarılı");

            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
