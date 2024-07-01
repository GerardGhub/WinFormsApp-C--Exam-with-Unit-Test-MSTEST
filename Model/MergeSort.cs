using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppSource.Contracts;

namespace WinFormsAppSource.Model
{
    public class MergeSort : ISortStrategy
    {
        public string Sort(string input)
        {
            char[] charArray = input.ToCharArray();
            MergeSortArray(charArray, 0, charArray.Length - 1);
            return new string(charArray);
        }

        private void MergeSortArray(char[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSortArray(array, left, middle);
                MergeSortArray(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        private void Merge(char[] array, int left, int middle, int right)
        {
            int leftArraySize = middle - left + 1;
            int rightArraySize = right - middle;

            char[] leftArray = new char[leftArraySize];
            char[] rightArray = new char[rightArraySize];

            Array.Copy(array, left, leftArray, 0, leftArraySize);
            Array.Copy(array, middle + 1, rightArray, 0, rightArraySize);

            int i = 0, j = 0, k = left;
            while (i < leftArraySize && j < rightArraySize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftArraySize)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightArraySize)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }

        }


    }
}
