using System;
using System.Windows.Forms;
using WindowsFormsApp3.OneArgumentOperation;
using WindowsFormsApp3.TwoArgumentOperation;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void OpertionForTwoArgument(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(this.firstArgument.Text);
                double secondArgument = Convert.ToDouble(this.secondArgument.Text);
                string operationName = ((Button) sender).Name;
                ITwoArgumentCalculator calculator = TwoArgumentCalculatorFactory.createCalculator(operationName);
                double res = calculator.Calculate(firstArgument, secondArgument);
                result.Text = Convert.ToString(res);
            }
            catch (Exception exc)
            {
                result.Text = exc.Message;
            }
        }
        private void OpertionForOneArgument(object sender, EventArgs e)
        {
            try
            {
                double argument = Convert.ToDouble(firstArgument.Text);
                string operationName = ((Button) sender).Name;
                IOneArgumentCalculator calculator = OneArgumentCalculatorFactory.createCalculator(operationName);
                double res = calculator.Calculate(argument);
                result.Text = Convert.ToString(res);
            }
            catch (Exception exc)
            {
                result.Text = exc.Message;
            }
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void geometric_Click(object sender, EventArgs e)
        {

        }

        private void naturalLogarithm_Click(object sender, EventArgs e)
        {

        }
    }
}
