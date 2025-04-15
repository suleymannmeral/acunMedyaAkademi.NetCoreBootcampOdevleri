namespace jsonOdeviAcunMedya
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
            label2 = new Label();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            btnJsonCreate = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 142);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 213);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Fiyat:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(281, 139);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(255, 27);
            txtProductName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(281, 210);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(255, 27);
            txtPrice.TabIndex = 3;
            // 
            // btnJsonCreate
            // 
            btnJsonCreate.Location = new Point(229, 377);
            btnJsonCreate.Name = "btnJsonCreate";
            btnJsonCreate.Size = new Size(148, 29);
            btnJsonCreate.TabIndex = 4;
            btnJsonCreate.Text = "Json'a Çevir";
            btnJsonCreate.UseVisualStyleBackColor = true;
            btnJsonCreate.Click += btnJsonCreate_Click;
            // 
            // button1
            // 
            button1.Location = new Point(407, 377);
            button1.Name = "button1";
            button1.Size = new Size(155, 30);
            button1.TabIndex = 5;
            button1.Text = "Json Veri Oku";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 551);
            Controls.Add(button1);
            Controls.Add(btnJsonCreate);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private Button btnJsonCreate;
        private Button button1;
    }
}
