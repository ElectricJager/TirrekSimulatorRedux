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

        public struct Stats
        {
            public static int health = 10, hunger = 11, thirst = 11, kekoluk = 0;
            internal static int maxHealth = 20, maxKekoluk = 100;
            public static double money = 5;
        }
    }
}
