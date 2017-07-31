using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40kDamageCalculator
{
    public class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());




        }
        
    }
    partial class Form1
    {
        
        public void calculateDamageButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                Infantry dude1 = new Infantry(Convert.ToInt32(moveBox.Text), Convert.ToInt32(WSBox.Text), Convert.ToInt32(BSBox.Text), Convert.ToInt32(strBox.Text), Convert.ToInt32(toughBox.Text), Convert.ToInt32(woundBox.Text), Convert.ToInt32(saveBox.Text), Convert.ToInt32(attackBox.Text), Convert.ToInt32(pointBox.Text));
                Infantry dude2 = new Infantry(Convert.ToInt32(moveBox2.Text), Convert.ToInt32(WSBox2.Text), Convert.ToInt32(BSBox2.Text), Convert.ToInt32(strBox2.Text), Convert.ToInt32(toughBox2.Text), Convert.ToInt32(woundBox2.Text), Convert.ToInt32(saveBox2.Text), Convert.ToInt32(attackBox2.Text), Convert.ToInt32(pointBox2.Text));
                dude1.addGun(Convert.ToInt32(gunS.Text), Convert.ToInt32(gunRend.Text), Convert.ToInt32(gunShot.Text), Convert.ToInt32(gunDamage.Text), Convert.ToInt32(gunRange.Text));
                dude2.addGun(Convert.ToInt32(gunS2.Text), Convert.ToInt32(gunRend2.Text), Convert.ToInt32(gunShot2.Text), Convert.ToInt32(gunDamage2.Text), Convert.ToInt32(gunRange2.Text));
                woundCaused.Text = Convert.ToString(calculations.calculateWoundsCaused(dude1, dude2));
            }
            catch (Exception t)
            {
                Console.WriteLine("{0} Exception caught.", t);

            }
        }
        public void presetMarine()
        {
            meleeDamage.Text = "1";
            meleeDamage2.Text = "1";
            gunRange2.Text = "24";
            gunDamage2.Text = "1";
            gunRange.Text = "24";
            gunDamage.Text = "1";
            pointBox2.Text = "13";
            pointBox.Text = "13";
            meleeMult2.Text = "1";
            meleeRend2.Text = "0";
            meleeS2.Text = "4";
            gunShot2.Text = "2";
            gunRend2.Text = "0";
            gunS2.Text = "4";
            saveBox2.Text = "3";
            attackBox2.Text = "1";
            woundBox2.Text = "1";
            toughBox2.Text = "4";
            strBox2.Text = "4";
            BSBox2.Text = "3";
            WSBox2.Text = "3";
            moveBox2.Text = "6";
            meleeMult.Text = "1";
            meleeRend.Text = "0";
            meleeS.Text = "4";
            gunShot.Text = "2";
            gunRend.Text = "0";
            gunS.Text = "4";
            saveBox.Text = "3";
            attackBox.Text = "1";
            woundBox.Text = "1";
            toughBox.Text = "4";
            strBox.Text = "4";
            BSBox.Text = "3";
            WSBox.Text = "3";
            moveBox.Text = "6";
        }
    }
}
