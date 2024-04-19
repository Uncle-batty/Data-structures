using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutres
{
    public class MyHashSet
    {

        private bool[] data = new bool[1000001];
        const int size = 1000001;
        public MyHashSet()
        {
             
    }

    public int getindex(string i)
    {
        int hash = 0;
            foreach (char c in i)
        {
            hash = (hash * 31 + c) % size;
        }
        return hash;
    }

    public int getindex(int i)
    {
        int hash = i % size;


        return hash;
    }
    public void Add(string key)
    {
        int key1 = getindex(key);
        data[key1] = true;
    }
    public void Add(int key)
        {
            key = getindex(key);
            data[key] = true;
        }

        public void Remove(int key)
    {
        data[key] = false;
    }

        public void Remove(string key)
        {
            int key1 = getindex(key);
            data[key1] = false;
        }


        public bool Contains(int key)
    {
            int key1 = getindex(key);
            return data[key1];
    }
        public bool Contains(string key)
        {
            int key1 = getindex(key);
            return data[key1];
        }
    }
}
