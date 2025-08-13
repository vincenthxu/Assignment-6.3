using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._3
{
    public class Queue<T>
    {
        private LinkedList<T> _queue = new();
        public int Length { get { return _queue.Size; } }
        public void Enqueue(T item) => _queue.AddLast(item);
        public Node<T>? Dequeue() => _queue.RemoveFirst();
        public void Display() => _queue.Display();
    }
}
