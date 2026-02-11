using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number, cube;
            number = Convert.ToDouble(textBox1.Text);
            cube = number * number * number;

            MessageBox.Show("Cube of number: " + cube);
            label1.Text = Convert.ToString(cube);
        }
    }
}
