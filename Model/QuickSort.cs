using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppSource.Contracts;

namespace WinFormsAppSource.Model
{
    public class QuickSort : ISortStrategy
    {
        public string Sort(string input)
        {
            char[] charArray = input.ToCharArray();
            QuickSortArray(charArray, 0, charArray.Length - 1);
            return new string(charArray);
        }

        private void QuickSortArray(char[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSortArray(array, low, pivotIndex - 1);
                QuickSortArray(array, pivotIndex + 1, high);
            }
        }

        private int Partition(char[] array, int low, int high)
        {
            char pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    char temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            char swapTemp = array[i + 1];
            array[i + 1] = array[high];
            array[high] = swapTemp;

            return i + 1;
        }


    }
}
