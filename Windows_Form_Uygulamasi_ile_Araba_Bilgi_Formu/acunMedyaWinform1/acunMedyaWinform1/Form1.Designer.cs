namespace acunMedyaWinform1
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
            txtMarka = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtModel = new TextBox();
            txtKapi = new TextBox();
            txtPencere = new TextBox();
            txtYakit = new TextBox();
            txtRenk = new TextBox();
            btnShow = new Button();
            SuspendLayout();
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(387, 23);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(100, 23);
            txtMarka.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Marka:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 77);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 128);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Renk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 183);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 4;
            label4.Text = "Kapı Sayısı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 227);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 5;
            label5.Text = "Pencere Sayısı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(291, 269);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 6;
            label6.Text = "100Km de Yakıt";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(387, 74);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 7;
            // 
            // txtKapi
            // 
            txtKapi.Location = new Point(387, 175);
            txtKapi.Name = "txtKapi";
            txtKapi.Size = new Size(100, 23);
            txtKapi.TabIndex = 8;
            // 
            // txtPencere
            // 
            txtPencere.Location = new Point(387, 224);
            txtPencere.Name = "txtPencere";
            txtPencere.Size = new Size(100, 23);
            txtPencere.TabIndex = 9;
            // 
            // txtYakit
            // 
            txtYakit.Location = new Point(387, 269);
            txtYakit.Name = "txtYakit";
            txtYakit.Size = new Size(100, 23);
            txtYakit.TabIndex = 11;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(387, 125);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(100, 23);
            txtRenk.TabIndex = 12;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(356, 362);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(144, 25);
            btnShow.TabIndex = 13;
            btnShow.Text = "Bilgileri Göster";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShow);
            Controls.Add(txtRenk);
            Controls.Add(txtYakit);
            Controls.Add(txtPencere);
            Controls.Add(txtKapi);
            Controls.Add(txtModel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMarka);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarka;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtModel;
        private TextBox txtKapi;
        private TextBox txtPencere;
        private TextBox txtYakit;
        private TextBox txtRenk;
        private Button btnShow;
    }
}
