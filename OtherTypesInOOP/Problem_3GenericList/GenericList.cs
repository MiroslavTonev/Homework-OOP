using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3GenericList
{
    public class GenericList<T> where T : IComparable<T>
    {
        private T[] elements;
        private const int DefautLenght = 1;
        int count = 0;

        public GenericList(int capacity = DefautLenght)
        {
            this.elements = new T[capacity];
        }
        
        public void Add(T element)
        {
            this.elements[count] = element;
            this.count++;
            if(count == elements.Length)
            {
                T[] newArray = new T[elements.Length * 2];                  
                Array.Copy(elements, newArray, count);
                elements = newArray;
            }
        } 
        public void Remove(int position)
        {

            if (position >= elements.Length || position < 0)
            {
                throw new ArgumentException("Invalid Position");
            }
            else
            {
                T[] newArr = new T[this.count];
                Array.Copy(elements, newArr, position);
                Array.Copy(elements, position + 1, newArr, position, this.elements.Length - position - 1);
                this.elements = newArr;
                count--;
            }       
        }  
        public void InsertElement(T element, int position)
        {
            if(position >= elements.Length || position < 0)
            {
                throw new ArgumentException("Invalid Position");
            }
            else
            {
                count++;
                T[] newArray = new T[elements.Length + 1];
                Array.Copy(elements, newArray, position);
                newArray[position] = element;
                Array.Copy(elements, position, newArray, position + 1, this.elements.Length - 1 - position);
                elements = newArray;
            }          
        }
        public void Clear()
        {
            count = 0;
            elements = new T[DefautLenght];
        }
        public int IndexOF(T element)
        {
            for(int i = 0; i < elements.Length; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }              
            }
            return -1;
        }
        public bool Contain(T element)
        {
            bool IsContain = false;
            for(int i = 0; i < elements.Length; i++)
            {
                if(this.elements[i].Equals(element))
                {
                    IsContain = true;
                    break;
                }                
            }
            return IsContain;
        }

        public T Min()
        {
            return elements.Min();        
        }

        public T Max()
        {
            return elements.Max();
        }

        public override string ToString()
        {
            return string.Join(", ", elements).ToString();
        }

    }
}
