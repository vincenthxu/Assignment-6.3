using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._3
{
    public class LinkedList<T>
    {
        #region Fields
        private Node<T>? head;
        private Node<T>? tail;
        private int size;
        #endregion

        #region Properties
        public int Size { get { return size; } }
        public bool IsEmpty { get { return size == 0; } }
        #endregion

        #region Constructors
        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }
        #endregion

        #region Methods
        public void AddLast(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (IsEmpty)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = tail.Next;
            }
            size++;
        }
        public Node<T>? RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Cannot remove nodes from an empty list!");
            else
            {
                Node<T>? current = head;

                head = head?.Next;
                size--;

                if (IsEmpty)
                    tail = null;

                return current;
            }
        }
        public void Display()
        {
            Node<T>? current = head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
            Console.WriteLine();
        }
        #endregion
    }
}
