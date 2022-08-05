using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LiveCharts;
using LiveCharts.Wpf;

namespace Goods2
{
    public partial class Gistogramma : Form
    {
        private SqlConnection SqlConnection = null;
        private SqlDataAdapter dataAdapter = null;
        private DataSet dataSet = null;
        private DataTable table = null;

        public Gistogramma()
        {
            InitializeComponent();
        }

        private void Gistogramma_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.отдел_кадровTableAdapter.Fill(this.transportDataSet.Отдел_кадров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "transportDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.transportDataSet.Должности);


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
