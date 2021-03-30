using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionStrategy
{
    public class Models
    {
        public class HeroModel
        {
            public int intellegent;
            public int strength;
            public int agility;

            public HeroModel parent1;
            public HeroModel parent2;
            public string name;

            public int resultPower;

            public HeroModel()
            {

            }

            public HeroModel(int intellegent, int strength, int agility, string name)
            {
                this.intellegent = intellegent;
                this.strength = strength;
                this.agility = agility;

                this.name = name;
            }

            public HeroModel(int intellegent, int strength, int agility, HeroModel parent1, HeroModel parent2, string name)
            {
                this.intellegent = intellegent;
                this.strength = strength;
                this.agility = agility;

                this.parent1 = parent1;
                this.parent2 = parent2;
                this.name = name;
            }

        }
    }
}
