//Author: Kyle McDonald
//Date:   10/24/2019
//CTEC 135: Microsoft Software Development with C# 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary[1] = ("One");
            myDictionary[2] = ("Two");
            myDictionary[3] = ("Three");
            myDictionary[99] = ("ninety-nine");

            foreach(KeyValuePair<int, string> value in myDictionary)
            {
                Console.WriteLine("Key: {0}", value.Key);
                Console.WriteLine("Value: {0}", value.Value);
                Console.WriteLine();
            }

            myDictionary[99] = "\"99\"";

            Console.WriteLine(myDictionary[99]);

            myDictionary.Remove(2);
            //myDictionary.Remove(1);

            foreach (KeyValuePair<int, string> value in myDictionary)
            {
                Console.WriteLine("Key: {0}", value.Key);
                Console.WriteLine("Value: {0}", value.Value);
                Console.WriteLine();
            }
        }
    }
}
