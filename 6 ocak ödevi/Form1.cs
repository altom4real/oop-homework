using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _6_ocak_ödevi
{
    public partial class Form1 : Form
    {
        Form3 Form3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            villigar villigar = new villigar();
            villigar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            skeleton skeleton = new skeleton();
            skeleton.Show();
        }
    }
}
