namespace Bankamatik_40
{
    partial class Register_Company
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_musteriNo_bkayıt = new System.Windows.Forms.MaskedTextBox();
            this.txt_sifre_bkayıt = new System.Windows.Forms.MaskedTextBox();
            this.txt_name_bkayıt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.mtb_kcustomerno = new System.Windows.Forms.MaskedTextBox();
            this.mtb_kpassword = new System.Windows.Forms.MaskedTextBox();
            this.txt_kname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_section = new System.Windows.Forms.TextBox();
            this.btn_ana_kurumsal = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt_musteriNo_bkayıt);
            this.groupBox2.Controls.Add(this.txt_sifre_bkayıt);
            this.groupBox2.Controls.Add(this.txt_name_bkayıt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 351);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KURUMSAL KAYIT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(11, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(525, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "KAYIT OL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txt_musteriNo_bkayıt
            // 
            this.txt_musteriNo_bkayıt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteriNo_bkayıt.Location = new System.Drawing.Point(167, 80);
            this.txt_musteriNo_bkayıt.Mask = "000-00-0000";
            this.txt_musteriNo_bkayıt.Name = "txt_musteriNo_bkayıt";
            this.txt_musteriNo_bkayıt.Size = new System.Drawing.Size(207, 26);
            this.txt_musteriNo_bkayıt.TabIndex = 4;
            // 
            // txt_sifre_bkayıt
            // 
            this.txt_sifre_bkayıt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre_bkayıt.Location = new System.Drawing.Point(168, 161);
            this.txt_sifre_bkayıt.Mask = "00000";
            this.txt_sifre_bkayıt.Name = "txt_sifre_bkayıt";
            this.txt_sifre_bkayıt.Size = new System.Drawing.Size(207, 26);
            this.txt_sifre_bkayıt.TabIndex = 3;
            this.txt_sifre_bkayıt.ValidatingType = typeof(int);
            // 
            // txt_name_bkayıt
            // 
            this.txt_name_bkayıt.AllowDrop = true;
            this.txt_name_bkayıt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_name_bkayıt.Location = new System.Drawing.Point(167, 48);
            this.txt_name_bkayıt.Name = "txt_name_bkayıt";
            this.txt_name_bkayıt.Size = new System.Drawing.Size(369, 26);
            this.txt_name_bkayıt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Müşteri No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Şifre:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(104, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 31);
            this.label14.TabIndex = 0;
            this.label14.Text = "Ad:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 39);
            this.comboBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.btn_ana_kurumsal);
            this.groupBox1.Controls.Add(this.txt_section);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.mtb_kcustomerno);
            this.groupBox1.Controls.Add(this.mtb_kpassword);
            this.groupBox1.Controls.Add(this.txt_kname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 351);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KURUMSAL KAYIT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(0, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(525, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "KAYIT OL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mtb_kcustomerno
            // 
            this.mtb_kcustomerno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtb_kcustomerno.Location = new System.Drawing.Point(167, 80);
            this.mtb_kcustomerno.Mask = "000-00-0000";
            this.mtb_kcustomerno.Name = "mtb_kcustomerno";
            this.mtb_kcustomerno.Size = new System.Drawing.Size(207, 26);
            this.mtb_kcustomerno.TabIndex = 4;
            // 
            // mtb_kpassword
            // 
            this.mtb_kpassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtb_kpassword.Location = new System.Drawing.Point(168, 161);
            this.mtb_kpassword.Mask = "00000";
            this.mtb_kpassword.Name = "mtb_kpassword";
            this.mtb_kpassword.Size = new System.Drawing.Size(207, 26);
            this.mtb_kpassword.TabIndex = 3;
            this.mtb_kpassword.ValidatingType = typeof(int);
            // 
            // txt_kname
            // 
            this.txt_kname.AllowDrop = true;
            this.txt_kname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kname.Location = new System.Drawing.Point(167, 48);
            this.txt_kname.Name = "txt_kname";
            this.txt_kname.Size = new System.Drawing.Size(207, 26);
            this.txt_kname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sektör:";
            // 
            // txt_section
            // 
            this.txt_section.AllowDrop = true;
            this.txt_section.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_section.Location = new System.Drawing.Point(167, 121);
            this.txt_section.Name = "txt_section";
            this.txt_section.Size = new System.Drawing.Size(207, 26);
            this.txt_section.TabIndex = 6;
            // 
            // btn_ana_kurumsal
            // 
            this.btn_ana_kurumsal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ana_kurumsal.Location = new System.Drawing.Point(579, 263);
            this.btn_ana_kurumsal.Name = "btn_ana_kurumsal";
            this.btn_ana_kurumsal.Size = new System.Drawing.Size(119, 78);
            this.btn_ana_kurumsal.TabIndex = 7;
            this.btn_ana_kurumsal.Text = "Ana Menü";
            this.btn_ana_kurumsal.UseVisualStyleBackColor = false;
            this.btn_ana_kurumsal.Click += new System.EventHandler(this.btn_ana_kurumsal_Click);
            // 
            // Register_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Register_Company";
            this.Text = "Register_Company";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txt_musteriNo_bkayıt;
        private System.Windows.Forms.MaskedTextBox txt_sifre_bkayıt;
        private System.Windows.Forms.TextBox txt_name_bkayıt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mtb_kcustomerno;
        private System.Windows.Forms.MaskedTextBox mtb_kpassword;
        private System.Windows.Forms.TextBox txt_kname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_section;
        private System.Windows.Forms.Button btn_ana_kurumsal;
    }
}