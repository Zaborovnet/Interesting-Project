using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilaba45
{
    // "AbstractProductB" 
    public abstract class AbstractProperties
    {
        public abstract string madeProperties();
    }

    // "ProductB1" 
    public class PropertiesForm2 : AbstractProperties
    {
        public override string madeProperties()
        {
            return
                    @"Двухфюзеляжный самолёт Stratolaunch Model 
351 (другое неофициальное название — Roc) имеет самый большой 
размах крыльев в истории авиации (117 м) и длину 73 м. 
Максимальный взлётный вес должен составить 590 тонн с весом 
подвесной полезной нагрузки 230 тонн. Самолёт оснащён шестью 
двухконтурными турбореактивными двигателями Pratt & Whitney 
PW4056 тягой по 25 тонн, снятыми со списанных лайнеров. Шасси 
самолета 28-колёсное, расчётная взлётная дистанция с полной 
нагрузкой составляет 3800 м. Максимальная дальность полёта 
самолёта с полной нагрузкой не превысит 3700 к";
        }
    }

    // "ProductB2" 
    public class PropertiesForm3 : AbstractProperties
    {
        public override string madeProperties()
        {

            return @"Ан-225 представляет собой шестимоторный
турбореактивный высокоплан со стреловидным крылом и двухкилевым
оперением. Оборудован шестью авиадвигателями Д-18Т производства
ОАО «Мотор Сич» разработки ЗМКБ «Прогресс» им. академика А. Г. 
Ивченко. 

Размеры грузовой кабины: длина — 43 м, ширина — 6,4 м, 
высота — 4,4 м. Грузовая кабина самолёта герметична, что 
значительно расширяет его транспортные возможности. Над грузовой 
кабиной на 2-й палубе — кабина для шести человек сменного экипажа
и 88 человек, сопровождающих груз. 
";
        }
    }
}
