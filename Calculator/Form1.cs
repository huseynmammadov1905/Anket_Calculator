using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form2_Calculator : Form
    {

        string check = "";
        double Number1;
        double Number2;
        public Form2_Calculator()
        {
            InitializeComponent();
        }
        public void FooNumber1(string arr)
        {
            Number1 = Convert.ToDouble(arr);
            textBox2.Text = arr;
            textBox1.Clear();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (check == "")
            {
                check = "+";
                FooNumber1(textBox1.Text);
                textBox2.Text += "+";

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (check == "")
            {
                check = "-";
                FooNumber1(textBox1.Text);
                textBox2.Text += "-";
            }
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            if (check == "")
            {
                check = "*";
                FooNumber1(textBox1.Text);
                textBox2.Text += "*";
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (check == "")
            {
                check = "/";
                FooNumber1(textBox1.Text);
                textBox2.Text += "/";
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Regex regex = new("^[0-9]{0,10},[+\\-\\*\\/]{1},[0-9]{0,10}$");

            //if (!regex.IsMatch(textBox1.Text))
            //{
            //lbl_info.Text = "Yalnish hesablama emeliyyati";
            //MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //this.Controls.Clear();
            //this.InitializeComponent();
            //}
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {

            Number2 = Convert.ToDouble(textBox1.Text);
            textBox2.Text += Number2;
            double result= 0;
            
            switch (check)
            {
                case "+":
                    result = (Number1 + Number2);
                    textBox1.Text = result.ToString();
                    Number1 = result;
                    break;
                case "-":
                    result = (Number1 - Number2);
                    textBox1.Text = result.ToString();
                    Number1 = result;
                    break;
                case "*":
                    result = (Number1 * Number2);
                    textBox1.Text = result.ToString();
                    Number1 = result;
                    break;
                case "/":
                    if (Number2 == 0)
                    {
                        MessageBox.Show("0-a bolmek olmaz", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    result = (Number1 / Number2);
                    textBox1.Text = result.ToString();
                    Number1 = result;
                    break;
                default:
                    break;
            }
            check = "";
            Number1 = result;

        }
    }
        
    
}