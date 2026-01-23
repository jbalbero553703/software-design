namespace Task5BubbleSort
{
    public partial class Form3 : Form
    {
        public Form3()
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
            int[] numbers = { 88, 24, 67, 41, 95, 32, 79, 56, 14, 63 };
            int[] sortedNumbers = ProceduralSort(numbers);
            listBox1.DataSource = sortedNumbers;
        }
    }
}
