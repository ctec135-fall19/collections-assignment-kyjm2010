//Author: Kyle McDonald
//Date:   10/24/2019
//CTEC 135: Microsoft Software Development with C# 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        //description:  Program demostrates use of an array and a list of int
        //type
        //input:        size 5 int array Ints 11-15 21-25 and 31-35
        //-Nine and "99"
        //output:       The initial output shows the values in myIntArray after 
        //being initialized by a for loop to take the values 11-15. Next the
        //initial values of myIntList are printed after being initialized to
        //the numbers 21-25 by way of a for loop. Finally, using index notation
        //each value in myIntList is updated +10 thie initial value and 
        //printed.
        //behavior:     Porgram creates a simple array size 5 initializing 
        //values with a for loop set to start at 31 and continue until the 
        //value is 36. Each index of the array is assigned a value. Then the 
        //array is printed, each index being printed on a separate line.
        //Next a list of type int is created and initialized using a for loop
        //that begins at the value 21 and ends when the value is 26. Each list
        //index is assigned a value, then the list is printed. Finally, using
        //index notation, each index value is changed to a number that is 10 
        //greater than the initial value and the final list is printed using.
        //indexing
        static void Main(string[] args)
        {
            #region simple array
            //create an array of int of size 5
            int[] myIntArray = new int[5];
            //set a number for the indexer
            int b = 0;

            //use a for loop to initialize it to the numbers 11 - 15
            for (int a = 11; a<16; a++)
            {
                myIntArray[b] = a;
                b++;   
            }

            Console.WriteLine("------------");
            Console.WriteLine("Simple array");
            Console.WriteLine("------------");
            //use a foreach loop to print out the values in the array
            foreach (int c in myIntArray)
            {
                Console.WriteLine("myIntArray: {0}", c);

            }
            Console.WriteLine();
            #endregion

            #region Int List
            //create a list of int
            List<int> myIntList = new List<int>();
            //use a for loop to initialize the list to the numbers 21 - 25
            for (int d = 21; d < 26; d++)
            {
                myIntList.Add(d);
            }

            Console.WriteLine("-------");
            Console.WriteLine("IntList");
            Console.WriteLine("-------");
            //use a foreach loop to print out the values in the list
            foreach (int d in myIntList)
            {
                Console.WriteLine("myIntList: {0}", d);
                
            }

            //update the values in the list to 31 - 35 using indexing
            myIntList[0] = 31;
            myIntList[1] = 32;
            myIntList[2] = 33;
            myIntList[3] = 34;
            myIntList[4] = 35;
            Console.WriteLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("IntList after value changes");
            Console.WriteLine("---------------------------");
            //repeat the print using a for loop and indexing
            for (int g = 0; g < 5; g++)
            {
               Console.WriteLine("new myIntList: {0}", myIntList[g]);
            }

            #endregion

        }
    }
}
