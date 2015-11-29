using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample1
{
    class BasicDelegate
    {

        /*/////////////////Example 1 Function Pointer//////////// 
         *In this example I show the most basic use of a delegate
           Here I am just using a delegate as a funciton pointer.
        */

        public delegate void SomeMethodPointer(); //delcare my delegate object
        static void Main(string[] args)
        {
            SomeMethodPointer pointer = new SomeMethodPointer(SomeMethod); //pointing the delegate to the "Some Method"
            pointer.Invoke(); // Calling the method that the delegate is pointed to.

            //above is the old way.. here is the new
            SomeMethodPointer pointerTwo = SomeMethod; // this is much simpler way of method assignment 
        }

        static void SomeMethod()
        {
            
        }
    }
}
