namespace Assignment_4._1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyMath myMath = new();
        double currentTotal = 0;
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
            string mathOperator = (sender as Button).Text;
            if (mathOperator == "C")
            {
                currentTotal = 0;
                txtBoxWindow.Text = "0";
            }
            else
            {
                currentTotal = Double.Parse(txtBoxWindow.Text);
                switch (mathOperator)
                {
                    case "+":
                        currentTotal = myMath.Add(currentTotal, Double.Parse(txtBoxWindow.Text));
                        txtBoxWindow.Text = currentTotal.ToString();
                        break;
                    default:
                        break;
                }
            }


        }

    }
}
