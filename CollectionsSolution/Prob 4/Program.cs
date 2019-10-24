using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "The ", "Itsy ", "Bitsy ", "Spider ", "Crawled ", "Up ", "The ", "Water ", "Spout " };
            LinkedList<string> verse = new LinkedList<string>(strArray);
            foreach(string word in verse)
            {
                Console.Write(word);
                
            }
            Console.WriteLine();
            Console.WriteLine();

            LinkedListNode<string> node = verse.First;
            while (node != null)
            {
                Console.Write("{0}", node.Value);
                node = node.Next;
            }
            Console.WriteLine();
            Console.WriteLine();

            verse.Remove("Crawled");
            foreach (string word in verse)
            {
                Console.Write(word);

            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
