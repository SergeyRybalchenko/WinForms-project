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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gistogramma frm = new Gistogramma();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Avtomobili frm = new Avtomobili();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AvtoVidi frm = new AvtoVidi();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VidiGruzov frm = new VidiGruzov();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Gruzi frm = new Gruzi();
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Dolznosti frm = new Dolznosti();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Marki frm = new Marki();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reysi frm = new Reysi();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sotrudniki frm = new Sotrudniki();
            frm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Avtopark frm = new Avtopark();
            frm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Zakazi frm = new Zakazi();
            frm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Otdelkadrov frm = new Otdelkadrov();
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PerevozimieGruzi frm = new PerevozimieGruzi();
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Transportirovka frm = new Transportirovka();
            frm.Show();
        }
    }
}
