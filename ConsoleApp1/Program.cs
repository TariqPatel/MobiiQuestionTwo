using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var initialArray = new int[5, 4] {{1, 2, 3, 4}, {1, 1, 1, 1}, {2, 2, 2, 2}, {3, 3, 3, 3}, {4, 4, 4, 4}};
            OutputToConsole(initialArray);
        }

        public static void OutputToConsole(int[,] array)
        {
            var editedArray = SetValuesToZeroInArray(array);
            PrintArray(editedArray);
        }

        private static void PrintArray(int[,] array)
        {
            var rowLength = array.GetLength(0);
            var colLength = array.GetLength(1);

            for (var i = 0; i < rowLength; i++)
            {
                for (var j = 0; j < colLength; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }

                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            Console.ReadLine();
        }

        private static List<ListPairs> GetListPairValues(int[,] array)
        {
            List<ListPairs> listPairs = new List<ListPairs>();
            var rowLength = array.GetLength(0);
            var colLength = array.GetLength(1);

            for (var k = 0; k < rowLength; k++)
            {
                for (var l = 0; l < colLength; l++)
                {
                    if (array[k, l] == 0)
                    {
                        listPairs.Add(new ListPairs(k, l, array[k, l]));
                    }
                }
            }

            return listPairs;
        }

        private static int[,] SetValuesToZeroInArray(int[,] array)
        {
            var listPairs = GetListPairValues(array);

            foreach (var listPair in listPairs)
            {
                var rowLength = array.GetLength(0);
                var colLength = array.GetLength(1);
                if (listPair.position != 0) return array;
                for (var m = 0; m < rowLength; m++)
                {
                    array[m, listPair.colValue] = 0;
                }

                for (var n = 0; n < colLength; n++)
                {
                    array[listPair.rowValue, n] = 0;
                }
            }

            return array;
        }
    }
}
