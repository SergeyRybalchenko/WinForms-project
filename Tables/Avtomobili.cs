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
    public partial class Avtomobili : Form
    {
        public Avtomobili()
        {
            InitializeComponent();
        }

        private void автомобилиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автомобилиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportDataSet);

        }

        private void Avtomobili_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.transportDataSet.Автомобили);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvtomobiliLent frm = new AvtomobiliLent();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col =
            default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn7;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn9;
                    break;
            }

            if (radioButton1.Checked)
            {
                автомобилиDataGridView.Sort(Col,
                System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                автомобилиDataGridView.Sort(Col,
                System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            автомобилиBindingSource.Filter = "[НОМЕР_ДВИГАТЕЛЯ] ='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < автомобилиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < автомобилиDataGridView.RowCount; j++)
                {
                    автомобилиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    автомобилиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < автомобилиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < автомобилиDataGridView.RowCount; j++)
                {
                    var value = автомобилиDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            автомобилиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            автомобилиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;

                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            автомобилиBindingSource.Filter = "";
        }
    }
}
