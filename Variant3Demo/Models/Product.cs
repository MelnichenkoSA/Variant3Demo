using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant3Demo.Models
{
    internal class Product
    {
        public Product(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public string name {  get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return (name + " " + description);
        }
    }
}
