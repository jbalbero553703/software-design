using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5OOP
{
    public class NumbersClass
    {
        public int[] numbers { get; set; } = { 3, 1, 5, 2, 4 };

        public int[] ProceduralSort(int[] numbers)
        {
            // Bubble Sort Descending Order
            int temp;
            int numLength = numbers.Length;

            for (int i = 1; i <= (numLength - 1); i++)
            {
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (numbers[j + 1] > numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }
    }

}
