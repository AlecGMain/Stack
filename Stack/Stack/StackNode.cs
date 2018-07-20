using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class StackNode<T>
    {
        public T Value;
        public StackNode<T> Next;

        public StackNode(T value)
        {
            Value = value;
        }
        public StackNode()
        {

        }
    }
}
