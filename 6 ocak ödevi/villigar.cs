using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_ocak_ödevi
{
    public partial class villigar : Form
    {
        public villigar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(@"C:\Users\ahmet\OneDrive\Masaüstü\ödevke 2\Y2Mate.is - Villager Walking -  Minecraft Animation-QAcFD21wPGI-720p-1655584714132.mp4"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(@"C:\Users\ahmet\OneDrive\Masaüstü\ödevke 2\videoplayback.mp4"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this creature cant hit");
        }

        private void villigar_Load(object sender, EventArgs e)
        {
            vlcControl1.Visible = false;
        }
    }
}
