using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionStrategy
{
    class Controller
    {
        public static bool IsInputValid(InputView form)
        {
            int parents, childes;
            try
            {
                parents = int.Parse(form.Controls["textBox1"].Text);
                childes = int.Parse(form.Controls["textBox2"].Text);

                if (parents < childes)
                {
                    return false;
                }
                if (parents > 8)
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Models.HeroModel> CreateHeroList(int heroCount)
        {
            List<Models.HeroModel> heroList = new List<Models.HeroModel>();
            var rand = new Random();
            for (int i = 0; i < heroCount; i++)
            {
                heroList.Add(new Models.HeroModel(rand.Next(0, 11), rand.Next(0, 11), rand.Next(0, 11), "Герой " + i.ToString()));
            }

            return heroList;
        }

        public static void SetResultPowers(List<Models.HeroModel> heroList)
        {
            foreach (Models.HeroModel hero in heroList)
            {
                hero.resultPower = hero.intellegent * 5 + hero.agility * 2 + hero.strength * 3;
            }
        }

        public static void DrawParents(HerosView form, List<Models.HeroModel> heroList)
        {
            int i = 0;
            foreach (Models.HeroModel hero in heroList)
            {
                form.Controls.Add(new Label() {
                    Name = "heroTitle" + i.ToString(),
                    Location = new Point(13 + (600 / heroList.Count) * i, 80),
                    Text = hero.name + ":",
                    AutoSize = true,
                });
                form.Controls.Add(new Label()
                {
                    Name = "heroIntLabel" + i.ToString(),
                    Location = new Point(13 + (600 / heroList.Count) * i, 110),
                    Text = "Интеллект: " + hero.intellegent.ToString(),
                    AutoSize = true,
                });
                form.Controls.Add(new Label()
                {
                    Name = "heroStrLabel" + i.ToString(),
                    Location = new Point(13 + (600 / heroList.Count) * i, 130),
                    Text = "Сила: " + hero.strength.ToString(),
                    AutoSize = true,
                });
                form.Controls.Add(new Label()
                {
                    Name = "heroAgilLabel" + i.ToString(),
                    Location = new Point(13 + (600 / heroList.Count) * i, 150),
                    Text = "Ловкость: " + hero.agility.ToString(),
                    AutoSize = true,
                });
                form.Controls.Add(new Label()
                {
                    Name = "heroPwrLabel" + i.ToString(),
                    Location = new Point(13 + (600 / heroList.Count) * i, 180),
                    Text = "Итого: " + hero.resultPower.ToString(),
                    AutoSize = true,
                });
                i++;
            }
        }

        public static async void DrawChilds(HerosView form, List<Models.HeroModel> heroList , List<Models.HeroModel> parentsList)
        {
            int i = 0;
            foreach (Models.HeroModel hero in heroList)
            {
                form.Controls.Add(new Label()
                {
                    Name = "childTitle" + i.ToString(),
                    Location = new Point(13 + (600 / heroList.Count) * i, 240),
                    Text = "Ребенок " + i.ToString() + ":",
                    AutoSize = true,
                });
                form.Controls.Add(new Label()
                {
                    Name = "childIntLabel" + i.ToString(),
                    Location = new Point(13 + (600 / heroList.Count) * i, 270),
                    Text = "Интеллект: " + hero.intellegent.ToString(),
                    AutoSize = true,
                });
                form.Controls.Add(new Label()
                {
                    Name = "childStrLabel" + i.ToString(),
                    Location = new Point(13 + (600 / heroList.Count) * i, 290),
                    Text = "Сила: " + hero.strength.ToString(),
                    AutoSize = true,
                });
                form.Controls.Add(new Label()
                {
                    Name = "childAgilLabel" + i.ToString(),
                    Location = new Point(13 + (600 / heroList.Count) * i, 310),
                    Text = "Ловкость: " + hero.agility.ToString(),
                    AutoSize = true,
                });
                form.Controls.Add(new Label()
                {
                    Name = "childPwrLabel" + i.ToString(),
                    Location = new Point(13 + (600 / heroList.Count) * i, 330),
                    Text = "Итого: " + hero.resultPower.ToString(),
                    AutoSize = true,
                });
                form.Controls.Add(new Label()
                {
                    Name = "childPrntsLabel" + i.ToString(),
                    Location = new Point(13 + (600 / heroList.Count) * i, 360),
                    Text = "Родители:\n" + hero.parent1.name + " и " + hero.parent2.name,
                    AutoSize = true,
                });
                i++;
                await Task.Delay(1500);
            }

            form.label2.Text += Controller.FindMiddleResult(heroList) + " против " + Controller.FindMiddleResult(parentsList);
            form.label2.Visible = true;
            form.button3.Visible = true;
        }



        public static List<Models.HeroModel> Evolve(List<Models.HeroModel> parentList, int childsCount)
        {
            List<Models.HeroModel> childeList = new List<Models.HeroModel>();

            int newInt, newStr, newAgil, rand1, rand2;
            Models.HeroModel parent1, parent2;

            var rand = new Random();

            for (int i = 0; i < childsCount; i++)
            {
                rand1 = rand.Next(0, parentList.Count);
                rand2 = rand.Next(0, parentList.Count);

                if ((rand1 == rand2) && (rand2 == parentList.Count - 1))
                {
                    rand2--;
                }
                else if (rand1 == rand2)
                {
                    rand2++;
                }

                parent1 = parentList[rand1];
                parent2 = parentList[rand2];

                newInt = parent1.intellegent > parent2.intellegent ? parent1.intellegent : parent2.intellegent;
                newStr = parent1.strength > parent2.strength ? parent1.strength : parent2.strength;
                newAgil = parent1.agility > parent2.agility ? parent1.agility : parent2.agility;

                childeList.Add(new Models.HeroModel(newInt, newStr, newAgil, parent1, parent2, "Ребенок " + i.ToString()));
            }

            return childeList;
        }

        public static double FindMiddleResult(List<Models.HeroModel> heroList)
        {
            double result = 0.0;

            foreach (Models.HeroModel hero in heroList)
            {
                result += hero.resultPower;
            }

            result /= heroList.Count;

            return result;
        }
    }
}
