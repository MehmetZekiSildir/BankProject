using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik_40.ORM.Entities
{
    internal class İndivual:Customer
    {
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender{ get; set; }
        public string TC{ get; set; }

    }
}
