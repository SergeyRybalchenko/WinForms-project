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
    public partial class Zakazi : Form
    {
        public Zakazi()
        {
            InitializeComponent();
        }

        private void Zakazi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.transportDataSet.Заказы);

        }

        private void заказыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "[ЗАКАЗЧИК] ='" + comboBox2.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "[ОТМЕТКА_ОБ_ОПЛАТЕ] ='" + comboBox3.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "[ДАТА_ПРИБЫТИЯ] ='" + comboBox4.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "[НАИМЕНОВАНИЕ] ='" + comboBox1.Text + "'";
        }
    }
}
