using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kDamageCalculator
{
    static public class calculations
    {

        static public double calculateWoundsCaused(Model first, Model second)
        {
            //weapon damage * Hit chance * wound chance * save chance
            double damage = first.getDamage();
            double hitChance = calculateBS(first.BSS);
                double woundChance = strToughConv(first.getGunStr(), second.toughS);
                double saveFail = calculateSave(second.getSave(first.getGunRend()));
            double shots = first.getShots();
            return damage * hitChance * woundChance * saveFail * shots;
            
        }

        //Converts save to percentage FAIL chance
        static public double calculateSave(int BS)
        {
            switch (BS)
            {
                case 1: return (1f / 6f); //1's always fail
                case 2: return(1f/6f);
                case 3: return (2f / 6f);
                case 4: return (3f / 6f);
                case 5: return (4f / 6f);
                case 6: return (5f / 6f);


            }
            return 1; //technically you could go up to 12+ saves which auto fail. Could also be an error if you get here but whatever for now
        }

        //Converts BS to percentage hit Chance
        static public double calculateBS(int BS)
        {
            switch (BS)
            {
                case 2: return (5f / 6f);
                case 3: return (4f / 6f);
                case 4: return (3f / 6f);
                case 5: return (2f / 6f);
                case 6: return (1f / 6f);
                    

            }
            //put a real error thing here of some kind.
            System.Console.WriteLine("Format of BS is incorrect. Please use a value 2-6");
            return 1;
        }

        //Returns Wound chance based off of Str/Tough wound chart
        static double strToughConv(int str, int tough)
        {
            //Order of if statements is important
            if(str == tough)
            {
                return (3f / 6f);
            }
            if(str >= tough * 2f)
            {
                return (5f / 6f);
            }
            if(str <= tough / 2f)
            {
                return (1f / 6f);
            }
            if(str > tough)
            {
                return (4f / 6f);
            }
            if(str < tough)
            {
                return (2f / 6f);
            }
            //if you are here something bad happened
            else
            { return 1; }

        }
    }
}
