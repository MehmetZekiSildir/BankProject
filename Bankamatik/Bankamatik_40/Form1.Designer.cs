namespace Bankamatik_40
{
    partial class Form1
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
            this.grp_main = new System.Windows.Forms.GroupBox();
            this.btn_kayıt = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.grp_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_main
            // 
            this.grp_main.Controls.Add(this.btn_kayıt);
            this.grp_main.Controls.Add(this.btn_giris);
            this.grp_main.Location = new System.Drawing.Point(12, 12);
            this.grp_main.Name = "grp_main";
            this.grp_main.Size = new System.Drawing.Size(605, 284);
            this.grp_main.TabIndex = 0;
            this.grp_main.TabStop = false;
            this.grp_main.Text = "groupBox1";
            this.grp_main.Enter += new System.EventHandler(this.grp_main_Enter);
            // 
            // btn_kayıt
            // 
            this.btn_kayıt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kayıt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıt.Location = new System.Drawing.Point(343, 99);
            this.btn_kayıt.Name = "btn_kayıt";
            this.btn_kayıt.Size = new System.Drawing.Size(210, 104);
            this.btn_kayıt.TabIndex = 0;
            this.btn_kayıt.Text = "KAYIT OL";
            this.btn_kayıt.UseVisualStyleBackColor = false;
            this.btn_kayıt.Click += new System.EventHandler(this.btn_kayıt_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_giris.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(61, 99);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(210, 104);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 308);
            this.Controls.Add(this.grp_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_main;
        private System.Windows.Forms.Button btn_kayıt;
        private System.Windows.Forms.Button btn_giris;
    }
}

