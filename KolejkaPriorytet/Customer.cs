using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolejkaPriorytet
{
    class Customer
    {
        private String name;
        private int priority;

        public int Priority { get { return priority; } }
        public Customer(String n, int p)
        {
            name = n;
            priority = p;
        }

        public override string ToString()
        {
            return $"{name} - {priority}";
        }

    }
}
