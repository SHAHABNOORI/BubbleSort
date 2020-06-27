using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 8, 6, 1, 7, 3, 4 };
            var result = BubbleSort(numbers);
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public static int[] BubbleSort(int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                var isSorted = true;
                for (var j = 1; j < numbers.Length - i; j++)
                    if (numbers[j] < numbers[j - 1])
                    {
                        Swap(numbers, j, j - 1);
                        isSorted = false;
                    }

                if (isSorted)
                    return numbers;
            }

            return numbers;
        }

        private static void Swap(int[] numbers, int indexOne, int indexTwo)
        {
            var temp = numbers[indexOne];
            numbers[indexOne] = numbers[indexTwo];
            numbers[indexTwo] = temp;
        }
    }
}
