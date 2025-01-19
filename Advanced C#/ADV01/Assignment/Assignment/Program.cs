using System.Collections;

namespace Assignment
{
    internal class Program
    {
        static void Swap<T>(ref T a,ref T b)
        {
            T temp=a;
            a=b;
            b=temp;
        }
        static void BubbleSort(ref int[] arr)
        {
            // Optimize : break from outer loop when array be sorted 
            for (int i = 0; i < arr?.Length; i++) {
                bool isSorted = true;
                for (int j = 0; j < arr?.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        isSorted = false;
                    }
                }
                if (isSorted)
                    break;
            }
         }
        static List<int> EvenNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();
            foreach (int i in numbers)
            {
                if ((i & 1) == 1)
                    continue;
                result.Add(i);
            }
            return result;
        }
        static string FirstNonReapetedChar(string? s)
        {
            int[] frq = new int[26];
            foreach (char c in s)
            {
                frq[c - 'a']++;
            }
            foreach (char c in s)
            {
                if (frq[c - 'a'] > 1) continue;
                string val = string.Empty;
                val += c;
                return val;

            }
            return "-1";
        }
        static void Main(string[] args)
        {
            #region 1.The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimise the Bubble Sort algorithm And implement the code of this optimised bubble sort algorithm

            //int[] arr = { 1, 2, 3,2,6,3,4,2 };
            //BubbleSort(ref arr);
            //foreach(int i in arr) Console.WriteLine(i); 
            #endregion
            #region 2.	create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range
            //Range<int> range=new Range<int>(10,100);
            //if (range.IsInRange(38))
            //{
                //Console.WriteLine("In Range");
            //}
            //else
            //{
                //Console.WriteLine("Not in Range");
            //}
            //Console.WriteLine(range.Length());
            #endregion
            #region 3.You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            //ArrayList arr = [ 1, 2, 3, 4, 5 ];
            //for (int i = 0; i < arr.Count / 2; i++)
            //{
            //    object? temp = arr[i];
            //    arr[i] = arr[arr.Count-i - 1];
            //    arr[arr.Count - i - 1] = temp;

            //}
            //foreach (var i in arr) Console.WriteLine(i);
            #endregion
            #region 4.You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list
            //List<int> nums = [1,2,3,4,5,6,7];
            //List<int>evens=EvenNumbers(nums);
            //foreach(int i in evens) Console.WriteLine(i);
            #endregion
            #region 5.implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and 
            //FixedSizeList<int> list = new FixedSizeList<int>(3);
            //list.Add(1);
            //Console.WriteLine(list.Get(2));
            #endregion
            #region 6.Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1. Hint you can use dictionary
            //string s = "abcadabc";
            //Console.WriteLine(FirstNonReapetedChar(s));
            #endregion
        }
    }
}
