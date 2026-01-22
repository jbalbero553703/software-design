namespace Task5BubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] ProceduralSort(int[] numbers)
        {
            int temp;
            int numLength = numbers.Length;

            for (int i = 1; i <= (numLength - 1); i++)
            {
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (numbers[j + 1] < numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumbers = ProceduralSort(numbers);
            listBox1.DataSource = sortedNumbers;
        }
    }
}
