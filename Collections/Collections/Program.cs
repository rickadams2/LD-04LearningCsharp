using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non-generic Collections
            ArrayList arrList = new ArrayList();
            arrList.Add(12);
            arrList.Add("string");

            Stack myStack = new Stack();
            myStack.Push(32);
            myStack.Push("string");
            myStack.Peek();
            myStack.Pop(); 

            Queue myQueue = new Queue();
            myQueue.Enqueue(34);
            myQueue.Dequeue(); 
            SortedList srtList = new SortedList();
            srtList.Add(23);
            srtList.Add(1); 

            // Generic Collections
            Stack<int> intStack = new Stack<int>();
            Queue<char> charQ = new Queue<char>();
            SortedList<string, string> strList = new SortedList<string, string>();

        }
    }
}
