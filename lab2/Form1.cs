namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial: {result}";
        }

        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }
        public int RecursiveFibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }
        private void FiboCal_Click(object sender, EventArgs e)
        {
            int number = int.Parse(FiboInput.Text);
            int result = RecursiveFibonacci(number);
            lblFiboResult.Text = $"F = {result}";
        }

        public int RecursivePower(int n, int power)
        {
            if (power == 0) return 1;
            return n * RecursivePower(n, power - 1);
        }

        private void btnPowerCalculate_Click(object sender, EventArgs e)
        {
            int baseNum = int.Parse(inputBase.Text);
            int exponent = int.Parse(inputPower.Text);
            int result = RecursivePower(baseNum, exponent);
            lblPowerResult.Text = $"Power: {result}";
        }
    }
}
