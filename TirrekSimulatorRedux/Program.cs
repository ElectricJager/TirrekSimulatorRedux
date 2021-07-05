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

            public void KekoSet()
            {
                if (Items.inventory["tracksuit"] && Items.inventory["shoes"] && Items.inventory["tesbih"] && Items.inventory["necklace"] && Stats.kekoSetComplete == false)
                {
                    Stats.kekoluk += 20;
                    Stats.kekoSetComplete = true;
                    MessageBox.Show("Keko market set tamamlandı!\n+20 kekoluk", "Tirrek Simulator Redux");
                }
            }

            public void CarSet()
            {
                if (Items.inventory["tofas"] && Items.inventory["bmw"] && Stats.carSetComplete == false)
                {
                    Stats.kekoluk += 40;
                    Stats.carSetComplete = true;
                    MessageBox.Show("Araba seti tamamlandı!\n+40 kekoluk", "Tirrek Simulator Redux");
                }
            }
            public void KnifeSet()
            {
                if (Items.inventory["flip"] && Items.inventory["butterfly"] && Stats.knifeSetComplete == false)
                {
                    Stats.kekoluk += 15;
                    Stats.knifeSetComplete = true;
                    MessageBox.Show("Bıçak seti tamamlandı!\n+15 kekoluk", "Tirrek Simulator Redux");
                }
            }
        }
        public struct Stats
        {
            public static int health = 10, hunger = 11, thirst = 11, kekoluk = 0;
            internal static int maxHealth = 20, maxKekoluk = 100;
            public static double money = 50000;
            public static bool kekoSetComplete, carSetComplete, knifeSetComplete, flipCaught, butterflyCaught;
        }
        public class Items
        {
            public static Dictionary<string, bool> inventory = new Dictionary<string, bool>()
            {
                {"tracksuit", false},
                {"shoes", false},
                {"tesbih", false},
                {"necklace", false},
                {"tofas", false},
                {"bmw", false},
                {"flip", false},
                {"butterfly", false}
            };
        }
    }
}
