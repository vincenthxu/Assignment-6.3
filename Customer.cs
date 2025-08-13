using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment_6._3
{
    public class Customer
    {
        public string? Name { get; set; }
        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
