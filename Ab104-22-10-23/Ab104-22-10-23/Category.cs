using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_22_10_23
{
    internal class Category:BaseEntity
    {
        private static int _id = 0;

        public Category(string name)
        {
             Id = ++_id;
            Name = name;
        }
    }
}
