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
    public partial class Avtopark : Form
    {
        public Avtopark()
        {
            InitializeComponent();
        }

        private void Avtopark_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Автопарк". При необходимости она может быть перемещена или удалена.
            this.автопаркTableAdapter.Fill(this.transportDataSet.Автопарк);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            автопаркBindingSource.Filter = "[НАИМЕНОВАНИЕ_ВИДА_АВТОМОБИЛЯ] ='" + comboBox1.Text + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            автопаркBindingSource.Filter = "";
        }
    }
}
