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
    public partial class FightForm : Form
    {
        public FightForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int bias = Program.Stats.kekoluk / 5 + 50;
            if (random.Next(0, 101) < bias)
            {
                int x = random.Next(5, 50 + Program.Stats.kekoluk);
                MessageBox.Show($"{x} TL kazandın", "Tirrek Simulator Redux");
                Program.Stats.money += x;
                Close();
            }
            else
            {
                var check = new Program.Check();
                MessageBox.Show("Dayak yedin -2 Can", "Tirrek Simulator Redux");
                Program.Stats.health -= 2;
                check.Status();
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.Items.inventory["flip"] || Program.Items.inventory["butterfly"])
            {
                var random = new Random();
                if (random.Next(0, 3) == 0)
                {
                    var knifeForm = new KnifeForm();
                    knifeForm.ShowDialog();
                    Close();
                }
                else
                {
                    int x = random.Next(5, (51 + Program.Stats.kekoluk) * 2);
                    MessageBox.Show($"Adam korkup kaçtı\n{x} TL kazandın");
                    Program.Stats.money += x;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Bıçağın yok amk sakatı", "Tirrek Simulator Redux");
                Close();
            }
        }
    }
}
