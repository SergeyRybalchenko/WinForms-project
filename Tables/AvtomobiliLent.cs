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
    public partial class AvtomobiliLent : Form
    {
        public AvtomobiliLent()
        {
            InitializeComponent();
        }

        private void автомобилиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автомобилиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportDataSet);

        }

        private void AvtomobiliLent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.transportDataSet.Автомобили);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            автомобилиBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            автомобилиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            автомобилиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            автомобилиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            автомобилиBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            автомобилиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate(); this.автомобилиBindingSource.EndEdit();
                this.автомобилиTableAdapter.Update(this.transportDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
