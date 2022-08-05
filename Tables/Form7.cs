using System;
using System.Drawing;
using System.Windows.Forms;

namespace Goods2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "[Датазаказа] ='" + comboBox1.Text + "'";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tovaryDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.tovaryDataSet.Заказы);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(System.Object sender, System.EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col =
            default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = DataGridViewTextBoxColumn1;
                    break;
                case 1:
                    Col = DataGridViewTextBoxColumn2;
                    break;
                case 2:
                    Col = DataGridViewTextBoxColumn3;
                    break;
                case 3:
                    Col = DataGridViewTextBoxColumn4;
                    break;
                case 4:
                    Col = DataGridViewTextBoxColumn5;
                    break;
            }
            if (radioButton1.Checked)
            {
                dataGridView1.Sort(Col,
                System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                dataGridView1.Sort(Col,
                System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.White;
                    dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (j = 0; j < dataGridView1.RowCount; j++)
                {
                    var value = dataGridView1.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
                            
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
