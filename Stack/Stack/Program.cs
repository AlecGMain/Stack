using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(2);
            stack.Push(4);
            stack.Pop();
            Console.WriteLine(stack.Peek());
            Console.ReadKey();
        }
    }
}