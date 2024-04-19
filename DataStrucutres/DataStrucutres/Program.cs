using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> dynamicArray = new DynamicArray<int>(2);

            for (int i = 0; i < 10; i++)
            {
                dynamicArray.append(i);
            }

            Console.WriteLine(dynamicArray.get(3));
            Console.WriteLine(dynamicArray.length());
            dynamicArray.remove(3);
            Console.WriteLine(dynamicArray.length());
          
            

            foreach (int i in dynamicArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
