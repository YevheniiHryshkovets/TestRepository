using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>();
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.EnQueue(4);

            foreach (var i in queue) { Console.WriteLine(i); }
            Console.ReadKey();

        }

         public static T GetMaxOrDefault<T>(T[] source)
            where T : IComparable, new()
         {
            if (source == null)
            {
                return default(T);
            }
            else
            {
                T max = new T();
                for (int i = 0; i < source.Length - 1; i++)
                {
                    if (source[i].CompareTo(source[i + 1]) < 0)
                    {
                        max = source[i + 1];
                    }
                }
                return max;
            }
         }

    }
}
