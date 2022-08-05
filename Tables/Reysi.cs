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
    public partial class Reysi : Form
    {
        public Reysi()
        {
            InitializeComponent();
        }

        private void рейсыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рейсыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportDataSet);

        }

        private void Reysi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Рейсы". При необходимости она может быть перемещена или удалена.
            this.рейсыTableAdapter.Fill(this.transportDataSet.Рейсы);

        }

        private void рейсыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
