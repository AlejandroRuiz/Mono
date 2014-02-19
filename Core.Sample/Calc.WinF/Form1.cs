using Calc.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc.WinF
{
    public partial class Form1 : Form
    {
        Calculadora c = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                c.Numero1 = Convert.ToDouble(textBox1.Text);
                c.Numero2 = Convert.ToDouble(textBox2.Text);
                label1.Text = c.Suma().ToString();
            }
            catch (Exception ex) { label1.Text = ex.Message; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                c.Numero1 = Convert.ToDouble(textBox1.Text);
                c.Numero2 = Convert.ToDouble(textBox2.Text);
                label1.Text = c.Resta().ToString();
            }
            catch (Exception ex) { label1.Text = ex.Message; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                c.Numero1 = Convert.ToDouble(textBox1.Text);
                c.Numero2 = Convert.ToDouble(textBox2.Text);
                label1.Text = c.Multiplicacion().ToString();
            }
            catch (Exception ex) { label1.Text = ex.Message; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                c.Numero1 = Convert.ToDouble(textBox1.Text);
                c.Numero2 = Convert.ToDouble(textBox2.Text);
                label1.Text = c.Division().ToString();
            }
            catch (Exception ex) { label1.Text = ex.Message; }
        }
    }
}
