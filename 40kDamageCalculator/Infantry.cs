using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kDamageCalculator
{
    public class Infantry : Model
    {
        int BS;
        int str;
        int tough;
        int WS;

        public int BSS
        {
            get { return BS; }
            set { BS = value; }
        }
        public int WSS
        {
            get { return WS; }
            set { WS = value; }
        }
        public int strr
        {
            get { return str; }
            set { str = value; }
        }
        public int toughS
        {
            get { return tough; }
            set { tough = value; }
        }
        public int move;
        public int save;
        public int wound;
        public int points;
        public int attack;

        Gun guntype;
        Melee meleetype;
        public Infantry(int move, int WS, int BS, int str, int tough, int wound, int save, int attack, int points)
        {
            this.WS = WS;
            this.BS = BS;
            this.str = str;
            this.tough = tough;
            this.wound = wound;
            this.save = save;
            this.move = move;
            this.points = points;
            this.attack = attack;
            guntype = new Gun();
            meleetype = new Melee();
            
        }
        public int getSave(int rend)
        {
            return save+rend;
        }
        public int getShots()
        {
            return guntype.rate;
        }
        public int getGunRend()
        {
            return guntype.rend;
        }
        public int getGunStr()
        {
            return guntype.str;
        }
        public int getDamage()
        {
            return guntype.damage;
        }
        public void addGun(int str, int rend, int shots, int damage, int range )
        {
            guntype.str = str;
            guntype.rend = rend;
            guntype.rate = shots;
            guntype.damage = damage;
            guntype.range = range;

        }
    }
}
