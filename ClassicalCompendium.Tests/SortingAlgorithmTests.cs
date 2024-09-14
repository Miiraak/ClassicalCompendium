namespace ClassicalCompendium.Tests
{
    public class SortingAlgorithmTests
    {
        [Fact]
        public void BubbleSortTests()
        {
            List<int> listInt = [2, 4, 3, 5, 1];
            List<string> listString = ["d", "a", "e", "b", "c"];
            List<double> listDouble = [2.2, 4.4, 3.3, 1.1, 5.5];
            List<bool> listBool = [true, false, true, false, true];
            List<char> listChar = ['c', 'b', 'a', 'e', 'd'];

            List<int> expectedInt = [1, 2, 3, 4, 5];
            List<string> expectedString = ["a", "b", "c", "d", "e"];
            List<double> expectedDouble = [1.1, 2.2, 3.3, 4.4, 5.5];
            List<bool> expectedBool = [false, false, true, true, true];
            List<char> expectedChar = ['a', 'b', 'c', 'd', 'e'];

            List<int> actualInt = SortingAlgorithm.BubbleSort(listInt);
            List<string> actualString = SortingAlgorithm.BubbleSort(listString);
            List<double> actualDouble = SortingAlgorithm.BubbleSort(listDouble);
            List<bool> actualBool = SortingAlgorithm.BubbleSort(listBool);
            List<char> actualChar = SortingAlgorithm.BubbleSort(listChar);

            Assert.Equal(expectedInt, actualInt);
            Assert.Equal(expectedString, actualString);
            Assert.Equal(expectedDouble, actualDouble);
            Assert.Equal(expectedBool, actualBool);
            Assert.Equal(expectedChar, actualChar);
        }

        [Fact]
        public void SelectionSortTests()
        {
            List<int> listInt = [2, 4, 3, 5, 1];
            List<string> listString = ["d", "a", "e", "b", "c"];
            List<double> listDouble = [2.2, 4.4, 3.3, 1.1, 5.5];
            List<bool> listBool = [true, false, true, false, true];
            List<char> listChar = ['c', 'b', 'a', 'e', 'd'];

            List<int> expectedInt = [1, 2, 3, 4, 5];
            List<string> expectedString = ["a", "b", "c", "d", "e"];
            List<double> expectedDouble = [1.1, 2.2, 3.3, 4.4, 5.5];
            List<bool> expectedBool = [false, false, true, true, true];
            List<char> expectedChar = ['a', 'b', 'c', 'd', 'e'];

            List<int> actualInt = SortingAlgorithm.SelectionSort(listInt);
            List<string> actualString = SortingAlgorithm.SelectionSort(listString);
            List<double> actualDouble = SortingAlgorithm.SelectionSort(listDouble);
            List<bool> actualBool = SortingAlgorithm.SelectionSort(listBool);
            List<char> actualChar = SortingAlgorithm.SelectionSort(listChar);

            Assert.Equal(expectedInt, actualInt);
            Assert.Equal(expectedString, actualString);
            Assert.Equal(expectedDouble, actualDouble);
            Assert.Equal(expectedBool, actualBool);
            Assert.Equal(expectedChar, actualChar);
        }

        [Fact]
        public void InsertionSortTests()
        {
            List<int> listInt = [2, 4, 3, 5, 1];
            List<string> listString = ["d", "a", "e", "b", "c"];
            List<double> listDouble = [2.2, 4.4, 3.3, 1.1, 5.5];
            List<bool> listBool = [true, false, true, false, true];
            List<char> listChar = ['c', 'b', 'a', 'e', 'd'];

            List<int> expectedInt = [1, 2, 3, 4, 5];
            List<string> expectedString = ["a", "b", "c", "d", "e"];
            List<double> expectedDouble = [1.1, 2.2, 3.3, 4.4, 5.5];
            List<bool> expectedBool = [false, false, true, true, true];
            List<char> expectedChar = ['a', 'b', 'c', 'd', 'e'];

            List<int> actualInt = SortingAlgorithm.InsertionSort(listInt);
            List<string> actualString = SortingAlgorithm.InsertionSort(listString);
            List<double> actualDouble = SortingAlgorithm.InsertionSort(listDouble);
            List<bool> actualBool = SortingAlgorithm.InsertionSort(listBool);
            List<char> actualChar = SortingAlgorithm.InsertionSort(listChar);

            Assert.Equal(expectedInt, actualInt);
            Assert.Equal(expectedString, actualString);
            Assert.Equal(expectedDouble, actualDouble);
            Assert.Equal(expectedBool, actualBool);
            Assert.Equal(expectedChar, actualChar);
        }

        [Fact]
        public void MergeSortTests()
        {
            List<int> listInt = [2, 4, 3, 5, 1];
            List<string> listString = ["d", "a", "e", "b", "c"];
            List<double> listDouble = [2.2, 4.4, 3.3, 1.1, 5.5];
            List<bool> listBool = [true, false, true, false, true];
            List<char> listChar = ['c', 'b', 'a', 'e', 'd'];

            List<int> expectedInt = [1, 2, 3, 4, 5];
            List<string> expectedString = ["a", "b", "c", "d", "e"];
            List<double> expectedDouble = [1.1, 2.2, 3.3, 4.4, 5.5];
            List<bool> expectedBool = [false, false, true, true, true];
            List<char> expectedChar = ['a', 'b', 'c', 'd', 'e'];

            List<int> actualInt = SortingAlgorithm.MergeSort(listInt);
            List<string> actualString = SortingAlgorithm.MergeSort(listString);
            List<double> actualDouble = SortingAlgorithm.MergeSort(listDouble);
            List<bool> actualBool = SortingAlgorithm.MergeSort(listBool);
            List<char> actualChar = SortingAlgorithm.MergeSort(listChar);

            Assert.Equal(expectedInt, actualInt);
            Assert.Equal(expectedString, actualString);
            Assert.Equal(expectedDouble, actualDouble);
            Assert.Equal(expectedBool, actualBool);
            Assert.Equal(expectedChar, actualChar);
        }

        [Fact]
        public void QuickSortTests()
        {
            List<int> listInt = [2, 4, 3, 5, 1];
            List<string> listString = ["d", "a", "e", "b", "c"];
            List<double> listDouble = [2.2, 4.4, 3.3, 1.1, 5.5];
            List<bool> listBool = [true, false, true, false, true];
            List<char> listChar = ['c', 'b', 'a', 'e', 'd'];

            List<int> expectedInt = [1, 2, 3, 4, 5];
            List<string> expectedString = ["a", "b", "c", "d", "e"];
            List<double> expectedDouble = [1.1, 2.2, 3.3, 4.4, 5.5];
            List<bool> expectedBool = [false, false, true, true, true];
            List<char> expectedChar = ['a', 'b', 'c', 'd', 'e'];

            List<int> actualInt = SortingAlgorithm.QuickSort(listInt, 0, listInt.Count - 1);
            List<string> actualString = SortingAlgorithm.QuickSort(listString, 0, listString.Count - 1);
            List<double> actualDouble = SortingAlgorithm.QuickSort(listDouble, 0, listDouble.Count - 1);
            List<bool> actualBool = SortingAlgorithm.QuickSort(listBool, 0, listBool.Count - 1);
            List<char> actualChar = SortingAlgorithm.QuickSort(listChar, 0, listChar.Count - 1);

            Assert.Equal(expectedInt, actualInt);
            Assert.Equal(expectedString, actualString);
            Assert.Equal(expectedDouble, actualDouble);
            Assert.Equal(expectedBool, actualBool);
            Assert.Equal(expectedChar, actualChar);
        }

        [Fact]
        public void HeapSortTests()
        {
            List<int> listInt = [2, 4, 3, 5, 1];
            List<string> listString = ["d", "a", "e", "b", "c"];
            List<double> listDouble = [2.2, 4.4, 3.3, 1.1, 5.5];
            List<bool> listBool = [true, false, true, false, true];
            List<char> listChar = ['c', 'b', 'a', 'e', 'd'];

            List<int> expectedInt = [1, 2, 3, 4, 5];
            List<string> expectedString = ["a", "b", "c", "d", "e"];
            List<double> expectedDouble = [1.1, 2.2, 3.3, 4.4, 5.5];
            List<bool> expectedBool = [false, false, true, true, true];
            List<char> expectedChar = ['a', 'b', 'c', 'd', 'e'];

            List<int> actualInt = SortingAlgorithm.HeapSort(listInt);
            List<string> actualString = SortingAlgorithm.HeapSort(listString);
            List<double> actualDouble = SortingAlgorithm.HeapSort(listDouble);
            List<bool> actualBool = SortingAlgorithm.HeapSort(listBool);
            List<char> actualChar = SortingAlgorithm.HeapSort(listChar);

            Assert.Equal(expectedInt, actualInt);
            Assert.Equal(expectedString, actualString);
            Assert.Equal(expectedDouble, actualDouble);
            Assert.Equal(expectedBool, actualBool);
            Assert.Equal(expectedChar, actualChar);
        }
    }
}
