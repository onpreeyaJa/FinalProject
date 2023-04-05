using FinalProject.Class;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Home : Form
    {
        List<Order> orders = new List<Order>();
        public Home()
        {
            InitializeComponent();
        }

        private void addBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd Addform = new FormAdd();
            Addform.ShowDialog();
            if (Addform.DialogResult == DialogResult.OK)
            {
                orders.Add(Addform.getOrder());
                Refresh();
            }
        }
        public void Refresh()
        {
            dataGridView1.Rows.Clear();
            foreach (Order item in orders)
            {
                dataGridView1.Rows.Add(item.PersonName, item.PersonPhone, item.NotebookBrand, item.NotebookBrand, item.Date_in, item.Date_out, item.Price);
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "";
            saveFile.Filter = "CSV|*.csv";
            saveFile.ShowDialog();

            if (saveFile.Filter != "")
            {
                using (StreamWriter file = new StreamWriter(saveFile.FileName))
                {
                    foreach (Order item in orders)
                    {
                        file.WriteLine($"{item.PersonName},{item.PersonPhone},{item.NotebookBrand},{item.NotebookBrand},{item.Date_in},{item.Date_out},{item.Price}");
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "CSV files(*.csv)|*.csv|All files(*.*)|*.*";
            OpenFileDialog.ShowDialog();
            if (OpenFileDialog.FileName != "")
            {
                dataGridView1.Rows.Clear();
                using (StreamReader file = new StreamReader(OpenFileDialog.FileName))
                {
                    string line;
                    int count = 0;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        orders.Add(new Order()
                        {
                            PersonName = data[0],
                            PersonPhone = data[1],
                            NotebookBrand = data[2],
                            NotebookModel = data[3],
                            Date_in = data[4],
                            Date_out = data[5],
                            Price = int.Parse(data[6])
                        });
                        Refresh();
                    }
                }
            }
        }

        private void finishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                orders.RemoveAt(dataGridView1.SelectedRows[0].Index);
                Refresh();
                MessageBox.Show("งานเสร็จเรียบร้อยแล้ว!");
            }
            catch
            {
                MessageBox.Show("กรุณาเลือกใหม่อีกครั้ง");
              
            }

        }
    }
}
