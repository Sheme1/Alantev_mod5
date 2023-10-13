using System;
using System.Windows.Forms;

namespace Zadanie5
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operation_pressed))
                textBox1.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            operation_pressed = true;
        }

        private void button_Equals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_pressed = false;
        }
    }
}
