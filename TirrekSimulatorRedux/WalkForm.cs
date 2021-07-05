using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TirrekSimulatorRedux
{
    public partial class WalkForm : Form
    {
        public WalkForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            if (rand.Next(0,2) == 0)
            {
                Program.Stats.money += 0.5;
                Close();
            }
            else
            {
                var choiceForm = new ChoiceForm();
                choiceForm.ShowDialog();
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            if (rand.Next(0, 6) == 0)
            {
                int x = rand.Next(5, 41);
                MessageBox.Show($"Adam korkup kaçtı\n{x} TL kazandın");
                Program.Stats.money += x;
                Close();
            }
            else
            {
                var fightForm = new FightForm();
                fightForm.ShowDialog();
                Close();
            }
        }
    }
}
