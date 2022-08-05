using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goods2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tovaryDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tovaryDataSet.Наименованиятовара". При необходимости она может быть перемещена или удалена.
            this.наименованиятовараTableAdapter.Fill(this.tovaryDataSet.Наименованиятовара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tovaryDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.tovaryDataSet.Заказы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.RemoveCurrent();
        }
            
        private void button7_Click(object sender, EventArgs e)
        {

                this.Validate();
                this.заказыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tovaryDataSet);
                MessageBox.Show("Successful");
        }

        private void номервариантаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void номервариантаTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void датазаказаDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void номервариантаNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
