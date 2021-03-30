using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilaba10
{
    public partial class Form1 : Form
    {
        System.Drawing.Image b;
        public Form1()
        {
            InitializeComponent();

        }
        


        private void pictureBox1_Click(object sender, EventArgs e)
        {
   



            switch (Test1.GlobalVar)
            {
                case 1:
                    tic_tac_toe.Facade.Operation2();
                    pictureBox1.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
                case 0:
                    tic_tac_toe.Facade.Operation1();
                    pictureBox1.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switch (Test1.GlobalVar)
            {
                case 1:
                    tic_tac_toe.Facade.Operation2();
                    pictureBox2.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
                case 0:
                    tic_tac_toe.Facade.Operation1();
                    pictureBox2.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            switch (Test1.GlobalVar)
            {
                case 1:
                    tic_tac_toe.Facade.Operation2();
                    pictureBox3.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
                case 0:
                    tic_tac_toe.Facade.Operation1();
                    pictureBox3.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            switch (Test1.GlobalVar)
            {
                case 1:
                    tic_tac_toe.Facade.Operation2();
                    pictureBox6.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
                case 0:
                    tic_tac_toe.Facade.Operation1();
                    pictureBox6.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            switch (Test1.GlobalVar)
            {
                case 1:
                    tic_tac_toe.Facade.Operation2();
                    pictureBox5.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
                case 0:
                    tic_tac_toe.Facade.Operation1();
                    pictureBox5.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            switch (Test1.GlobalVar)
            {
                case 1:
                    tic_tac_toe.Facade.Operation2();
                    pictureBox4.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
                case 0:
                    tic_tac_toe.Facade.Operation1();
                    pictureBox4.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            switch (Test1.GlobalVar)
            {
                case 1:
                    tic_tac_toe.Facade.Operation2();
                    pictureBox9.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
                case 0:
                    tic_tac_toe.Facade.Operation1();
                    pictureBox9.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            switch (Test1.GlobalVar)
            {
                case 1:
                    tic_tac_toe.Facade.Operation2();
                    pictureBox8.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
                case 0:
                    tic_tac_toe.Facade.Operation1();
                    pictureBox8.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;

                    break;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            switch (Test1.GlobalVar)
            {
                case 1:
                    tic_tac_toe.Facade.Operation2();
                    pictureBox7.Image = Image.FromFile(Test2.GlobalVar);

                    label1.Text = Test3.GlobalVar;
                    break;
                case 0:
                    tic_tac_toe.Facade.Operation1();
                    pictureBox7.Image = Image.FromFile(Test2.GlobalVar);
                    label1.Text = Test3.GlobalVar;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test1.GlobalVar = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tic_tac_toe.Facade.Operation3();
            label1.Text = Test3.GlobalVar;
            pictureBox1.Image = Image.FromFile(Test2.GlobalVar);
            pictureBox2.Image = Image.FromFile(Test2.GlobalVar);
            pictureBox3.Image = Image.FromFile(Test2.GlobalVar);
            pictureBox4.Image = Image.FromFile(Test2.GlobalVar);
            pictureBox5.Image = Image.FromFile(Test2.GlobalVar);
            pictureBox6.Image = Image.FromFile(Test2.GlobalVar);
            pictureBox7.Image = Image.FromFile(Test2.GlobalVar);
            pictureBox8.Image = Image.FromFile(Test2.GlobalVar);
            pictureBox9.Image = Image.FromFile(Test2.GlobalVar);

        }
    }
    static class Test1
    {
        private static int _globalVar;

        public static int GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
    }
    static class Test2
    {
        private static string _globalVar;

        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
    }
    static class Test3
    {
        private static string _globalVar;

        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
    }
}
