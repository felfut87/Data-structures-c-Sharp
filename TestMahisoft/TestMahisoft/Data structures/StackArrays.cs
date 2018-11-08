using System;

namespace TestMahisoft.Data_structures
{
    public class StackArrays<T>
    {
        T[] _items = new T[0];
        int size = 0;
        public void Push(T value)
        {
            if (size == _items.Length)
            {
                int newLenght = size == 0 ? 3 : size * 2;

                T[] newArray = new T[newLenght];
                _items.CopyTo(newArray, 0);
                _items = newArray;
            }
            size++;
            _items[size - 1] = value;


        }

        public T Pop()
        {
            T valuePopped;

            if (size == 0)
            {

                throw new ArgumentException("The stack is empty");
            }

            valuePopped = _items[size - 1];
            _items[size - 1] = default(T);
            size--;

            return valuePopped;
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new ArgumentException("The stack is empty");
            }

            return _items[size - 1];

        }
    }
}
