using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests
{
    internal class FibonacciSecuense : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            {
                int previous = 1;
                int current = 1;
                yield return 1;
                yield return 1;
                while (true)
                {
                    var newValue = current + previous;
                    previous = current;
                    current = newValue;
                    yield return current;
                }
            }
        }
    }
}
