using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_avansate_de_programare_Dan_10
{
    internal class Program
    {
        static void Main()
        {
            //citire graf
            /*
            Console.WriteLine("introduceti numarul de noduri");
            int numarNoduri = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti datele sub forma de matrice (intr-o singura linie. Ex. 0 0 2 0 0 1 2 1 0)");
            string input = Console.ReadLine();
            string[] inputt = input.Split(' ');
            int[,] data = new int[numarNoduri, numarNoduri];
            for (int i = 0; i < numarNoduri; i++)
                for(int j = 0; j < numarNoduri; j++)
                    data[i,j] = int.Parse(inputt[i*numarNoduri+j]);
            */
            //Merge sort
            Console.WriteLine("introduceti un vector");
            string input = Console.ReadLine();
            string[] splittedInput = input.Split(' ');
            int[] data = new int[splittedInput.Length];
            for (int i = 0; i < data.Length; i++)
                data[i] = int.Parse(splittedInput[i]);
            MergeSort(data, 0, data.Length - 1);
            Console.WriteLine("vectorul sortat este");
            for (int i = 0; i < data.Length; ++i)
                Console.Write(data[i] + " ");
            Console.WriteLine();
        }
        static void Merge(int[] data, int leftIndex, int middleIndex, int rightIndex)
        {
            int firstSize = middleIndex - leftIndex + 1;
            int secondSize = rightIndex - middleIndex;
            int[] leftArray = new int[firstSize];
            int[] rightArray = new int[secondSize];
            int i, j;
            for (i = 0; i < firstSize; ++i)
                leftArray[i] = data[leftIndex + i];
            for (j = 0; j < secondSize; ++j)
                rightArray[j] = data[middleIndex + 1 + j];
            i = 0;
            j = 0;
            int k = leftIndex;
            while (i < firstSize && j < secondSize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    data[k] = leftArray[i];
                    i++;
                }
                else
                {
                    data[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < firstSize)
            {
                data[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < secondSize)
            {
                data[k] = rightArray[j];
                j++;
                k++;
            }
        }
        static void MergeSort(int[] data, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {

                int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                MergeSort(data, leftIndex, middleIndex);
                MergeSort(data, middleIndex + 1, rightIndex);

                Merge(data, leftIndex, middleIndex, rightIndex);
            }
        }
    }
}
