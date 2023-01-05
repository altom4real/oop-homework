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
    public partial class skeleton : Form
    {
        public skeleton()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(@"C:\Users\ahmet\OneDrive\Masaüstü\ödevke 2\iskelet yürüme.mp4"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(@"C:\Users\ahmet\OneDrive\Masaüstü\ödevke 2\iskelet yürümeeee.mp4"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this creature cant speak");
        }

        private void skeleton_Load(object sender, EventArgs e)
        {
            vlcControl1.Visible = false;
        }
    }
}
