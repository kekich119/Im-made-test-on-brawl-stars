using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testPoBrawelStrars
{
    public partial class lutiyTest : Form
    {
        public lutiyTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            button1.Location = new Point(339, -7);
            label1.Text = ("кто это?");
            label2.Size = new Size(465, 300);
            label2.Location = new Point(225, 150);

            button2.Location = new Point(279, 458);
            button3.Location = new Point(596, 458);




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = ("НУ ПОДУМАЙ!!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ("ХАХ ЛОХ!!! НЕ ПРАВИЛЬНО!!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = ("УРАААА ТЫ ПРОШЁЛ ПЕРВЫЙ ЭТАП!!!");
            label3.Size = new Size(865, 300);
            label3.Location = new Point(41, 150);
            button2.Location = new Point(477, 469);
            button2.Size = new Size(10, 20);
            button3.Location = new Point(477, 469);
            button3.Size = new Size(10, 20);
            
           
        }
    }
}
