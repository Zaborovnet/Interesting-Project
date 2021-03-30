using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Management;
using OpenHardwareMonitor.Hardware;




namespace ilaba12
{
    public partial class Form1 : Form
    {
        string fullPath;
        public Form1()
        {
            InitializeComponent();
        }
        string t;
        private string tmpInfo = string.Empty;


        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            GetComponent("Win32_Processor", "Name");
            treeView1.Nodes.Add(Test1.GlobalVar, Test1.GlobalVar);
            treeView1.Nodes[Test1.GlobalVar].Nodes.Add(string.Empty);
            treeView1.Nodes[Test1.GlobalVar].Tag = t;




        }
        private static void GetComponent(string hwclass, string syntax)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                if (Convert.ToString(mj[syntax]) != "")
                    Test1.GlobalVar = (Convert.ToString(mj[syntax]));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int k;
            int y;
            // Ссылка на выбранный узел
            TreeNode selectedNode = e.Node;
            // полный путь к узлу
            fullPath = selectedNode.FullPath;

            DirectoryInfo di = new DirectoryInfo(fullPath);


            try
            {
                // Получение списка всех каталогов и файлов из выбранного каталога
            }
            catch
            {
                return;
            }

            k = Environment.ProcessorCount;

            k = k / 2;
            
            listView1.Items.Clear();

            Test2.GlobalVar = e.Node.Index+1;

            if (Test2.GlobalVar < k + 1)
            {

                {
                    y = Test2.GlobalVar;
                    ListViewItem lvi = new ListViewItem(Convert.ToString(y));
                    Test2.GlobalVar = k + Test2.GlobalVar;
                    GetCPUTemperture();

                    lvi.SubItems.Add(Test3.GlobalVar);


                    listView1.Items.Add(lvi);
                }
            }

            else
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(Test2.GlobalVar));
                GetCPUTemperture();
                lvi.SubItems.Add(Test3.GlobalVar);


                listView1.Items.Add(lvi);
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

        static class Test2
        {
            private static int _globalVar;

            public static int GlobalVar
            {
                get { return _globalVar; }
                set { _globalVar = value; }
            }
        }

        static class Test3
        {
            private static string _globalVar;

            public static string GlobalVar
            {
                get { return _globalVar; }
                set { _globalVar = value; }
            }
        }


        class Visitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }

            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();

                foreach (IHardware hw in hardware.SubHardware)
                {
                    hw.Accept(this);
                }
            }

            public void VisitParameter(IParameter parameter)
            {

            }

            public void VisitSensor(ISensor sensor)
            {

            }
        }


        private void GetCPUTemperture()
        {
            tmpInfo = string.Empty;
            int k = 0;
            Visitor visitor = new Visitor();

            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.Accept(visitor);

            for(int i =0; i< computer.Hardware.Length; i++)
            {
                if(computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j=0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType ==SensorType.Temperature)
                        {
                            tmpInfo = computer.Hardware[i].Sensors[Test2.GlobalVar].Value.ToString();
                        }
                    }
                }
            }


            richTextBox1.Text = tmpInfo;
            Test3.GlobalVar= tmpInfo;
            computer.Close();
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
            {
                treeView1.BeginUpdate();

                if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == string.Empty)
                {
                    e.Node.Nodes.Clear();

                    for (int i = 1; i < Environment.ProcessorCount + 1; i++)
                    {
                        e.Node.Nodes.Add("Ядро " + i, "Ядро " + i);
                        e.Node.Nodes["Ядро " + i].Tag = i;
                    }


                }
                treeView1.EndUpdate();
            }

            private void listView1_ItemActivate(object sender, EventArgs e)
            {
                foreach (ListViewItem lvi in listView1.SelectedItems)
                {
                    string ext = Path.GetExtension(lvi.Text).ToLower();
                    if (ext == ".txt" || ext == ".htm" || ext == ".htm1")
                    {
                        try
                        {
                            richTextBox1.LoadFile(Path.Combine(Convert.ToString(Environment.ProcessorCount), lvi.Text),
                                RichTextBoxStreamType.PlainText);

                        }

                        catch
                        {
                            return;
                        }

                    }
                    else if (ext == ".rtf")
                    {
                        try
                        {
                            richTextBox1.LoadFile(Path.Combine(Convert.ToString(Environment.ProcessorCount), lvi.Text),
                                RichTextBoxStreamType.RichText);
                        }

                        catch
                        {
                            return;
                        }

                    }
                }
            }

            private void richTextBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(100);
                GetCPUTemperture();
            }
        }
    }
    }

