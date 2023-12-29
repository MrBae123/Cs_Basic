namespace _2_HelloCsWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {
            int number1 = 1;
            int number2 = 2;

            int sum = number1 + number2;

            HelloLabel.Text = sum.ToString();
        }

        private void Number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;
            if (String.IsNullOrWhiteSpace(Sum1.Text))
            {
                MessageBox.Show("Sum1에 숫자를 입력해주세요.");
                Sum1.Focus();
                return;
            }

            if (int.TryParse(Sum1.Text, out number1) == false)
            {
                MessageBox.Show("문자가 아닌 숫자입력");
                Sum1.SelectAll();
                Sum1.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(Sum2.Text))
            {
                MessageBox.Show("Sum2에 숫자를 입력해주세요.");
                Sum2.Focus();
                return;
            }

            if (int.TryParse(Sum2.Text, out number2) == false)
            {
                MessageBox.Show("문자가 아닌 숫자입력");
                Sum2.SelectAll();
                Sum2.Focus();
                return;
            }

            // number1 = Convert.ToInt32(Sum1.Text);
            // number2 = Convert.ToInt32(Sum2.Text);

            int sum = Add(number1, number2);
            SumResult.Text = sum.ToString();
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }
    }
}