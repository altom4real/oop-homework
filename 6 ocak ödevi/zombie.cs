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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
                vlcControl1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(@"C:\Users\ahmet\OneDrive\Masaüstü\ödevke 2\zombi ses.mp4"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(@"C:\Users\ahmet\OneDrive\Masaüstü\ödevke 2\ödev.mp4"));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(@"C:\Users\ahmet\OneDrive\Masaüstü\ödevke 2\zombi yürümee.mp4"));
        }
    }
}
