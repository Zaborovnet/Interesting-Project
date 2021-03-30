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

namespace ilaba9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var reb = new ilaba9.Programs();
            reb.plane1();
            Test4.GlobalVar = 0;

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (Test4.GlobalVar == 0)
            {
                MessageBox.Show("Самолёт ещё не взлетил", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Test1.GlobalVar = 2;
                var reb = new ilaba9.Programs();
                reb.plane2();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Test4.GlobalVar = Test4.GlobalVar + 1;
                Test1.GlobalVar = 1;
                var reb = new ilaba9.Programs();
                reb.plane2();



        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (Test4.GlobalVar == 0)
            {
                MessageBox.Show("Ещё не было ни одной команды, чтобы её отменять", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Test1.GlobalVar = 3;
                var reb = new ilaba9.Programs();
                reb.plane2();
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Test1.GlobalVar = 4;
            var reb = new ilaba9.Programs();
            reb.plane2();
        }
    }
}
