namespace FinalProject
{
    partial class Home
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
            dataGridView1 = new DataGridView();
            person_name = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            notebook_brand = new DataGridViewTextBoxColumn();
            notebook_model = new DataGridViewTextBoxColumn();
            date_in = new DataGridViewTextBoxColumn();
            date_out = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            billToolStripMenuItem = new ToolStripMenuItem();
            addBillToolStripMenuItem = new ToolStripMenuItem();
            finishToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { person_name, PhoneNumber, notebook_brand, notebook_model, date_in, date_out, price });
            dataGridView1.Location = new Point(12, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(940, 402);
            dataGridView1.TabIndex = 0;
            // 
            // person_name
            // 
            person_name.HeaderText = "ชื่อลูกค้า";
            person_name.MinimumWidth = 8;
            person_name.Name = "person_name";
            person_name.ReadOnly = true;
            person_name.Width = 150;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "เบอร์โทรศัพท์";
            PhoneNumber.MinimumWidth = 8;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 150;
            // 
            // notebook_brand
            // 
            notebook_brand.HeaderText = "แบรนด์โน๊ตบุ๊ค";
            notebook_brand.MinimumWidth = 8;
            notebook_brand.Name = "notebook_brand";
            notebook_brand.ReadOnly = true;
            notebook_brand.Width = 150;
            // 
            // notebook_model
            // 
            notebook_model.HeaderText = "โมเดลโน๊ตบุ๊ค";
            notebook_model.MinimumWidth = 8;
            notebook_model.Name = "notebook_model";
            notebook_model.ReadOnly = true;
            notebook_model.Width = 150;
            // 
            // date_in
            // 
            date_in.HeaderText = "วันที่เข้ารับการซ่อม";
            date_in.MinimumWidth = 8;
            date_in.Name = "date_in";
            date_in.ReadOnly = true;
            date_in.Width = 150;
            // 
            // date_out
            // 
            date_out.HeaderText = "วันที่คาดว่าจะแล้วเสร็จ";
            date_out.MinimumWidth = 8;
            date_out.Name = "date_out";
            date_out.ReadOnly = true;
            date_out.Width = 150;
            // 
            // price
            // 
            price.HeaderText = "ราคาประเมิน";
            price.MinimumWidth = 8;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 150;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, billToolStripMenuItem, finishToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(998, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(158, 34);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(158, 34);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // billToolStripMenuItem
            // 
            billToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBillToolStripMenuItem });
            billToolStripMenuItem.Name = "billToolStripMenuItem";
            billToolStripMenuItem.Size = new Size(50, 29);
            billToolStripMenuItem.Text = "Bill";
            // 
            // addBillToolStripMenuItem
            // 
            addBillToolStripMenuItem.Name = "addBillToolStripMenuItem";
            addBillToolStripMenuItem.Size = new Size(170, 34);
            addBillToolStripMenuItem.Text = "AddBill";
            addBillToolStripMenuItem.Click += addBillToolStripMenuItem_Click;
            // 
            // finishToolStripMenuItem
            // 
            finishToolStripMenuItem.Name = "finishToolStripMenuItem";
            finishToolStripMenuItem.Size = new Size(73, 29);
            finishToolStripMenuItem.Text = "Finish";
            finishToolStripMenuItem.Click += finishToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem billToolStripMenuItem;
        private ToolStripMenuItem addBillToolStripMenuItem;
        private DataGridViewTextBoxColumn person_name;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn notebook_brand;
        private DataGridViewTextBoxColumn notebook_model;
        private DataGridViewTextBoxColumn date_in;
        private DataGridViewTextBoxColumn date_out;
        private DataGridViewTextBoxColumn price;
        private ToolStripMenuItem finishToolStripMenuItem;
    }
}