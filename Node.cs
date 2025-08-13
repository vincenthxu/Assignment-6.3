using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._3
{
    public class Node<T>(T data)
    {
        public T? Value { get; set; } = data;
        public Node<T>? Previous { get; set; }
        public Node<T>? Next { get; set; }
        public override string? ToString() => Value?.ToString();
    }
}
