using FinalProject.Class;

namespace FinalProject
{
    public partial class FormAdd : Form
    {
        private Order order;
        public FormAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                order = new Order()
                {
                    PersonName = tbName.Text + "  " + tbLastName.Text,
                    PersonPhone = tbTel.Text,
                    NotebookBrand = tbBrand.Text,
                    Date_in = dateTimePicker1.Value.ToString(),
                    Date_out = dateTimePicker1.Value.ToString(),
                    Price = int.Parse(tbPrice.Text),
                };
            }
            catch
            {
                MessageBox.Show("คุณกรอกข้อมูลไม่ถูกต้อง");
            }
            this.DialogResult = DialogResult.OK;
        }
        public Order getOrder()
        {
            return order;
        }
    }
}