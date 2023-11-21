using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formulario1 = new Form1();
            this.Hide();
            formulario1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 formulario6 = new Form6();
            this.Hide();
            formulario6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 formulario1 = new Form1();
            this.Hide();
            formulario1.Show();
        }
    }
}
