using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContraVarianceDelegate
{
    class ContraVarianceExample
    {
        private delegate void MyDelegate(Dog d); //notice here that my delegate uses the class dog as a parameter
        static void Main(string[] args)
        {
            MyDelegate tstDelegate = ExampleMethod;// The method below can be assigned becuase its parameter is the superclass of delegate parameter type
        }

        static void ExampleMethod(Animal a)
        {
            
        }
    }

    class Animal
    {
        
    }

    class Dog : Animal
    {
        
    }
}
