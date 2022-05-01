using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppForTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
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
