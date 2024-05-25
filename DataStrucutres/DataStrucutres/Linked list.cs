using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutres
{
    public class Node
    {
        public int Value { get; set; }
        public Node next { get; internal set; }
        public Node(int val)
        {
            Value = val;

            next = null;
        }


    }

    public class MyLinkedList
    {
        public Node head;


        public MyLinkedList()
        {
            head = null;
        }

        public int Get(int index)
        {
            Node current = head;
            int i = 0;

            while (current != null)
            {
                if (i == index)
                {
                    return current.Value;
                }
                current = current.next;
                i++;
            }
            return -1;
        }

        public void AddAtHead(int val)
        {
            Node first = new Node(val);
            first.next = head;
            head = first;
        }

        public void AddAtTail(int val)
        {

            Node current = head;
            Node previous = null;

            while (current != null)
            {
                previous = current;
                current = current.next;
            }

            if (previous == null)
            {
                head = new Node(val);
            }
            else
            {
                previous.next = new Node(val);
            }
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            Node current = head;
            Node previous = null;
            int i = 0;

            while (current != null)
            {
                if (i == index)
                {
                    Node newitem = new Node(val);
                    newitem.next = current;
                    previous.next = newitem;

                }
                i++;
                previous = current;
                current = current.next;
            }
        }

        public void DeleteAtIndex(int index)
        {
            if (head == null)
            {
                return;
            }

            if (index == 0)
            {
                head = head.next;
                return;
            }

            Node current = head;
            Node previous = null;

            int i = 0;
            while (current != null)
            {
                if (i == index)
                {
                    previous.next = current.next;
                }
                i++;
                previous = current;
                current = current.next;
            }
        }
        public void ReverseList()
        {
            Node current = head;
            Node previous = null;

            while (current != null)
            {
                Node tempcur = current.next;
                current.next = previous;

                previous = current;
                current = tempcur;

            }
            head = previous;
        }
    }

}
