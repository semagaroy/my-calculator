using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_calculator
{
    public partial class Form1 : Form
    {
        private Action<object, EventArgs> EventArgs;

        public object ToolStripMenuItemForm1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void eXitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            c = a / b;

            label1.Text = c.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "Result";
        

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Developed by Roy Semaganda @2017");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
