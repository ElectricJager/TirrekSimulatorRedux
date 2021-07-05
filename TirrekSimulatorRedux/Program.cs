//This file is part of Tirrek Simulator Redux.

//    Tirrek Simulator Redux is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.

//    Tirrek Simulator Redux is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.

//    You should have received a copy of the GNU General Public License
//    along with Tirrek Simulator Redux.  If not, see <https://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TirrekSimulatorRedux
{
    static class Program
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

        public class Walk
        {
            public void Start()
            {

            }
        }
        public class Check
        {
            public void NewDay()
            {
                Stats.hunger--;
                Stats.thirst--;
                Status();
            }
            public void Status()
            {
                Health();
                Hunger();
                Thirst();
            }
            void Health()
            {
                if (Stats.health <= 0)
                {
                    Death(0);
                }
                if (Stats.health > Stats.maxHealth)
                {
                    Stats.health = Stats.maxHealth;
                }
            }

            public bool Money(int price)
            {
                if (Stats.money < price)
                {
                    MessageBox.Show($"Amk fakiri sfdsjhguıdfehg\nParan: {Stats.money} TL Gereken: {price} TL", "Tirrek Simulator Redux");
                    return false;
                }
                Stats.money -= price;
                return true;
            }

            void Hunger()
            {
                if (Stats.hunger <= 0)
                    Death(1);
            }

            void Thirst()
            {
                if (Stats.thirst <= 0)
                    Death(2);
            }

            public void Death(int reason)
            {
                string x = "";
                switch (reason)
                {
                    case 0:
                        x = "Öldün";
                        break;
                    case 1:
                        x = "Açlıktan öldün";
                        break;
                    case 2:
                        x = "Susuzluktan öldün";
                        break;
                    default:
                        break;
                }
                MessageBox.Show($"{x} amk\n\nF\n\nÇımak için tamam'a bas", "Tirrek Simulator Redux");
                Application.Exit();
            }
        }
        public struct Stats
        {
            public static int health = 10, hunger = 11, thirst = 11, kekoluk = 0;
            internal static int maxHealth = 20, maxKekoluk = 100;
            public static double money = 5;
        }
    }
}
