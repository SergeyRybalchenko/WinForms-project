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
    public partial class Marki : Form
    {
        public Marki()
        {
            InitializeComponent();
        }

        private void марки_автомобилейBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.марки_автомобилейBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportDataSet);

        }

        private void Marki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Марки_автомобилей". При необходимости она может быть перемещена или удалена.
            this.марки_автомобилейTableAdapter.Fill(this.transportDataSet.Марки_автомобилей);

        }
    }
}
