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
    public partial class SotrudnikiLent : Form
    {
        public SotrudnikiLent()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportDataSet);
        }

        private void SotrudnikiLent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.transportDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate(); this.сотрудникиBindingSource.EndEdit();
                this.сотрудникиTableAdapter.Update(this.transportDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
