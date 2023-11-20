using System;
using System.Linq.Expressions;
using System.Windows.Forms;

using CalculatorPrivateAssembly;
namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
     
        public FrmBasicCalculator()
        {

            InitializeComponent();
            operations.Items.Add("+");
            operations.Items.Add("-");
            operations.Items.Add("*");
            operations.Items.Add("/");
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            

            string OperationSelected = operations.SelectedItem.ToString();
            float number1 = float.Parse(input1.Text);
            float number2 = float.Parse(input2.Text);

            float output = 0;
            switch (OperationSelected) {
                case "+":
                    output = BasicComputation.Add(number1, number2);
                    break;
                case "-":
                    output = BasicComputation.Subtract(number1, number2);
                    break;
                case "/":
                    output = BasicComputation.Divide(number1, number2);
                    break;
                case "*":
                    output = BasicComputation.Multiply(number1, number2);
                    break;
            }
            TotalOutput.Items.Add("Total:"
                + "\n" + output);

       
            
        }
    
        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {

        }

        private void operations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
