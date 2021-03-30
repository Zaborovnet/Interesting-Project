using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            listView1.View = View.LargeIcon;


            listView1.LargeImageList = imageList1;
            TreeNode selectedNode = e.Node;
            switch (selectedNode.Name)
            {
                case "Узел1":
                    listView1.Items.Add("Седлоносная жаба");
                    listView1.Items[0].ImageIndex = 0;
                    listView1.Items.Add("Восточноафриканский узкорот");
                    listView1.Items[1].ImageIndex = 1;
                    listView1.Items.Add("Лягушковидная жаба");
                    listView1.Items[2].ImageIndex = 2;
                    listView1.Items.Add("Тигровая лягушка");
                    listView1.Items[3].ImageIndex = 3;
                    listView1.Items.Add("Лягушка-голиаф");
                    listView1.Items[4].ImageIndex = 4;
                    break;

                case "Узел2":
                    listView1.Items.Add("Мраморная амбистома");
                    listView1.Items[0].ImageIndex = 5;
                    listView1.Items.Add("Угревидная амфиума");
                    listView1.Items[1].ImageIndex = 6;
                    listView1.Items.Add("Японская исполинская саламандра");
                    listView1.Items[2].ImageIndex = 7;
                    listView1.Items.Add("Огненная саламандра");
                    listView1.Items[3].ImageIndex = 8;
                    break;
                case "Узел3":
                    listView1.Items.Add("Цейлонский рыбозмей");
                    listView1.Items[0].ImageIndex = 9;
                    listView1.Items.Add("кольчатая червяга");
                    listView1.Items[1].ImageIndex = 10;
                    break;
            }
        }
    }
}
