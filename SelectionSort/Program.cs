using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {5,16,10,11,25,15,30};
            SelectionSort.Sort(array);
            string str = "";
            for (int i = 0; i < array.Length; i++) str += $" {array[i]}";
            Console.WriteLine(str);
        }
    }
}