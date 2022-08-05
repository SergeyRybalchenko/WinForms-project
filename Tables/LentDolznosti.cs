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
    public partial class LentDolznosti : Form
    {
        public LentDolznosti()
        {
            InitializeComponent();
        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transportDataSet);

        }

        private void LentDolznosti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.transportDataSet.Должности);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            должностиBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            должностиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            должностиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            должностиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            должностиBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            должностиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate(); this.должностиBindingSource.EndEdit();
                this.должностиTableAdapter.Update(this.transportDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
