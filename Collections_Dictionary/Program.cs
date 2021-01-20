using System;
using System.Collections.Generic;

namespace Collections_Dictionary
{
    class Program
    {
        static void display(Dictionary<int, string> arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void display(Dictionary<string, string> arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 100, 200, 300 };
            string[] city = { "lahore", "karachi", "pindi" };
            
            var myDictionary1 = new Dictionary<int, string>();

            myDictionary1.Add(2, "wamik");
            myDictionary1.Add(4, "afaq");
            myDictionary1.Add(5, "umair");
            myDictionary1.Add(3, "askari");
            myDictionary1.Add(1, "ihtisham");
            myDictionary1.Add(7, "ihtisham");

            for(int i=0; i<3; i++)
            {
                myDictionary1.Add(arr[i], city[i]);
            }

            var myDictionary2 = new Dictionary<string, string>
            {
                { "Pakistan", "Lahore" }, { "USA", "California" }, { "Saudia", "Tabuk"}, { "Australia", "Sydney"}, { "UK", "London"}
            };
            
            Console.WriteLine("--------------------------------------------------First iteration--------------------------------------------------");
            Console.WriteLine("Displaying Names");
            display(myDictionary1);
            Console.WriteLine("Displaying Cities");
            display(myDictionary2);

            myDictionary1.Remove(4);
            myDictionary2.Remove("USA");
            
            Console.WriteLine("--------------------------------------------------Second iteration--------------------------------------------------");
            Console.WriteLine("Displaying Names");
            display(myDictionary1);
            Console.WriteLine("Displaying Cities");
            display(myDictionary2);
            
            Console.WriteLine(myDictionary1.ContainsValue("wamik"));

            if(myDictionary1.ContainsKey(7))
            {
                myDictionary1[7] = "Ali";
            }

            if (myDictionary2.ContainsKey("UK"))
            {
                myDictionary2["UK"] = "Birminghim";
            }

            Console.WriteLine("--------------------------------------------------Third iteration--------------------------------------------------");
            Console.WriteLine("Displaying Names");
            display(myDictionary1);
            Console.WriteLine("Displaying Cities");
            display(myDictionary2);
        }
    }
}
