using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5OOP
{
    public class NumbersClass
    {
        public int[] numbers { get; set; } = { 47, 82, 19, 64, 35, 91, 28, 76, 53, 60 };

        public int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            return numbers;
        }
    }

}
