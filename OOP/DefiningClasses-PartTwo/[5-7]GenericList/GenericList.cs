using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7_GenericList
{
    public class GenericList<T>
    {
        const int capacity = 10;

        private T[] elements;
        private int count = 0;

        //Constructors
        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        public GenericList()
            : this(capacity)
        {
        }

        //Propertys
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        //Methods
        public void Add(T element)
        {
            if (count == elements.Length)
            {
                AutoGrow();
            }
            this.elements[count] = element;
            count++;
        }

        private void AutoGrow()
        {
            T[] doubleElements = new T[2*elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                doubleElements[i] = elements[i];
            }
            elements=doubleElements;
        }

        public void Remove(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T[] newArray = new T[elements.Length - 1];
            for (int i = 0, j = 0; i < newArray.Length; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }
                newArray[i] = elements[j];
            }
            count--;
            elements = newArray;
        }

        public void Insert(T element,int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T[] newArray = new T[elements.Length + 1];
            for (int i = 0,j = 0 ; j < newArray.Length; i++,j++)
            {
                T temp = elements[i];
                if (i==index)
                {
                    j++;
                    newArray[i] = element;
                }
                newArray[j] = temp;
            }
            count++;
            elements = newArray;
        }

        public void Clear()
        {
            count = 0;
            elements = new T[capacity];
        }

        public void FindElement(T element, GenericList<T> elements)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Equals(element))
                {
                    Console.WriteLine("The element is at index:{0}",i);
                    return;
                }
            }
            Console.WriteLine("No such element!");
        }

        //Override 
        public override string ToString()
        {
            StringBuilder console = new StringBuilder();
            for (int i = 0; i < elements.Length; i++)
            {
                console.Append(elements[i]);
                console.Append(" ");
            }
            return console.ToString();
        }
    }
}
