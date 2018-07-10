using System;
using System.Windows.Forms;

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
            double firstArgument = Convert.ToDouble(this.firstArgument.Text);
            double secondArgument = Convert.ToDouble(this.secondArgument.Text);
            string operationName = ((Button)sender).Name;
            ITwoArgumentCalculator calculator = TwoArgumentCalculatorFactory.createCalculator(operationName);
            double res = calculator.Calculate(firstArgument, secondArgument);
            result.Text = Convert.ToString(res);
        }
        private void OpertionForOneArgument(object sender, EventArgs e)
        {
            double argument = Convert.ToDouble(firstArgument.Text);
            string operationName = ((Button)sender).Name;
            IOneArgumentCalculator calculator = OneArgumentCalculatorFactory.createCalculator(operationName);
            double res = calculator.Calculate(argument);
            result.Text = Convert.ToString(res);
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
    }
}
