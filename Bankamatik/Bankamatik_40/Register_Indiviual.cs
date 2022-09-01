using Bankamatik_40.ORM.Context;
using Bankamatik_40.ORM.Entities;
using Bankamatik_40.ORM.Operetion;
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
    public partial class Register_Indiviual : Form
    {
        public Register_Indiviual()
        {
            InitializeComponent();
            db = new ProjeContext();
        }

        ProjeContext db;
        private void button1_Click(object sender, EventArgs e)
        {
            İndivual bcustomer = new İndivual();
            bcustomer.Name = txt_name_bkayıt.Text;
            bcustomer.Surname = txt_surname_bkayıt.Text;
            bcustomer.Age = Convert.ToInt32(txt_age_bkayıt.Text);
            bcustomer.TC = txt_tc_bkayıt.Text;

            if (rtr_erkek_bkayıt.Checked)
                bcustomer.Gender = rtr_erkek_bkayıt.Text;
            else
                bcustomer.Gender = rtr_kadın_bkayıt.Text;

            bcustomer.CustomerNO = mtb_customerno_bkayıt.Text;
            bcustomer.Password = mtb_password_bkayıt.Text;

            int sonuc=Execute.Bireysel_Insert(bcustomer);

            if (sonuc > 0)
            {
                txt_name_bkayıt.Text = "";
                txt_surname_bkayıt.Text = "";
                txt_age_bkayıt.Text = "";
                txt_tc_bkayıt.Text = "";
                rtr_erkek_bkayıt.Text = "";
                rtr_kadın_bkayıt.Text = "";
                mtb_customerno_bkayıt.Text = "";
                mtb_password_bkayıt.Text = "";
                MessageBox.Show("Kayıt Başarılı");

            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_ana_bireysel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
