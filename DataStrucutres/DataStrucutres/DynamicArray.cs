using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStrucutres
{
    internal class DynamicArray<T> : IEnumerable<T>
    {
        private T[] basearr;
        private int len;
        private int size;
        public DynamicArray(int Arrsize) 
        {
            if ( Arrsize < 0)
            {
                throw new ArgumentException("Invaild index");
            }
            else
            {
                basearr = new T[Arrsize];
                len = 0;
                size = Arrsize;
            }
        }
        public void append(T item) 
        { 
            if (len+1 == size) { resize(); }
  
           basearr[len++] = item;
                
            
        }
        public T get(int index)
        {
            if (index > len)
            {
                throw new IndexOutOfRangeException();
            }
            return basearr[index];
        }

        public void clear() {  
            Array.Clear(basearr, 0, len); 
            len = 0;
        }

        public void remove(int index) {
            if (index > len)
            {
                throw new IndexOutOfRangeException();
            }
            basearr[index] = default(T); 
            len --;
        }
        public int length() 
        { 
            return len;
        }
        public void resize()
        {
            size = size * 2;
            T[] temp = new T[size];
            for (int i = 0; i < basearr.Length; i++)
            {
                temp[i] = basearr[i];
            }
            basearr = temp;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <len; i++) { yield return basearr[i];}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
