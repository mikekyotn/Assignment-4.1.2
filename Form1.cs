namespace Assignment_4._1._2
{
    public partial class Form1 : Form
    {
        double currentTotal = 0;
        string lastOperator = "=";

        public Form1()
        {
            InitializeComponent();
        }

        MyMath myMath = new();
        
        private void number_Click(object sender, EventArgs e)
        {
            if (txtBoxWindow.Text == "0")
            {
                txtBoxWindow.Text = (sender as Button).Text;                
            }
            else
            {
                txtBoxWindow.Text = txtBoxWindow.Text + (sender as Button).Text;
            }
        }

        private void operation_Click(object sender, EventArgs e)
        {
            string currentOperator = (sender as Button).Text;
            
            if (currentOperator == "C")
            {
                currentTotal = 0;
                txtBoxWindow.Text = "0";
                lastOperator = "=";
            }
            else
            {
                //currentTotal = Double.Parse(txtBoxWindow.Text);
                switch (lastOperator)
                {
                    case "+":
                        currentTotal = myMath.Add(currentTotal, Double.Parse(txtBoxWindow.Text));
                        break;
                    case "-":
                        currentTotal = myMath.Subtract(currentTotal, Double.Parse(txtBoxWindow.Text));
                        break;
                    case "*":
                        currentTotal = myMath.Multiply(currentTotal, Double.Parse(txtBoxWindow.Text));
                        break;
                    case "/":
                        currentTotal = myMath.Divide(currentTotal, Double.Parse(txtBoxWindow.Text));
                        break;
                    default: //=
                        currentTotal = Double.Parse(txtBoxWindow.Text);
                        break;
                }
            }
            
            lastOperator = currentOperator;
            if (currentOperator == "=")
            {
                txtBoxWindow.Text = currentTotal.ToString();
            }
            else
            {
                txtBoxWindow.Text = "0";
            }



        }

    }
}
