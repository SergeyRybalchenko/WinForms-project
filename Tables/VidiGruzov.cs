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
    public partial class VidiGruzov : Form
    {
        public VidiGruzov()
        {
            InitializeComponent();
        }

        private void виды_грузовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.виды_грузовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportDataSet);

        }

        private void VidiGruzov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Виды_грузов". При необходимости она может быть перемещена или удалена.
            this.виды_грузовTableAdapter.Fill(this.transportDataSet.Виды_грузов);

        }
    }
}
