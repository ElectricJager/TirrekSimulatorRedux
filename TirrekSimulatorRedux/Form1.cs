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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TirrekSimulatorRedux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var check = new Program.Check();
            InitializeComponent();
            check.NewDay();
            money.Text = $"Paran: {Program.Stats.money} TL Kekoluk Levelin: {Program.Stats.kekoluk}";
            health.Text = $"Can Puanı: {Program.Stats.health}/{Program.Stats.maxHealth}";
            hunger.Text = $"Açlık: {Program.Stats.hunger}";
            thirst.Text = $"Susuzluk: {Program.Stats.thirst}";
        }

        void UpdateStats()
        {
            money.Text = $"Paran: {Program.Stats.money} TL Kekoluk Levelin: {Program.Stats.kekoluk}";
            health.Text = $"Can Puanı: {Program.Stats.health}/{Program.Stats.maxHealth}";
            hunger.Text = $"Açlık: {Program.Stats.hunger}";
            thirst.Text = $"Susuzluk: {Program.Stats.thirst}";
            money.Refresh();
            health.Refresh();
            hunger.Refresh();
            thirst.Refresh();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ElectricJager/TirrekSimulatorRedux");
        }

        private void walk_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            var walkForm = new WalkForm();
            walkForm.ShowDialog();
            check.NewDay();
            UpdateStats();
        }

        private void donerBuy_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            if (check.Money(6))
            {
                Program.Stats.hunger += 2;
                Program.Stats.health += 1;
            }
            check.Status();
            UpdateStats();
        }

        private void ayranBuy_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            if (check.Money(6))
            {
                Program.Stats.thirst += 2;
                Program.Stats.health += 1;
            }
            check.Status();
            UpdateStats();
        }

        private void topkekBuy_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            if (check.Money(3))
            {
                Program.Stats.hunger++;
            }
            check.Status();
            UpdateStats();
        }

        private void waterBuy_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            if (check.Money(3))
            {
                Program.Stats.thirst++;
            }
            check.Status();
            UpdateStats();
        }

        private void Squat_Click(object sender, EventArgs e)
        {
            Program.Stats.health++;
            var check = new Program.Check();
            check.NewDay();
            UpdateStats();
            check.Status();
        }
    }
}
