using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(512, "Engin");
            myDictionary.Add(659, "Kerem");
            Console.WriteLine("");

            Console.WriteLine("Total: " + myDictionary.Length);
            Console.WriteLine("");

            foreach (var value in myDictionary.Values)
            {
                Console.WriteLine("Value: " + value);
            }
        }
    }
}
