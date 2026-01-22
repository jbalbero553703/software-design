namespace Task5OOP
{
    public partial class Form1 : Form
    {

        public NumbersClass numbersClass = new NumbersClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = numbersClass.numbers;  
            int[] sortedNumbers = numbersClass.ProceduralSort(nums);
            listBox1.DataSource = sortedNumbers;
        }
    }
}
