namespace AcunMedyaAkademi11MayisFormOdevi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            cmbBrans = new ComboBox();
            cmbDoktro = new ComboBox();
            button1 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            comboBox1 = new ComboBox();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 19);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Acunmedya Hospital";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(221, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 125);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 74);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 2;
            label2.Text = "Randevu Alma Ekranı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 154);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 2;
            label3.Text = "Ad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 219);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 2;
            label4.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 281);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 2;
            label5.Text = "Branş:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 332);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 3;
            label6.Text = "Doktor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 384);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 4;
            label7.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(237, 382);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(299, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(237, 154);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(299, 27);
            txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(237, 216);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(299, 27);
            txtSoyad.TabIndex = 8;
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(237, 281);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(299, 28);
            cmbBrans.TabIndex = 9;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // cmbDoktro
            // 
            cmbDoktro.FormattingEnabled = true;
            cmbDoktro.Location = new Point(237, 332);
            cmbDoktro.Name = "cmbDoktro";
            cmbDoktro.Size = new Size(299, 28);
            cmbDoktro.TabIndex = 10;
            cmbDoktro.SelectedIndexChanged += cmbDoktro_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(315, 498);
            button1.Name = "button1";
            button1.Size = new Size(173, 62);
            button1.TabIndex = 11;
            button1.Text = "Randevu Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00" });
            comboBox1.Location = new Point(237, 428);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(299, 28);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(190, 436);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 13;
            label8.Text = "Saat:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 639);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(cmbDoktro);
            Controls.Add(cmbBrans);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private ComboBox cmbBrans;
        private ComboBox cmbDoktro;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBox1;
        private Label label8;
    }
}
