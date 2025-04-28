namespace CustomAttributeOdevi
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
            btnValidate = new Button();
            txtOgrAd = new TextBox();
            txtOgrSoyad = new TextBox();
            txtOgrBolum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(392, 280);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(178, 99);
            btnValidate.TabIndex = 0;
            btnValidate.Text = "Giriş";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += button1_Click;
            // 
            // txtOgrAd
            // 
            txtOgrAd.Location = new Point(392, 91);
            txtOgrAd.Name = "txtOgrAd";
            txtOgrAd.Size = new Size(195, 27);
            txtOgrAd.TabIndex = 1;
            // 
            // txtOgrSoyad
            // 
            txtOgrSoyad.Location = new Point(392, 151);
            txtOgrSoyad.Name = "txtOgrSoyad";
            txtOgrSoyad.Size = new Size(195, 27);
            txtOgrSoyad.TabIndex = 1;
            // 
            // txtOgrBolum
            // 
            txtOgrBolum.Location = new Point(392, 202);
            txtOgrBolum.Name = "txtOgrBolum";
            txtOgrBolum.Size = new Size(195, 27);
            txtOgrBolum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 158);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 98);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 2;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 209);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Bölüm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 424);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 513);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOgrBolum);
            Controls.Add(txtOgrSoyad);
            Controls.Add(txtOgrAd);
            Controls.Add(btnValidate);
            Name = "Form1";
            Text = "é";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidate;
        private TextBox txtOgrAd;
        private TextBox txtOgrSoyad;
        private TextBox txtOgrBolum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
