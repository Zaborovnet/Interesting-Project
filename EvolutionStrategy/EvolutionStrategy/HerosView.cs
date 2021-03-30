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
    public partial class HerosView : Form
    {
        List<Models.HeroModel> parentsList;
        List<Models.HeroModel> childsList;

        int parentsCount;
        int childsCount;

        public HerosView()
        {
            InitializeComponent();
        }

        public HerosView(List<Models.HeroModel> heroList, int parentsCount, int childsCount)
        {
            InitializeComponent();
            this.parentsList = heroList;
            this.parentsCount = parentsCount;
            this.childsCount = childsCount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Hide();
            Controller.SetResultPowers(this.parentsList);
            Controller.DrawParents(this, this.parentsList);

            this.label1.Text = "Вот ваши герои. Хотите посмотреть, во что они эволюционируют?";
            this.Controls.Add(new Button()
            {
                Name = "button2",
                Location = new Point(200, 220),
                ForeColor = this.button1.ForeColor,
                Font = this.button1.Font,
                BackColor = this.button1.BackColor,
                Size = this.button1.Size,
                Text = this.button1.Text,
            });
            this.Controls["button2"].Click += (sender_, e_) => {
                this.Controls["button2"].Hide();
                this.childsList = Controller.Evolve(this.parentsList, childsCount);
                Controller.SetResultPowers(childsList);
                Controller.DrawChilds(this, childsList, parentsList);
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputView nextForm = new InputView();

            this.Controls.Clear();
            this.Hide();
            nextForm.Show();
        }
    }
}
