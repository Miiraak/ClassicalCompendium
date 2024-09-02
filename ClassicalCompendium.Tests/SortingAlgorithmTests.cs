namespace ClassicalCompendium.Tests
{
    public class SortingAlgorithmTests
    {
        public class Numbers
        {
            [Fact]
            public void BubbleSortTest()
            {
                List<int> list = [5, 3, 8, 4, 2];
                List<int> expected = [2, 3, 4, 5, 8];
                List<int> actual = SortingAlgorithm.NumbersList.BubbleSort(list);
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void SelectionSortTest()
            {
                List<int> list = [5, 3, 8, 4, 2];
                List<int> expected = [2, 3, 4, 5, 8 ];
                List<int> actual = SortingAlgorithm.NumbersList.SelectionSort(list);
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void InsertionSortTest()
            {
                List<int> list = [5, 3, 8, 4, 2];
                List<int> expected = [2, 3, 4, 5, 8];
                List<int> actual = SortingAlgorithm.NumbersList.InsertionSort(list);
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void MergeSortTest()
            {
                List<int> list = [5, 3, 8, 4, 2 ];
                List<int> expected = [2, 3, 4, 5, 8];
                List<int> actual = SortingAlgorithm.NumbersList.MergeSort(list);
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void QuickSortTest()
            {
                List<int> list = [5, 3, 8, 4, 2];
                List<int> expected = [2, 3, 4, 5, 8];
                List<int> actual = SortingAlgorithm.NumbersList.QuickSort(list, 0, list.Count - 1);
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void HeapSortTest()
            {
                List<int> list = [5, 3, 8, 4, 2];
                List<int> expected = [2, 3, 4, 5, 8];
                List<int> actual = SortingAlgorithm.NumbersList.HeapSort(list);
                Assert.Equal(expected, actual);
            }
        }

        public class Strings
        {
            [Fact]
            public void BubbleSortTest()
            {
                List<string> list = ["banana", "apple", "orange", "grape", "kiwi"];
                List<string> expected = ["apple", "banana", "grape", "kiwi", "orange"];
                List<string> actual = SortingAlgorithm.StringsList.BubbleSort(list);
                Assert.Equal(expected, actual);
                List<string> list2 = ["Cow", "Monkey", "Dog", "Elephant", "Cat"];
                List<string> expected2 = ["Cat", "Cow", "Dog", "Elephant", "Monkey"];
                List<string> actual2 = SortingAlgorithm.StringsList.BubbleSort(list2);
                Assert.Equal(expected2, actual2);
            }

            [Fact]
            public void SelectionSortTest()
            {
                List<string> list = ["banana", "apple", "orange", "grape", "kiwi"];
                List<string> expected = ["apple", "banana", "grape", "kiwi", "orange"];
                List<string> actual = SortingAlgorithm.StringsList.SelectionSort(list);
                Assert.Equal(expected, actual);
                List<string> list2 = ["Cow", "Monkey", "Dog", "Elephant", "Cat"];
                List<string> expected2 = ["Cat", "Cow", "Dog", "Elephant", "Monkey"];
                List<string> actual2 = SortingAlgorithm.StringsList.SelectionSort(list2);
                Assert.Equal(expected2, actual2);
            }

            [Fact]
            public void InsertionSortTest()
            {
                List<string> list = ["banana", "apple", "orange", "grape", "kiwi"];
                List<string> expected = ["apple", "banana", "grape", "kiwi", "orange"];
                List<string> actual = SortingAlgorithm.StringsList.InsertionSort(list);
                Assert.Equal(expected, actual);
                List<string> list2 = ["Cow", "Monkey", "Dog", "Elephant", "Cat"];
                List<string> expected2 = ["Cat", "Cow", "Dog", "Elephant", "Monkey"];
                List<string> actual2 = SortingAlgorithm.StringsList.InsertionSort(list2);
                Assert.Equal(expected2, actual2);
            }

            [Fact]
            public void MergeSortTest()
            {
                List<string> list = ["banana", "apple", "orange", "grape", "kiwi"];
                List<string> expected = ["apple", "banana", "grape", "kiwi", "orange"];
                List<string> actual = SortingAlgorithm.StringsList.MergeSort(list);
                Assert.Equal(expected, actual);
                List<string> list2 = ["Cow", "Monkey", "Dog", "Elephant", "Cat"];
                List<string> expected2 = ["Cat", "Cow", "Dog", "Elephant", "Monkey"];
                List<string> actual2 = SortingAlgorithm.StringsList.MergeSort(list2);
                Assert.Equal(expected2, actual2);
            }

            [Fact]
            public void QuickSortTest()
            {
                List<string> list = ["banana", "apple", "orange", "grape", "kiwi"];
                List<string> expected = ["apple", "banana", "grape", "kiwi", "orange"];
                List<string> actual = SortingAlgorithm.StringsList.QuickSort(list, 0, list.Count - 1);
                Assert.Equal(expected, actual);
                List<string> list2 = ["Cow", "Monkey", "Dog", "Elephant", "Cat"];
                List<string> expected2 = ["Cat", "Cow", "Dog", "Elephant", "Monkey"];
                List<string> actual2 = SortingAlgorithm.StringsList.QuickSort(list2, 0, list2.Count - 1);
                Assert.Equal(expected2, actual2);
            }

            [Fact]
            public void HeapSortTest()
            {
                List<string> list = ["banana", "apple", "orange", "grape", "kiwi"];
                List<string> expected = ["apple", "banana", "grape", "kiwi", "orange"];
                List<string> actual = SortingAlgorithm.StringsList.HeapSort(list);
                Assert.Equal(expected, actual);
                List<string> list2 = ["Cow", "Monkey", "Dog", "Elephant", "Cat"];
                List<string> expected2 = ["Cat", "Cow", "Dog", "Elephant", "Monkey"];
                List<string> actual2 = SortingAlgorithm.StringsList.HeapSort(list2);
                Assert.Equal(expected2, actual2);
            }
        }
    }
}
