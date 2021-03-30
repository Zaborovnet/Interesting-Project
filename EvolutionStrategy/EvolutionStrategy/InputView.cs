using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolutionStrategy
{
    public partial class InputView : Form
    {
        List<Models.HeroModel> herosList;
        public InputView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Controller.IsInputValid(this))
            {
                this.label1.Text = "Введите корректные данные (μ должно быть не меньше l):";
            }
            else
            {
                int parentsCount = int.Parse(textBox1.Text);
                int childsCount = int.Parse(textBox2.Text);

                herosList = Controller.CreateHeroList(parentsCount);

                HerosView nextForm = new HerosView(herosList, parentsCount, childsCount);

                this.Hide();
                nextForm.Show();
                

            }
        }
    }
}
