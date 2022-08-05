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
    public partial class VAlent : Form
    {
        public VAlent()
        {
            InitializeComponent();
        }

        private void виды_автомобилейBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.виды_автомобилейBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportDataSet);

        }

        private void VAlent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Виды_автомобилей". При необходимости она может быть перемещена или удалена.
            this.виды_автомобилейTableAdapter.Fill(this.transportDataSet.Виды_автомобилей);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            виды_автомобилейBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            виды_автомобилейBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            виды_автомобилейBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            виды_автомобилейBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            виды_автомобилейBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            виды_автомобилейBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate(); this.виды_автомобилейBindingSource.EndEdit();
                this.виды_автомобилейTableAdapter.Update(this.transportDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
