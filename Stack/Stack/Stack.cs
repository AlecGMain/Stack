using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T>
    {
        public StackNode<T> Top;
        public int Count;
        public Stack(T Value)
        {
            Top = new StackNode<T>(Value);
            Count++;
        }
        public Stack()
        {

        }
        public void Push(T value)
        {
            if (Top == null)
            {
                Top = new StackNode<T>(value);
            }
            else
            {
                var newTop = new StackNode<T>(value);
                newTop.Next = Top;
                Top = newTop;
                Top.Value = value;
            }
            Count++;
        }
        public bool Pop()
        {
            if (Top == null)
            {
                return false;
            }
            else
            {
                Top = Top.Next;
                Count--;
                return true;
            }
        }
        public T Peek()
        {
            return Top.Value;
        }
        public bool IsEmpty()
        {
            return Top == null;
        }
        public void Clear()
        {
            Top = null;
        }

    }
}
