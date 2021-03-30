using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;


// делегат для события -ссылка на обработчики + сигнатура для обработчиков-
//(тип возврата + список параметров)
// 
delegate void KeyHandler(object source, KeyEventArgs arg);

//  параметры для обработчиков  
class KeyEventArgs : EventArgs
{
    public char ch;
}

// класс события, связанного с нажатием клавиши на клавиатуре
class KeyEvent
{
    //  событие
    public event KeyHandler KeyPress;

    //  генерация события, связанного с нажатием клавиши
    public void OnKeyPress(char key)
    {
        KeyEventArgs k = new KeyEventArgs();
        if (KeyPress != null)
        {
            //  формирование аргумента для обработчиков
            k.ch = key;
            KeyPress(this, k);
        }
    }
}

/// <summary>
/// The 'ProcessKey' abstract class
/// </summary>
abstract class ProcessKey
{
    //  protected ProcessKey successor;
    //  public void SetSuccessor(ProcessKey successor)
    //  {
    //      this.successor = successor;
    //  }
    public abstract void keyhandler(object source, KeyEventArgs arg);
}
/// <summary> 
/// The 'ConcreteHandler1' class
/// </summary>
class ConcreteProcessKey1 : ProcessKey
{
    public override void keyhandler(object source, KeyEventArgs arg)
    {
        if (arg.ch >= 'a' && arg.ch <= 'z')
        {
            Console.WriteLine("Получено сообщение о нажатии клавиши: " + arg.ch);
            Console.WriteLine("{0} handled request {1}", this.GetType().Name, arg.ch);
        }
        //    else if (successor != null)
        //    {
        //       successor.keyhandler( source, arg);
        //    }
    }
}



/// <summary>
/// The 'ConcreteHandler2' class
/// </summary>
class ConcreteProcessKey2 : ProcessKey
{
    public override void keyhandler(object source, KeyEventArgs arg)
    {
        if (arg.ch >= 'а' && arg.ch <= 'я')
        {
            Console.WriteLine("Получено сообщение о нажатии клавиши: " + arg.ch);
            Console.WriteLine("{0} handled request {1}",
            this.GetType().Name, arg.ch);
        }
        //   else if (successor != null)
        //   {
        //       successor.keyhandler(source, arg);
        //   }
    }
}

/// <summary>
/// The 'ConcreteHandler3' class
/// </summary>
class ConcreteProcessKey3 : ProcessKey
{
    public override void keyhandler(object source, KeyEventArgs arg)
    {
        if (arg.ch >= '0' && arg.ch <= '9')
        {
            Console.WriteLine("Получено сообщение о нажатии клавиши: " + arg.ch);
            Console.WriteLine("{0} handled request {1}",
            this.GetType().Name, arg.ch);
        }
        //   else if (successor != null)
        //   {
        //      successor.keyhandler(source, arg);
        //   }
    }
}

//  класс, который принимает уведомление о нажатии клавиши (ожидает событие )
class CountKey
{
    public int count = 0;
    //  обработчик события
    public void keyhandler(object source, KeyEventArgs arg)
    {
        count++;
    }
}



class KeyEvent1
{
    public static void GG()
    {
        // создание объекта  класса события
        KeyEvent kevt = new KeyEvent();

        //  создание объекта класса, ожидающего событие 
        ProcessKey h1 = new ConcreteProcessKey1();
        ProcessKey h2 = new ConcreteProcessKey2();
        ProcessKey h3 = new ConcreteProcessKey3();

        //    h1.SetSuccessor(h2);
        //    h2.SetSuccessor(h3);

        //  создание объекта класса, ожидающего событие
        CountKey ck = new CountKey();


        //  формирование списка обработчиков для события
        kevt.KeyPress += new KeyHandler(h1.keyhandler);
        kevt.KeyPress += new KeyHandler(h2.keyhandler);
        kevt.KeyPress += new KeyHandler(h3.keyhandler);
        kevt.KeyPress += new KeyHandler(ck.keyhandler);


        char[] c = Test1.GlobalVar.ToCharArray();

        for (int i = 0; i < c.Length; i++)
        {
            
            //  генерация события
            kevt.OnKeyPress(c[i]);
        } 

        //    Console.ReadKey();


        Console.WriteLine("Было нажато " + ck.count + "  клавиш");
    }



}



static class Test1
    {
        private static string _globalVar;

        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
    }




