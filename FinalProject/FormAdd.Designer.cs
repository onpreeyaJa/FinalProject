namespace FinalProject
{
    partial class FormAdd
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
            tbName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbLastName = new TextBox();
            label6 = new Label();
            tbTel = new TextBox();
            button1 = new Button();
            tbBrand = new TextBox();
            label4 = new Label();
            tbModel = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbPrice = new TextBox();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(169, 53);
            tbName.Name = "tbName";
            tbName.Size = new Size(150, 31);
            tbName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 59);
            label1.Name = "label1";
            label1.Size = new Size(33, 25);
            label1.TabIndex = 1;
            label1.Text = "ชื่อ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 96);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 3;
            label2.Text = "นามสกุล";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(169, 90);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(150, 31);
            tbLastName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 133);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 11;
            label6.Text = "เบอร์ติดต่อ";
            // 
            // tbTel
            // 
            tbTel.Location = new Point(169, 127);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(150, 31);
            tbTel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(249, 245);
            button1.Name = "button1";
            button1.Size = new Size(150, 37);
            button1.TabIndex = 8;
            button1.Text = "บันทึก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(169, 164);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(150, 31);
            tbBrand.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 170);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 14;
            label4.Text = "Brand";
            // 
            // tbModel
            // 
            tbModel.Location = new Point(461, 53);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(150, 31);
            tbModel.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(363, 59);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 16;
            label7.Text = "Model";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(363, 96);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 18;
            label8.Text = "วันที่เริ่มต้น";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(363, 133);
            label9.Name = "label9";
            label9.Size = new Size(83, 25);
            label9.TabIndex = 20;
            label9.Text = "วันที่สิ้นสุด";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(461, 164);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(150, 31);
            tbPrice.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(363, 170);
            label10.Name = "label10";
            label10.Size = new Size(46, 25);
            label10.TabIndex = 22;
            label10.Text = "ราคา";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(461, 91);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(461, 128);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(150, 31);
            dateTimePicker2.TabIndex = 6;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 342);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbPrice);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(tbModel);
            Controls.Add(label7);
            Controls.Add(tbBrand);
            Controls.Add(label4);
            Controls.Add(tbName);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(tbLastName);
            Controls.Add(tbTel);
            Controls.Add(label2);
            Name = "FormAdd";
            Text = "ข้อมูลลูกค้า";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private Label label1;
        private Label label2;
        private TextBox tbLastName;
        private Label label6;
        private TextBox tbTel;
        private Button button1;
        private TextBox tbBrand;
        private Label label4;
        private TextBox tbModel;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbPrice;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}