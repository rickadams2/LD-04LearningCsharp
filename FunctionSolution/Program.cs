using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionSolution
{

    /*  A function what will nnot return na value. It accepts two integers 
     *  If adds the int into a sum 
     * The sum is outputed to the console windows 
     * 
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            Sum(32, 45); 
        }

        static void Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
            Console.ReadLine(); 
        }
    }
}
