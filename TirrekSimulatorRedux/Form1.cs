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
            var splashScreen = new SplashScreen();
            splashScreen.Show();
        }

        void UpdateStats()
        {
            if (Program.Items.inventory["tracksuit"] == true)
                tracksuitBuy.Text = "Alındı";
            if (Program.Items.inventory["shoes"] == true)
                shoeBuy.Text = "Alındı";
            if (Program.Items.inventory["tesbih"] == true)
                tesbihBuy.Text = "Alındı";
            if (Program.Items.inventory["necklace"] == true)
                necklaceBuy.Text = "Alındı";
            if (Program.Items.inventory["tofas"] == true)
                tofasBuy.Text = "Alındı";
            if (Program.Items.inventory["bmw"] == true)
                bmwBuy.Text = "Alındı";
            if (Program.Items.inventory["flip"] == true)
                flipBuy.Text = "Alındı";
            else
                flipBuy.Text = "Satın Al";
            if (Program.Items.inventory["butterfly"] == true)
                butterflyBuy.Text = "Alındı";
            else
                butterflyBuy.Text = "Satın Al";
            money.Text = $"Paran: {Program.Stats.money} TL Kekoluk Levelin: {Program.Stats.kekoluk}";
            health.Text = $"Can Puanı: {Program.Stats.health}/{Program.Stats.maxHealth}";
            hunger.Text = $"Açlık: {Program.Stats.hunger}";
            thirst.Text = $"Susuzluk: {Program.Stats.thirst}";
            money.Refresh();
            health.Refresh();
            hunger.Refresh();
            thirst.Refresh();
        }

        void AlreadyHaveMsg()
        {
            MessageBox.Show("Bundan sende zaten var", "Tirrek Simulator Redux");
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

        private void tracksuitBuy_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            if (check.Money(55))
            {
                if (Program.Items.inventory["tracksuit"] == false)
                {
                    Program.Items.inventory["tracksuit"] = true;
                    Program.Stats.kekoluk += 15;
                    check.KekoSet();
                    UpdateStats();
                }
                else
                    AlreadyHaveMsg();
            }
        }

        private void shoeBuy_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            if (check.Money(80))
            {
                if (Program.Items.inventory["shoes"] == false)
                {
                    Program.Items.inventory["shoes"] = true;
                    Program.Stats.kekoluk += 25;
                    check.KekoSet();
                    UpdateStats();
                }
                else
                    AlreadyHaveMsg();
            }
        }

        private void tesbihBuy_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            if (check.Money(5))
            {
                if (Program.Items.inventory["tesbih"] == false)
                {
                    Program.Items.inventory["tesbih"] = true;
                    Program.Stats.kekoluk += 3;
                    check.KekoSet();
                    UpdateStats();
                }
                else
                    AlreadyHaveMsg();
            }
        }

        private void necklaceBuy_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            if (check.Money(15))
            {
                if (Program.Items.inventory["necklace"] == false)
                {
                    Program.Items.inventory["necklace"] = true;
                    Program.Stats.kekoluk += 6;
                    check.KekoSet();
                    UpdateStats();
                }
                else
                    AlreadyHaveMsg();
            }
        }

        private void tofasBuy_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            if (check.Money(6000))
            {
                if (Program.Items.inventory["tofas"] == false)
                {
                    Program.Items.inventory["tofas"] = true;
                    Program.Stats.kekoluk += 35;
                    check.CarSet();
                    UpdateStats();
                }
                else
                    AlreadyHaveMsg();
            }
        }

        private void bmwBuy_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            if (check.Money(12000))
            {
                if (Program.Items.inventory["bmw"] == false)
                {
                    Program.Items.inventory["bmw"] = true;
                    Program.Stats.kekoluk += 60;
                    check.CarSet();
                    UpdateStats();
                }
                else
                    AlreadyHaveMsg();
            }
        }

        private void flipBuy_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            if (check.Money(15))
            {
                if (Program.Items.inventory["flip"] == false)
                {
                    Program.Items.inventory["flip"] = true;
                    if (!Program.Stats.flipCaught)
                        Program.Stats.kekoluk += 6;
                    check.KnifeSet();
                    UpdateStats();
                }
                else
                    AlreadyHaveMsg();
            }
        }

        private void butterflyBuy_Click(object sender, EventArgs e)
        {
            var check = new Program.Check();
            if (check.Money(100))
            {
                if (Program.Items.inventory["butterfly"] == false)
                {
                    Program.Items.inventory["butterfly"] = true;
                    if (!Program.Stats.butterflyCaught)
                        Program.Stats.kekoluk += 25;
                    check.KnifeSet();
                    UpdateStats();
                }
                else
                    AlreadyHaveMsg();
            }
        }
    }
}
