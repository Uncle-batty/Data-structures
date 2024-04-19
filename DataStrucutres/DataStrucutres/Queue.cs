using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutres
{
    internal class Queue<T>
    {
        List<T> list;
        private int head;
        private int tail;
        public Queue()
        {
            list = new List<T>();
            head = 0;
            tail = 0;
        }

        public void enqueue(T val)
        {
            tail= tail + 1;
            list.Add(val);
        }

        public T dequeue() 
        {
            if(isEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            T DEITEM = list[head];
            list.RemoveAt(head);
            tail--;
           
            return DEITEM;
        }

        public bool isEmpty()
        {
            return list.Count == 0;
        }

        public T getHead() {
            if (isEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return list[head]; 
        
        }
    }
}
