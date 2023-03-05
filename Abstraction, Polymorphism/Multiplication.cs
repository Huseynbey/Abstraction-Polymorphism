using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction__Polymorphism
{
    sealed class Multiplication : Calculation
    {
        public override int Operate(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"first number = {a}, second number = {b}. Result = {result}");
            return result;
        }

    }
}

