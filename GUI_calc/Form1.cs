namespace GUI_calc
{
    public partial class Form1 : Form
    {
        float firstNumber = 0;
        float secondNumber = 0;
        string sign = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void writeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                MessageBox.Show("Write only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && (writeNumber.Text.Contains(',')))
            {
                MessageBox.Show("There can be only 1 decimal point.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }


        }

        private void numberOne_Click(object sender, EventArgs e)
        {
            writeNumber.AppendText(numberOne.Text);
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
            writeNumber.AppendText(numberTwo.Text);
        }

        private void numberThree_Click(object sender, EventArgs e)
        {
            writeNumber.AppendText(numberThree.Text);
        }

        private void numberFour_Click(object sender, EventArgs e)
        {
            writeNumber.AppendText(numberFour.Text);
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            writeNumber.AppendText(numberFive.Text);
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            writeNumber.AppendText(numberSix.Text);
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            writeNumber.AppendText(numberSeven.Text);
        }

        private void numberEight_Click(object sender, EventArgs e)
        {
            writeNumber.AppendText(numberEight.Text);
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
            writeNumber.AppendText(numberNine.Text);
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            writeNumber.AppendText(numberZero.Text);
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            writeNumber.AppendText(pointButton.Text);
        }

        private void clearOneNumber_Click(object sender, EventArgs e)
        {
            string s = writeNumber.Text;
            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }
            writeNumber.Text = s;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            writeNumber.Clear();
        }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            if (writeNumber.Text.Contains('-') == true)
            {
                writeNumber.Text = writeNumber.Text.Replace("-", "");
            }
            else
            {
                writeNumber.Text = writeNumber.Text.Insert(0, "-");
            }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            double result = 0;
            secondNumber = convertAndClear();
            switch (sign)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    writeNumber.Text = result.ToString();
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    writeNumber.Text = result.ToString();
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    writeNumber.Text = result.ToString();
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    writeNumber.Text = result.ToString();
                    break;
                default:
                    MessageBox.Show("You didnt choose action.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            sign = plusButton.Text;
            firstNumber = convertAndClear();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            sign = minusButton.Text;
            firstNumber = convertAndClear();
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            sign = timesButton.Text;
            firstNumber = convertAndClear();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            sign = divideButton.Text;
            firstNumber = convertAndClear();
        }

        private float convertAndClear()
        {
            float number = 0;
            if (string.IsNullOrEmpty(writeNumber.Text))
            {
                writeNumber.Text = writeNumber.Text.Insert(0, "0");
                number = float.Parse(writeNumber.Text);
                writeNumber.Clear();
                return number;
            }
            else
            {
                number = float.Parse(writeNumber.Text);
                writeNumber.Clear();
                return number;
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            writeNumber.Clear();
            firstNumber = 0;
            secondNumber = 0;
            sign = null;
        }
    }
}