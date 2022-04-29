using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests
{
    internal class QueueItem<T>
    {
        public T Value { get; set; }
        public QueueItem<T> Next { get; set; }
    }

    public class Queue<T> : IEnumerable<T>
    {
        QueueItem<T> head;
        QueueItem<T> tail;

        public bool IsEmpty { get { return head == null; } }

        public void EnQueue(T value)
        {
            if (IsEmpty) { tail = head = new QueueItem<T> { Value = value, Next = null }; }
            else
            { 
                var item = new QueueItem<T> { Value = value, Next = null };
                tail.Next = item;
                tail = item;
            }

        }

        public T DeQueue(T value)
        {
            if (head == null) { throw new InvalidOperationException(); }
            var result = head.Value;
            head = head.Next;
            if(head == null) { tail = null; }
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new QueueEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        internal class QueueEnumerator : IEnumerator<T>
        {
            Queue<T> queue;
            QueueItem<T> item;

            public QueueEnumerator(Queue<T> queue)
            {
                this.queue = queue;
                item = null;
            }

            public T Current { get { return item.Value; } }

            public bool MoveNext()
            {
                if (item == null) { item = queue.head; }
                else { item = item.Next; }
                return item != null;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {

            }

            object IEnumerator.Current => throw new NotImplementedException();
        }

    }

}
