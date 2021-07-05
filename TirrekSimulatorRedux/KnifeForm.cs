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
    public partial class KnifeForm : Form
    {
        public KnifeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            if (random.Next(0, 6) == 0)
                Caught();
            else
            {
                MessageBox.Show("Polisten kaçmayı başardın", "Tirrek Simulator Redux");
                Close();
            }
        }

        void Caught()
        {
            MessageBox.Show("Polis seni yakaladı\nBıçaklarına ve 100 lirana el konuldu", "Tirrek Simulator Redux");
            if (Program.Items.inventory["butterfly"] == true)
                Program.Stats.butterflyCaught = true;
            if (Program.Items.inventory["flip"] == true)
                Program.Stats.flipCaught = true;
            Program.Items.inventory["flip"] = false;
            Program.Items.inventory["butterfly"] = false;
            Program.Stats.money -= 100;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Caught();
        }
    }
}
