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
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İyi çocuğun minibüs parasını alcak kadar düşmemişsin en azından", "Adamsın amk");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orospu çocu 50 kuruş için götünü de satarsın sen al bu 50 kuruşu götüne sok zehir zıkkım olsun piç", "Tam bi orospu çocuğusun");
            Program.Stats.money += 0.5;
            Close();
        }
    }
}
