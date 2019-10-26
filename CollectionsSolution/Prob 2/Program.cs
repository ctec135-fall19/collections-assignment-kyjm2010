//Author: Kyle McDonald
//Date:   10/24/2019
//CTEC 135: Microsoft Software Development with C# 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stacks
            Stack<int> myIntStack = new Stack<int>();
            myIntStack.Push(1);
            myIntStack.Push(2);
            myIntStack.Push(3);
            myIntStack.Push(4);
            myIntStack.Push(5);

            foreach (int number in myIntStack)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            Console.WriteLine("Peeking: {0}",
            myIntStack.Peek());
            Console.WriteLine();

            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Popping number {0} from the stack", myIntStack.Pop());
            }
            Console.WriteLine();
            #endregion

            #region queue
            Queue<int> myIntQueue = new Queue<int>();
            for(int j = 1; j<6; j++)
            {
                myIntQueue.Enqueue(j);
            }
            foreach(int number in myIntQueue)
            {
                Console.WriteLine("myIntQueue: {0}", number);
            }
            Console.WriteLine();

            Console.WriteLine("Peeking: {0}",
            myIntQueue.Peek());
            Console.WriteLine();

            for(int k = 0; k <5; k++)
            {
                Console.WriteLine("Dequeuing number: {0}", myIntQueue.Dequeue());
            }
            #endregion
        }
    }
}
