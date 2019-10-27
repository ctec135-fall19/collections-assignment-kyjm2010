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
        //description:  Program demostrates use of a dictionary and the Key
        //Value pairs associated with it
        //input:        Ints 1, 2, 3 and 99, strings One, Two, Three, Ninety
        //-Nine and "99"
        //output:       The initial outputs show the Keys, Values and Key 
        //Value Pairs of the dictionary. The next output reflects the change of
        //the value "Ninety-Nine to "99". Finally the dictionary is printed 
        //without item two which was removed
        //behavior:     Porgram creates a dictionary and initializes 4 
        //different key valuepairs. It then prints each key, each value and 
        //each key value pair. The value of key 99 is then changed to "99" then
        //the new value is printed using index notation. Item 2 is removed from
        //the dictionary and the dictionary is printed again in order to show 
        //item 2 has been removed
        static void Main(string[] args)
        {
         //declare a dictionary and initialize it to create 3 entries: 
         //(1, "one"), (2, "two"), and(3, "three").Use a combination of 
         //initialization syntax, Add() and[] in your initialization code.
         Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary[1] = ("One");
            myDictionary[2] = ("Two");
            myDictionary[3] = ("Three");
            //add an additional entry: (99, "ninety-nine")
            myDictionary.Add(99, "ninety-nine");
            Console.WriteLine();
            Console.WriteLine("-----");
            Console.WriteLine("Keys:");
            Console.WriteLine("-----");
            //printeach key on a separate line
            foreach(int key in myDictionary.Keys)
            {
                Console.WriteLine("Key: {0}", key);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("------");
            Console.WriteLine("Values");
            Console.WriteLine("------");

            //print each value on a separate line
            foreach (string value in myDictionary.Values)
            {
                Console.WriteLine("Value: {0}", value);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine("Key Value Pairs");
            Console.WriteLine("---------------");

            //print each key value pair on a separate line
            foreach(KeyValuePair<int, string> value in myDictionary)
            {
                Console.WriteLine("Key: {0}", value.Key);
                Console.WriteLine("Value: {0}", value.Value);
                Console.WriteLine();
            }
            Console.WriteLine();

            //assign the value of key 99 to "99"
            myDictionary[99] = "\"99\"";
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Value of Key 99 set to \"99\"");
            Console.WriteLine("-----------------------------");
            //print the new value using indexing notation
            Console.WriteLine(myDictionary[99]);
            Console.WriteLine();

            //remove the 2 item and enumerate over the whole dictionary to show
            //it's gone
            myDictionary.Remove(2);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Pairs After 2 Item Removed");
            Console.WriteLine("--------------------------");
            foreach (KeyValuePair<int, string> value in myDictionary)
            {
                Console.WriteLine("Key: {0}", value.Key);
                Console.WriteLine("Value: {0}", value.Value);
                Console.WriteLine();
            }
        }
    }
}
