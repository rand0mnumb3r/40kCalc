using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kDamageCalculator
{
    public class Gun : Weapon
    {
        public int damage { get; set; }
        public int str { get; set; }
        public int rate { get; set; }
        public int range { get; set; }
        public int rend;
        public Gun()
        {
            str = 0;
            rate = 0;
            range = 0;
            rend = 0;
            damage = 0;
        }

    }
}
