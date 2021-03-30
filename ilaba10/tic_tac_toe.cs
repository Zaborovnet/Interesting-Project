using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilaba10
{
    class tic_tac_toe
    {
        internal class SubsystemA
        {
            internal void A1()
            {
                Test2.GlobalVar= "perfect-circle_icon-icons.com_53928.png";
                Test1.GlobalVar = 1;
                Test3.GlobalVar = "Сейчас ходят крестики";
            }
        }
        internal class SubsystemB
        {
            internal void B1()
            {
                Test2.GlobalVar = "1487086345-cross_81577.png";
                Test1.GlobalVar = 0;
                Test3.GlobalVar = "Сейчас ходят нолики";

            }
        }

        internal class SubsystemС
        {
            internal void С1()
            {
                Test2.GlobalVar = "squareroundedemptyoutlinedbuttonshape_80680.png";
                Test1.GlobalVar = 1;
                Test3.GlobalVar = "Сейчас ходят крестики";
            }
        }
        public static class Facade
        {
            static tic_tac_toe.SubsystemA a = new tic_tac_toe.SubsystemA();
            static tic_tac_toe.SubsystemB b = new tic_tac_toe.SubsystemB();
            static tic_tac_toe.SubsystemС с = new tic_tac_toe.SubsystemС();
            public static void Operation1()
            {

                a.A1();

            }
            public static void Operation2()

            {

                b.B1();

            }

            public static void Operation3()

            {

                с.С1();

            }
        }
    }
}
