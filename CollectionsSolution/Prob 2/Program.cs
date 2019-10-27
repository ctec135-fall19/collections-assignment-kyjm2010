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
        //description:  Program demostrates use of a Stack and the mthods 
        //peek, push and pop associated with it as well as a Queue and the
        //methods peek, enqueue and dequeue associated with it.
        //input:        Ints 1, 2, 3, 4 and 5
        //output:       The initial outputs shows the stack of 5 numbers LIFO 
        //highlighted by the writing that 5 was the last number added yet it 
        //at the top of the stack. The top number of the stack is then shown by
        //using the peek method. Finally, each number is popped from the top of
        //the stack. Outputs for region 2 show the initial queue created after 
        //initialization FIFO highlighted by the writing that 1 was the first
        //number added to the queue. The first number in the list is shown 
        //using the peek method. Numbers are then shown being dequeued 1 by 1 
        //behavior:     Program creates a stack of ints using initialization 
        //syntax .Push to set elements to the numbers 1-5. Using a foreach loop
        //, each item in the stack is printed in  the order it appears. Using
        //.Peek the program shows the first number in the stack. By using the 
        //.Pop method, each number is removed from the stack and the program 
        //prints the value as it is removed. The program then creates a queue 
        //of ints and using a for loop, initializes the elements to the numbers
        //1-5. The queue is then printed with a foreach loop. Using .Peek, the
        //program shows the first item in the queue. Finally, using dequeue and
        //a for loop, numbers are removed from the queue. 
        static void Main(string[] args)
        {
            #region Stacks
            //declare and initialize a stack with the numbers 1 - 5 using 
            //initialization syntax.
            Stack<int> myIntStack = new Stack<int>();
            myIntStack.Push(1);
            myIntStack.Push(2);
            myIntStack.Push(3);
            myIntStack.Push(4);
            myIntStack.Push(5);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Stack of Numbers, Number 1 Added First");
            Console.WriteLine("--------------------------------------");
            //demonstrate use of the enumerator to print out the members in the
            //stack, i.e.write a foreach loop
            foreach (int number in myIntStack)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Peeking at the Top Numberin the Stack");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Peeking: {0}",
            //print a peek at the top member in the stack
            myIntStack.Peek());
            Console.WriteLine();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Popping numbers off the top of the stack");
            Console.WriteLine("----------------------------------------");
            //write a loop that pops the elements off of the stack and prints
            //each
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Popping number {0} from the stack", 
                    myIntStack.Pop());
            }
            Console.WriteLine();
            #endregion

            #region queue
            //declare a queue
            Queue<int> myIntQueue = new Queue<int>();
            //initialize the queue with the numbers 1-5 using a for loop.
            for (int j = 1; j<6; j++)
            {
                myIntQueue.Enqueue(j);
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Queue of Numbers, Number 1 Added First");
            Console.WriteLine("--------------------------------------");
            //demonstrate use of the enumerator to print out the members in the
            //queue, i.e.write a foreach loop
            foreach (int number in myIntQueue)
            {
                Console.WriteLine("myIntQueue: {0}", number);
            }
            Console.WriteLine();

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Peeking at the Top Number in the Queue");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Peeking: {0}",
            //print a peek at the top member in the stack
            myIntQueue.Peek());
            Console.WriteLine();

            Console.WriteLine("-----------------");
            Console.WriteLine("Dequeuing Numbers");
            Console.WriteLine("-----------------");
            //write a loop that dequeues the elements from the stack and prints
            //each
            for (int k = 0; k <5; k++)
            {
                Console.WriteLine("Dequeuing number: {0}", 
                    myIntQueue.Dequeue());
            }
            #endregion
        }
    }
}
