using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz2k
{
    class Order
    {
        public int id;
        public Person person;
        public Book book;
        public Order(int id)
        {
            this.id = id;
        }

    }
}
