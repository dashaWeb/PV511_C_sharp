using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Generic___Stack
{
    class MyStack<T> : IStack<T>, IEnumerable<T>
    {
        T[] stack;
        const int Empty = -1;
        int top = Empty;
        public int Capacity => stack.Length; // reserve

        public MyStack(int capacity = 5)
        {
            if (capacity < 0) capacity = 5;
            stack = new T[capacity];

        }
        public int Count => top + 1;

        public T Peek()
        {
            return stack[top];
        }

        public void Pop()
        {
            if (Count > 0)
                top--;
        }
        private bool Full()
        {
            return top == Capacity - 1;
        }
        public void Push(T elem)
        {
            if (Full())
                Array.Resize(ref stack, Count + 5); // grow 5
            stack[++top] = elem;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return stack.GetEnumerator();
        }
    }
}
