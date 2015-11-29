using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoVarianceDelegate
{
    class CoVarianceDelegateExample
    {
        private delegate Animal MyDelegate(); // Our delegate returns an Animal which is the SuperClass of Dog

        static void Main(string[] args)
        {
            MyDelegate del = GetDog;
        }

        static Dog GetDog() // this is the method we point to, which its return type is derived from the delegate return type
        {
            return new Dog();
        }
    }


    class Animal
    {
        
    }

    class Dog : Animal //notice dog inherits from animal
    {
        
    }
}
