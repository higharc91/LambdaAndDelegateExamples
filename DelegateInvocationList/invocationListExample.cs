using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvocationList
{
    class InvocationListExample
    {
        private delegate void MyDelegate(string s);
        static void Main(string[] args)
        {
            MyDelegate del = TestFunctionMessage; //Here is the first assignment.
            del += TestFunctionMessage; //Notice the += addition assignment operator adding the TestFunctionMessage to the invoke list
            del("Hello World"); //This should display twice; once for each function in the list.

        }



        static void TestFunctionMessage(string text)
        {
            //This is the method that the delegate will point to
            Console.WriteLine(text);
        }
    }
}
