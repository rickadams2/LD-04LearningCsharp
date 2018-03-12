using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("a string");
            myStack.Push(34);
            myStack.Push(myStack);

            myStack.Pop();

            Stack<string> strStack = new Stack<string>();
            strStack.Push(" A string");
            strStack.Push(34); 
        }
    }
}
