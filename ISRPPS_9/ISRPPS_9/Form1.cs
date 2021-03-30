using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISRPPS_9
{
    public partial class Form1 : Form
    {
        private Calculator calculator = new Calculator();
        private List<Command> operations = new List<Command>();
        private int current = 0;
        public Form1()
        {
            InitializeComponent();
            this.comboBox1.Items.Add('+');
            this.comboBox1.Items.Add('-');
            this.comboBox1.Items.Add('*');
            this.comboBox1.Items.Add('/');
        }

        public void UpdateResult()
        {
            this.label1.Text = this.calculator.result.ToString(); 
        }

        public void Undo()
        {
            if(this.calculator.result > 0)
            {
                operations[--current].UnExecute();
                operations.RemoveAt(current);
                UpdateResult();
            }
        }

        public void Compute(char @operation, double operand)
        {
            Command command = new CalculatorCommand(calculator, @operation, operand);
            command.Execute();
            operations.Add(command);
            current++;
            UpdateResult();
        }

        private void button1_Click(object sender, EventArgs e)//ввод
        {
            Compute(Char.Parse(this.comboBox1.Text), Double.Parse(this.textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Undo();
        }
    }

    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }

    class CalculatorCommand : Command
    {
        char @operator;
        double operand;
        Calculator calculator;
        // Constructor
        public CalculatorCommand(Calculator calculator,
        char @operator, double operand)
        {
            this.calculator = calculator;
            this.@operator = @operator;
            this.operand = operand;
        }
        public char Operator
        {
            set
            {
                @operator = value;
            }
        }
        public int Operand
        {
            set
            {
                operand = value;
            }
        }
        public override void Execute()
        {
            calculator.Operation(@operator, operand);
        }
        public override void UnExecute()
        {
            calculator.Operation(Undo(@operator), operand);
        }
        // Private helper function : приватные вспомогательные функции
        private char Undo(char @operator)
        {
            char undo;
            switch (@operator)
            {

                case '+':
                    undo = '-';
                    break;
                case '-':
                    undo = '+';
                    break;
                case '*':
                    undo = '/';
                    break;
                case '/':
                    undo = '*';
                    break;
                default:
                    undo = ' ';
                    break;
            }
            return undo;
        }
    }

    public class Calculator
    {
        private double curr = 0;

        public double result
        {
            get
            {
                return curr;
            }
        }
        public void Operation(char @operator, double operand)
        {
            switch (@operator)
            {
                case '+':
                    curr += operand;
                    break;
                case '-':
                    curr -= operand;
                    break;
                case '*':
                    curr *= operand;
                    break;
                case '/':
                    curr /= operand;
                    break;
            }
        }
    }
}
