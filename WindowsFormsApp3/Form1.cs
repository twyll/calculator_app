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
        private void buttonClick(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(this.firstArgument.Text);
            double secondArgument = Convert.ToDouble(this.secondArgument.Text);
            string operationName = ((Button)sender).Name;
            ICalculator calculator = CalculatorFactory.createCalculator(operationName);
            double res = calculator.Calculate(firstArgument, secondArgument);
            result.Text = Convert.ToString(res);
            result.Text = Convert.ToString(res);
            
        }
        public static double add(double a, double b)
        {
            return a + b;
        }
        public static double substr(double a, double b)
        {
            return a - b;
        }
        public static double multiply(double a, double b)
        {
            return a * b;
        }
        public static double div(double a, double b)
        {
            return a / b;
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
