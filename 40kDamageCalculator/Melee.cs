using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kDamageCalculator
{
    public class Melee : Weapon
    {
        int str { get; set; }
        int attackmult { get; set; }
        int rend { get; set; }

        public Melee()
        {
            str = 0;
            attackmult = 1;
            rend = 0;
        }
    }
}
