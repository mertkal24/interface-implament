using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace winCsGo
{
    class Famas : Weapon, IAtesEdilebileible
    {
        public string AtesEt()
        {
            return this.Name + "İle Ateş Edildi";
        }
    }
}
