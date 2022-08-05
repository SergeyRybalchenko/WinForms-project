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
    public partial class Gruzi : Form
    {
        public Gruzi()
        {
            InitializeComponent();
        }

        private void грузыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.грузыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportDataSet);

        }

        private void Gruzi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Рейсы". При необходимости она может быть перемещена или удалена.
            this.рейсыTableAdapter.Fill(this.transportDataSet.Рейсы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.transportDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Грузы". При необходимости она может быть перемещена или удалена.
            this.грузыTableAdapter.Fill(this.transportDataSet.Грузы);

        }
    }
}
