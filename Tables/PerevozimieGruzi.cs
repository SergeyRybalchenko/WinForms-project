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
    public partial class PerevozimieGruzi : Form
    {
        public PerevozimieGruzi()
        {
            InitializeComponent();
        }

        private void PerevozimieGruzi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Перевозимые_грузы". При необходимости она может быть перемещена или удалена.
            this.перевозимые_грузыTableAdapter.Fill(this.transportDataSet.Перевозимые_грузы);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            перевозимые_грузыBindingSource.Filter = "[Наименование вида груза] ='" + comboBox1.Text + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            перевозимые_грузыBindingSource.Filter = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
