using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppDelegates
{
    class Program
    {
        static List<int> myList = new List<int>();
        static void fillValues()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            
        }
        static void Main(string[] args)
        {
            //Func delegate
            Func<int, int> delegate2 = x => 2 * x;
            int res = delegate2(10);
            Console.WriteLine(res);


            //Action Delegate
            Action<string> myAction = y => Console.WriteLine(y);
            myAction("Rohitha");

            //Predicate Delegate
            Predicate<string> pred = x => x.Length < 5;
            //Console.WriteLine(pred("Anuradha"));
            var list = new List<string> { "rohi", "chennarohitha"};
            Console.WriteLine(list.Find(pred));

            //'yield' Keyword
            fillValues();
            foreach(int i in ExOfYield())
            {
                Console.WriteLine(i);

            }
  
        }

        static IEnumerable<int> ExOfYield() 
        {
            foreach(int i in myList)
            {
                if (i > 2)
                    yield return i;
            }
        }





    }
}
