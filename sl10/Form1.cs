using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace sl10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            piano.Facade.Operation4();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            piano.Facade.Operation3();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            piano.Facade.Operation2();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            piano.Facade.Operation1();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            piano.Facade.Operation5();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            piano.Facade.Operation6();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            piano.Facade.Operation7();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
