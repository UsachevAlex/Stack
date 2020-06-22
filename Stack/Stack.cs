using System;

namespace Stack
{
    public class Stack<T>
    {
        private T[] m;
        private int top = -1;
        
        public T Top { get => (top >= 0) ? m[top] : throw new StackEmptyException(); }
        public bool IsEmpty { get => (top == -1) ? true : false; }
        public int Count { get => top + 1; }

        public Stack(int length)
        {
            m = new T[length];
        }
        public void Push(T elem)
        {
            if (top + 1 < m.Length)
            {
                top++;
                m[top] = elem;
            }
            else
            {
                throw new StackOverflowException();
            }
        }
        public T Pop()
        {
            if (top >= 0)
            {
                T temp = m[top];
                top--;
                return temp;
            }
            else
            {
                throw new StackEmptyException();
            }
        }
        public void Clear()
        {
            top = -1;
        }
    }
    public class StackEmptyException : Exception
    {
        public StackEmptyException(string message = "Стек пуст!") : base(message)
        {
        }
    }
    public class StackOverflowException : Exception
    {
        public StackOverflowException(string message = "Стек переполнен!") : base(message)
        {
        }
    }
}
