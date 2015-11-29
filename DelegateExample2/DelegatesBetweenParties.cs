using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample2
{
    class DelegatesBetweenParties
    {
        /* Example 2 Interaction with Delegates
        

        */

        static void Main(string[] args)
        {
            TestClass testClass = new TestClass(); // newing up the test class
            testClass.LongForLoop(PrintInteration); //Passing the method as a delegate to the test class
        }

        static void PrintInteration(int i)
        {
            Console.WriteLine(i); // this will get called each loop iteration
        }
    }


    public class TestClass
    {
        public delegate void CallBack(int i); // declaring the delegate
        public void LongForLoop(CallBack obj) //passing the delegate as a parameter
        {
            for (int i = 0; i < 10000; i++)
            {
                obj(i); //invokeing the delegate
            }
        }
    }
}
