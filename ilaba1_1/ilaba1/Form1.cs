using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using WeatherApp;
using DSapp;

namespace ilaba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_1(object sender, EventArgs e)
        {
            int R;
            try
            {
                R = int.Parse(this.txtlabel.Text);
            }
            catch (FormatException)
            {
                // сообщение об ошибке
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // а затем прерываем обработчик
            }
            var reb = new DSapp.DS.DS1();
            MessageBox.Show("\nДиаметр =", Convert.ToString(reb.D(R)));
        }

        private void button_2(object sender, EventArgs e)
        {
            int R;
            try
            {
                R = int.Parse(this.txtlabel.Text);
            }
            catch (FormatException)
            {
                // сообщение об ошибке
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // а затем прерываем обработчик
            }
            var reb = new DSapp.DS.DS1();
            MessageBox.Show(Convert.ToString(reb.S(R)));
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    public class Logic // класс где будем хранить логику
    {
        //...
    }
}
