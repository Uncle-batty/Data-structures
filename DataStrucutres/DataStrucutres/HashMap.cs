using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutres
{
    internal class HashMap
    {
        private LinkedList<KeyValuePair<int, int>>[] Buckets;
        private int size;
        public HashMap(int size = 20) {
            this.size = size;
            Buckets = new LinkedList<KeyValuePair<int, int>>[size];
            for (int i = 0; i < size; i++) { Buckets[i]= new LinkedList<KeyValuePair<int, int>>();}
        }

        private int GetBucketIndex(int key)
        {
            int hashCode = key.GetHashCode();
            int index = Math.Abs(hashCode % size);
            return index;
        }
        public void Put(int key, int value)
        {
            int index = GetBucketIndex(key);
            var bucket = Buckets[index];

            foreach (var keyvalue in bucket)
            {
                if (keyvalue.Key == key)
                {
                    bucket.Remove(keyvalue);
                    break;
                }
            }
            bucket.AddLast(new KeyValuePair<int, int>(key, value));

        }

        public int Get(int key)
        {
            int index = GetBucketIndex(key);
            var bucket = Buckets[key];
            foreach (var keyvalue in bucket)
            {
                if (keyvalue.Key == key)
                {
                    return keyvalue.Value;
                }
            }
            return -1;
           
        }

        public void Remove(int key)
        {
            int index = GetBucketIndex(key);
            var bucket = Buckets[index];
            
            foreach (var keyvalue in bucket)
            {
                if (keyvalue.Key == key) { bucket.Remove(keyvalue); break;}
            }
        }
    }
    public class KEYVALUE
    {
        public int key { get; set; }
        public int value { get; set; }

        public KEYVALUE(int key, int value) 
        { 
          this.key = key;
          this.value = value;
        }
    }
}
