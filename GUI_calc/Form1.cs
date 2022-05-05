using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StandartCalc f2 = new StandartCalc();
            f2.Show();
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdvancedCalc f2 = new AdvancedCalc();
            f2.Show();
            
        }
    }
}
