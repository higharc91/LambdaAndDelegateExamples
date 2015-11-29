using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    class EventsExample
    {
        static void Main(string[] args)
        {
            //now we will implement our class
            Person p = new Person();
            Person p2 = new Person();
            p2.cashEvent += P_cashEvent
            p.cashEvent += P_cashEvent; // here we are subscribing, this is the same as a delegate, we are assigning a method sig to invoke list
            p.AddCash(101);
        }

        private static void P_cashEvent()
        {
            //this is the method that we subscribed
            Console.WriteLine("Person has gained over 100 dollars");
        }
    }



    //My goal is to create an event to notify when my person receives 100 or goes over
    class Person
    {
        public delegate void MyEventHanlder(); //this is the creation of our delegate

        public event MyEventHanlder cashEvent; //this is the creation of our event which takes the return type of our delegate
        private int _cash;

        public int Cash
        {
            get { return _cash; }
            set
            {
                _cash = value;
                if (Cash >= 100)
                {
                    //let our subscribers know!
                    if (cashEvent != null) //if no subcribers, this event is null.. must check
                    {
                        cashEvent(); //this fires the actual event
                    }
                }
            }
        }

        public void AddCash(int amount)
        {
            Cash += amount;
        }
    }
}
