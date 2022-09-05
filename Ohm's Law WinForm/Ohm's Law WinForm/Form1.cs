using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohm_s_Law_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Resistance_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Value1.Text);
            double y = Double.Parse(Value2.Text);
            Result.Text = (x / y).ToString();
        }

        private void Current_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(Value1.Text);
            double y = Double.Parse(Value2.Text);
            Result.Text = (x / y).ToString();
        }

        private void Voltage_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(Value1.Text);
            double y = Double.Parse(Value2.Text);
            Result.Text = (x * y).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Power_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(Value1.Text);
            double y = Double.Parse(Value2.Text);
            Result.Text = (x * y).ToString();
        }
    }
}
