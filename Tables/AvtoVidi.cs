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
    public partial class AvtoVidi : Form
    {
        public AvtoVidi()
        {
            InitializeComponent();
        }

        private void виды_автомобилейBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.виды_автомобилейBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportDataSet);

        }

        private void AvtoVidi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Виды_автомобилей". При необходимости она может быть перемещена или удалена.
            this.виды_автомобилейTableAdapter.Fill(this.transportDataSet.Виды_автомобилей);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VAlent frm = new VAlent();
            frm.Show();
        }
    }
}
