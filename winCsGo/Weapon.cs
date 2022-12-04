using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winCsGo
{
    abstract class Weapon
    {
        public string  Name { get; set; }
        public int AtisGucu { get; set; }
        public int AtisMesafesi { get; set;}
        public override string ToString()
        {
            return this.Name;
        }

    }
}
