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
    public partial class Otdelkadrov : Form
    {
        public Otdelkadrov()
        {
            InitializeComponent();
        }

        private void Otdelkadrov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.отдел_кадровTableAdapter.Fill(this.transportDataSet.Отдел_кадров);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            отдел_кадровBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            отдел_кадровBindingSource.Filter = "[НАИМЕНОВАНИЕ_ДОЛЖНОСТИ] ='" + comboBox1.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gistogramma frm = new Gistogramma();
            frm.Show();
        }
    }
}
