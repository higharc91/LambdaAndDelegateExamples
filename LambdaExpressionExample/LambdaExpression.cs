using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionExample
{
    class LambdaExpression
    {
        private delegate int CountIt(int x);

        private delegate void ShowNumber();
        static void Main(string[] args)
        {
            //This is the very explicit version of a lambda where the parameter list is made clear 
           // CountIt testDel = (int x) => x + 5; //to the left of the lambda is the parameter list, the right is the implementation and or body
            CountIt testDelTwo = x => x + 5; // this is an expression lambda, notice that there is no return statement as this is assumed
            int result = testDelTwo(5);

            CountIt testDelThreeStatement = x => //this is an statement lambda, here we can have multiple lines but must have a return statement
            {
                return x + 5;
            };

            ShowNumber noParamDel = () =>
            {
                //This is a void delegate statement without a return type (void)
            };
        }
    }
}
