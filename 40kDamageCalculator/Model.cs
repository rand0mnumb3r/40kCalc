using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kDamageCalculator
{
    public interface Model
    {
        int strr { get; set; }
        int WSS { get; set; }
        int BSS { get; set; }
        int toughS { get; set; }
        int getSave(int rend);
        int getGunStr();
        int getDamage();
        int getGunRend();
        int getShots();
        void addGun(int str, int rend, int shots, int damage, int range);
    }


}
