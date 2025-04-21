namespace paymentSystemWithRefelction
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
            cmbPaymentType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtAmount = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(472, 221);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(151, 28);
            cmbPaymentType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 229);
            label1.Name = "label1";
            label1.Size = new Size(205, 20);
            label1.TabIndex = 1;
            label1.Text = "Lütfen Ödeme Türünü Seçiniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 157);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 2;
            label2.Text = "Lütfen Tutarı Giriniz:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(472, 150);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(151, 27);
            txtAmount.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(417, 319);
            button1.Name = "button1";
            button1.Size = new Size(194, 81);
            button1.TabIndex = 4;
            button1.Text = "Öde";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 444);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 541);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbPaymentType);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPaymentType;
        private Label label1;
        private Label label2;
        private TextBox txtAmount;
        private Button button1;
        private Label label3;
    }
}
