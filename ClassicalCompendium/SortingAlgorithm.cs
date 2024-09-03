using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassicalCompendium
{
    public class SortingAlgorithm
    {
        public static List<T> BubbleSort<T>(List<T> list) where T : IComparable<T>
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        (list[j + 1], list[j]) = (list[j], list[j + 1]);
                    }
                }
            }

            return list;
        }

        public static List<T> SelectionSort<T>(List<T> list) where T : IComparable<T>
        {
            int min;
            T temp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j].CompareTo(list[min]) < 0)
                    {
                        min = j;
                    }
                }

                (list[i], list[min]) = (list[min], list[i]);
            }
            return list;
        }

        public static List<T> InsertionSort<T>(List<T> list) where T : IComparable<T>
        {
            T value;

            for (int i = 1; i < list.Count; i++)
            {
                value = list[i];
                int j = i - 1;
                while (j >= 0 && list[j].CompareTo(value) > 0)
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = value;
            }

            return list;
        }

        public static List<T> QuickSort<T>(List<T> list, int left, int right) where T : IComparable<T>
        {
            if (left < right)
            {
                int pivot = Partition(list, left, right);

                QuickSort(list, left, pivot - 1);
                QuickSort(list, pivot + 1, right);
            }

            return list;
        }

        private static int Partition<T>(List<T> list, int left, int right) where T : IComparable<T>
        {
            T pivot = list[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (list[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    (list[j], list[i]) = (list[i], list[j]);
                }
            }

            (list[right], list[i + 1]) = (list[i + 1], list[right]);

            return i + 1;
        }

        public static List<T> MergeSort<T>(List<T> unsorted) where T : IComparable<T>
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<T> left = new List<T>();
            List<T> right = new List<T>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<T> Merge<T>(List<T> left, List<T> right) where T : IComparable<T>
        {
            List<T> result = new List<T>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First().CompareTo(right.First()) <= 0)
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }

        public static List<T> HeapSort<T>(List<T> list) where T : IComparable<T>
        {
            int n = list.Count;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(list, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                (list[i], list[0]) = (list[0], list[i]);
                Heapify(list, i, 0);
            }

            return list;
        }

        private static void Heapify<T>(List<T> list, int n, int i) where T : IComparable<T>
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && list[left].CompareTo(list[largest]) > 0)
            {
                largest = left;
            }

            if (right < n && list[right].CompareTo(list[largest]) > 0)
            {
                largest = right;
            }

            if (largest != i)
            {
                (list[largest], list[i]) = (list[i], list[largest]);

                Heapify(list, n, largest);
            }
        }

        /*
        public class Objects
        {
            
        }

        public class Tables
        {
            
        }

        public class Collections
        {
            
        }

        public class UnstructuredData
        {
            
        }

        public class Multimedia
        {
            
        }

        public class LogsAndEvents
        {
            
        } 
        */
    }
}
