using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using WMPLib;
using System.IO;

namespace ilaba45
{
    public partial class Form1 : Form
    {
        static private Form1 form = new Form1();

        public Form1()
        {
            InitializeComponent();
        }
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        static public Form1 GetForm1
        {
            get
            {
                return form;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            AbstractFactory factory1 = new Form2();
            Client c = new Client(factory1);
            c.Run();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AbstractFactory factory1 = new Form3();
            Client c = new Client(factory1);
            c.Run();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Computer comp = new Computer();
            comp.Launch(numericUpDown1.Text);
            if(int.Parse(comp.OS.Name)==1){
                WMP.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Men I Trust - Show Me How.mp3");
                WMP.controls.play();
            }
            if (int.Parse(comp.OS.Name) == 2)
            {
                WMP.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Jocelyn Pook - Masked Ball.mp3");
                WMP.controls.play();
            }





            }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            WMP.controls.stop();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Mylibrary.Mylibrary.Text()); ;
        }
    }
}
