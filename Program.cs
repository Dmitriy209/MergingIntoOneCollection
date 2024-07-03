using System;
using System.Collections.Generic;

namespace MergingIntoOneCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<string> list = new List<string>();

            string[] array1 = CreateRandomArray(random);
            string[] array2 = CreateRandomArray(random);

            UniteElements(list, array1);
            UniteElements(list, array2);

            Console.Write($"Первый массив: ");
            ShowArray(array1);

            Console.Write($"Второй массив: ");
            ShowArray(array2);

            Console.Write("Коллекция из двух массивов без повторений: ");

            foreach (string item in list)
                Console.Write(item);

            Console.WriteLine();
        }

        private static string[] CreateRandomArray(Random random)
        {
            int minLimitRandom = 0;
            int maxLimitRandom = 10;
            int lengthArray = 10;

            string[] randomArray = new string[lengthArray];

            for (int i = 0; i < lengthArray; i++)
                randomArray[i] = Convert.ToString(random.Next(minLimitRandom, maxLimitRandom));

            return randomArray;
        }

        private static void UniteElements(List<string> list, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (list.Contains(array[i]) == false)
                    list.Add(array[i]);
            }
        }

        private static void ShowArray(string[] array)
        {
            foreach (string item in array)
                Console.Write(item);

            Console.WriteLine();
        }
    }
}
