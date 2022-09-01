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
    public partial class Register_Company : Form
    {
        public Register_Company()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Company kcustomer = new Company();
            kcustomer.Name=txt_kname.Text;
            kcustomer.CustomerNO = mtb_kcustomerno.Text;
            kcustomer.Section = txt_section.Text;
            kcustomer.Password = mtb_kpassword.Text;


            int sonuc=Execute.Kurumsal_Insert(kcustomer);

            if (sonuc > 0)
            {
                txt_kname.Text="";
                mtb_kcustomerno.Text = "";
                txt_section.Text = "";
                mtb_kpassword.Text = "";

                MessageBox.Show("Kayıt Başarılı");

            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_ana_kurumsal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();

        }
    }
}
