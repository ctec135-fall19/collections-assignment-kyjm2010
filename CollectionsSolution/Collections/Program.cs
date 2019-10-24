using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region simple array
            int[] myIntArray = new int[5];
            int b = 0;
            for(int a = 11; a<16; a++)
            {
                myIntArray[b] = a;
                b++;   
            }

            foreach(int c in myIntArray)
            {
                Console.WriteLine("myIntArray: {0}", c);

            }
            Console.WriteLine();
            #endregion

            #region Int List
            List<int> myIntList = new List<int>();
            for (int d = 21; d < 26; d++)
            {
                myIntList.Add(d);
            }

            foreach(int d in myIntList)
            {
                Console.WriteLine("myIntList: {0}", d);
                
            }

            myIntList[0] = 31;
            myIntList[1] = 32;
            myIntList[2] = 33;
            myIntList[3] = 34;
            myIntList[4] = 35;
            Console.WriteLine();

            for (int g = 0; g < 5; g++)
            {
               Console.WriteLine("new myIntList: {0}", myIntList[g]);
            }

            #endregion

        }
    }
}
