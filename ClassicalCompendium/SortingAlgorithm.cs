using System.Collections.Generic;
using System.Linq;

namespace ClassicalCompendium
{
    public class SortingAlgorithm
    {
        public class NumbersList
        {
            public static List<int> BubbleSort(List<int> list)
            {
                int temp;
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j < list.Count - 1; j++)
                    {
                        if (list[j] > list[j + 1])
                        {
                            temp = list[j + 1];
                            list[j + 1] = list[j];
                            list[j] = temp;
                        }
                    }
                }
                return list;
            }

            public static List<int> SelectionSort(List<int> list)
            {
                int min;
                int temp;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    min = i;
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[j] < list[min])
                        {
                            min = j;
                        }
                    }
                    temp = list[i];
                    list[i] = list[min];
                    list[min] = temp;
                }
                return list;
            }

            public static List<int> InsertionSort(List<int> list)
            {
                int value;

                for (int i = 1; i < list.Count; i++)
                {
                    value = list[i];
                    int j = i - 1;
                    while (j >= 0 && list[j] > value)
                    {
                        list[j + 1] = list[j];
                        j--;
                    }
                    list[j + 1] = value;
                }

                return list;
            }

            public static List<int> QuickSort(List<int> list, int left, int right)
            {
                if (left < right)
                {
                    int pivot = Partition(list, left, right);

                    QuickSort(list, left, pivot - 1);
                    QuickSort(list, pivot + 1, right);
                }

                return list;
            }

            private static int Partition(List<int> list, int left, int right)
            {
                int pivot = list[right];
                int i = left - 1;

                for (int j = left; j < right; j++)
                {
                    if (list[j] <= pivot)
                    {
                        i++;
                        (list[j], list[i]) = (list[i], list[j]);
                    }
                }

                (list[right], list[i + 1]) = (list[i + 1], list[right]);

                return i + 1;
            }

            public static List<int> MergeSort(List<int> unsorted)
            {
                if (unsorted.Count <= 1)
                    return unsorted;

                List<int> left = new List<int>();
                List<int> right = new List<int>();

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

            private static List<int> Merge(List<int> left, List<int> right)
            {
                List<int> result = new List<int>();

                while (left.Count > 0 || right.Count > 0)
                {
                    if (left.Count > 0 && right.Count > 0)
                    {
                        if (left.First() <= right.First())
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

            public static List<int> HeapSort(List<int> list)
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

            private static void Heapify(List<int> list, int n, int i)
            {
                int largest = i;
                int left = 2 * i + 1;
                int right = 2 * i + 2;

                if (left < n && list[left] > list[largest])
                {
                    largest = left;
                }

                if (right < n && list[right] > list[largest])
                {
                    largest = right;
                }

                if (largest != i)
                {
                    (list[largest], list[i]) = (list[i], list[largest]);

                    Heapify(list, n, largest);
                }
            }

        }

        public class StringsList
        {
            public static List<string> BubbleSort(List<string> str)
            {
                string temp;
                for (int i = 0; i < str.Count; i++)
                {
                    for (int j = 0; j < str.Count - 1; j++)
                    {
                        if (str[j].CompareTo(str[j + 1]) > 0)
                        {
                            temp = str[j + 1];
                            str[j + 1] = str[j];
                            str[j] = temp;
                        }
                    }
                }
                return str;
            }

            public static List<string> SelectionSort(List<string> str)
            {
                string temp;
                for (int i = 0; i < str.Count - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < str.Count; j++)
                    {
                        if (str[j].CompareTo(str[minIndex]) < 0)
                        {
                            minIndex = j;
                        }
                    }
                    temp = str[i];
                    str[i] = str[minIndex];
                    str[minIndex] = temp;
                }
                return str;
            }

            public static List<string> InsertionSort(List<string> str)
            {
                string value;

                for (int i = 1; i < str.Count; i++)
                {
                    value = str[i];
                    int j = i - 1;
                    while (j >= 0 && str[j].CompareTo(value) > 0)
                    {
                        str[j + 1] = str[j];
                        j--;
                    }
                    str[j + 1] = value;
                }

                return str;
            }

            public static List<string> QuickSort(List<string> str, int left, int right)
            {
                if (left < right)
                {
                    int pivot = Partition(str, left, right);

                    QuickSort(str, left, pivot - 1);
                    QuickSort(str, pivot + 1, right);
                }

                return str;
            }

            private static int Partition(List<string> str, int left, int right)
            {
                string pivot = str[right];
                int i = left - 1;

                for (int j = left; j < right; j++)
                {
                    if (str[j].CompareTo(pivot) <= 0)
                    {
                        i++;
                        (str[j], str[i]) = (str[i], str[j]);
                    }
                }

                (str[right], str[i + 1]) = (str[i + 1], str[right]);

                return i + 1;
            }

            public static List<string> MergeSort(List<string> unsorted)
            {
                if (unsorted.Count <= 1)
                    return unsorted;

                List<string> left = new List<string>();
                List<string> right = new List<string>();

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

            private static List<string> Merge(List<string> left, List<string> right)
            {
                List<string> result = new List<string>();

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

            public static List<string> HeapSort(List<string> str)
            {
                int n = str.Count;
                for (int i = n / 2 - 1; i >= 0; i--)
                {
                    Heapify(str, n, i);
                }

                for (int i = n - 1; i >= 0; i--)
                {
                    (str[i], str[0]) = (str[0], str[i]);
                    Heapify(str, i, 0);
                }

                return str;
            }

            private static void Heapify(List<string> str, int n, int i)
            {
                int largest = i;
                int left = 2 * i + 1;
                int right = 2 * i + 2;

                if (left < n && str[left].CompareTo(str[largest]) > 0)
                {
                    largest = left;
                }

                if (right < n && str[right].CompareTo(str[largest]) > 0)
                {
                    largest = right;
                }

                if (largest != i)
                {
                    (str[largest], str[i]) = (str[i], str[largest]);

                    Heapify(str, n, largest);
                }
            }

        }

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
    }
}
