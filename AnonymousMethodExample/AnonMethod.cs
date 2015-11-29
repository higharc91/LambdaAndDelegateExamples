using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodExample
{
    class AnonMethod
    {
        //private delegate void CountId();
        private delegate void CountId(int x);

        static void Main(string[] args)
        {
            //CountId del = delegate //using the delegate keyword we are creating an anon function
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //};
            //del(); //calling the anon function


            //Here is an example when the function requires a parameter

            CountId del = delegate(int z)
            {
                for (int i = 0; i < z; i++)
                {
                    Console.WriteLine(i);
                }
            };
            del(10);
        }

        //static void TestFunction() //This is using a traditional function and how we would usually do it.
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
