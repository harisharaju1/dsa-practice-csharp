using SampleClassLibrary;
using System;   
using System.Collections.Generic;

namespace SampleConsoleApp
{    
    public class SampleConsoleApp
    {
        public static void Main()
        {
            List<int> arr = new List<int> { -7, 0, 1, 2, 3, 5, 5 };
            var index = BinarySearch.BinarySearchMethod(arr, 5);
            Console.WriteLine(index.ToString());
        }
    }
}