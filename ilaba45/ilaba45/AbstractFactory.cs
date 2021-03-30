using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilaba45
{
    // "AbstractFactory" 

    public abstract class AbstractFactory
    {
        public abstract AbstractProperties CreateProperties();
        public abstract Form CreateWindow(AbstractProperties abstractProperties);
    }

    // "ConcreteFactory1" 

    public class Form2 : AbstractFactory
    {
        public override Form CreateWindow(AbstractProperties abstractProperties)
        {
            return new Form_2(abstractProperties);
        }

        public override AbstractProperties CreateProperties()
        {
            return new PropertiesForm2();
        }

    }

    // "ConcreteFactory2" 

    public class Form3 : AbstractFactory
    {
        public override Form CreateWindow(AbstractProperties abstractProperties)
        {
            return new Form_3(abstractProperties);
        }

        public override AbstractProperties CreateProperties()
        {
            return new PropertiesForm3();
        }
    }

    class Client
    {
        private Form avia;
        private AbstractProperties properties;

        public Client(AbstractFactory factory)
        {
            properties = factory.CreateProperties();
            avia = factory.CreateWindow(properties);
        }

        public void Run()
        {
            avia.ShowDialog();
        }
    }
}