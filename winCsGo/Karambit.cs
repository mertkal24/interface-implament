using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winCsGo
{
    class Karambit : Weapon, ISavurabileible
    {
        public string Savur()
        {
           return this.Name+"Savuruldu";
        }
    }
}
