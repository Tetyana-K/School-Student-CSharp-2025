using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class
{
    internal class MyStack <T> : IEnumerable<T>, ICloneable
    {
        private T[] stack;
        public MyStack()
        {
            stack = new T[0];
        }
        private MyStack(T[] arr)
        {
            stack = arr;
        }
        public void Push(T elem)
        {
            Array.Resize(ref stack, stack.Length + 1);
            stack[stack.Length - 1] = elem;
        }
        public T Pop()
        {
            T tmp = stack[stack.Length - 1];
            Array.Resize(ref stack, stack.Length - 1);
            return tmp;
        }

        public T Peek()
        {
            return stack[stack.Length - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Length - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           // return stack.GetEnumerator();
            return GetEnumerator();
        }

        public object Clone()
        {
            T[] tmp = stack.Clone() as T[];
            Stack<T> st = new Stack<T>(tmp);
            
            return st;
        }

        public int Count => stack.Length;
    }
}
