//Author: Kyle McDonald
//Date:   10/24/2019
//CTEC 135: Microsoft Software Development with C# 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Program

    { 
        //description:  Program demostrates traversal, .Find, .Remove and
        //              .AddAfter functions of a linked list
        //input:        The first 9 words of the itsy bitsy spider in a string
        //              array
        //output:       The initial output is the contents of the string array
        //printed on a single line using a foreach loop. Next, output is the 
        //exact same as previous line, just done differentlyThe next output 
        //shows the contents of the string arrayu printed, but the word Crawled
        //has been removedShows the output after the word Crawled has been add
        //back in after the word Spider
        //behavior:     a string array is built containing the first 8 words of
        //the itsy bitsy spider. A linked list is created using the string 
        //array as an argument. A foreach loop traverses the linked list and 
        //prints each word on the same line. Next a a node is created and set
        //to the first value of the linked list. While the node does not equal
        //null, the loop will continue to write the node.Value on a single line
        //Next a new node is created and named current. It is assigned the 
        //value of "Crawled" using the .Find built in method. The current node 
        //is removed from the linked list and the contents are printed using a 
        //foreach loop current node is now set to "Spider" and "Crawled" is 
        //added back into the linked list using the .AddAfter method. List is
        //printed using a foreach loop
        static void Main(string[] args)
        {
            //create a string array and initialize it with characters from the
            //itsy bitsy spider 
            string[] strArray = { "The ", "Itsy ", "Bitsy ", "Spider ", 
                "Crawled ", "Up ", "The ", "Water ", "Spout " };
            //create a linked list that takes strArray as an argument
            LinkedList<string> verse = new LinkedList<string>(strArray);
            //print each word in the list on a single line
            Console.WriteLine("Traversal using a foreach loop");
            foreach(string word in verse)
            {
                Console.Write(word);
                
            }
            Console.WriteLine();
            Console.WriteLine();
            //create a node and set it to the first value of the linked list
            LinkedListNode<string> node = verse.First;
            //use a while loop to print the list on a single line ending when
            //node == null
            Console.WriteLine("Traversal using a while loop and a node");
            while (node != null)
            {
                Console.Write("{0}", node.Value);
                node = node.Next;
            }
            Console.WriteLine();
            Console.WriteLine();
            //use .Find to travers the list and find the value that matches,
            //set a node to equal this value
            LinkedListNode<string> current = verse.Find("Crawled ");
            //remove the current node from the list and re-print the list
            verse.Remove(current);

            Console.WriteLine("List after removal of \"Crawled \"");
            foreach (string word in verse)
            {
                Console.Write(word);

            }
            Console.WriteLine();
            Console.WriteLine();

            
            //set the current node to "Spider "
            current = verse.Find("Spider ");
            //using the AddAfter method, add the string "Crawled " back into 
            //the list after the current node then re-print the list
            verse.AddAfter(current, "Crawled ");
            Console.WriteLine("After \"Crawled \" has been added back in");
            foreach (string word in verse)
            {
                Console.Write(word);

            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
