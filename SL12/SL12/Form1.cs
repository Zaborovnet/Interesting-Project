using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SL12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(Registry.ClassesRoot.Name, Registry.ClassesRoot.Name);
            treeView1.Nodes[Registry.ClassesRoot.Name].Nodes.Add(string.Empty);
            treeView1.Nodes[Registry.ClassesRoot.Name].Tag = Registry.ClassesRoot;

            treeView1.Nodes.Add(Registry.CurrentUser.Name, Registry.CurrentUser.Name);
            treeView1.Nodes[Registry.CurrentUser.Name].Nodes.Add(string.Empty);
            treeView1.Nodes[Registry.CurrentUser.Name].Tag = Registry.CurrentUser;

            treeView1.Nodes.Add(Registry.LocalMachine.Name, Registry.LocalMachine.Name);
            treeView1.Nodes[Registry.LocalMachine.Name].Nodes.Add(string.Empty);
            treeView1.Nodes[Registry.LocalMachine.Name].Tag = Registry.LocalMachine;

            treeView1.Nodes.Add(Registry.Users.Name, Registry.Users.Name);
            treeView1.Nodes[Registry.Users.Name].Nodes.Add(string.Empty);
            treeView1.Nodes[Registry.Users.Name].Tag = Registry.Users;

            treeView1.Nodes.Add(Registry.CurrentConfig.Name, Registry.CurrentConfig.Name);
            treeView1.Nodes[Registry.CurrentConfig.Name].Nodes.Add(string.Empty);
            treeView1.Nodes[Registry.CurrentConfig.Name].Tag = Registry.CurrentConfig;
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == string.Empty)
            {
                e.Node.Nodes.Clear();
                var key = e.Node.Tag as RegistryKey;
                if (key != null)
                {
                    foreach (string name in key.GetSubKeyNames())
                    {
                        e.Node.Nodes.Add(name, name);
                        if (name != "SECURITY" && name != "SAM")
                        {
                            RegistryKey subkey = key.OpenSubKey(name);
                            e.Node.Nodes[name].Tag = subkey;
                            if (subkey != null && subkey.SubKeyCount > 0)
                                e.Node.Nodes[name].Nodes.Add(string.Empty);
                        }
                    }
                }
            }
        }

        private void GetValuesAndData(RegistryKey registryKey)
        {
            dataGridView1.Rows.Clear();
            try
            {
                string[] values = registryKey.GetValueNames();
                foreach (string value in values)
                {
                    object data = registryKey.GetValue(value);
                    if ((string) data != string.Empty && value != string.Empty)
                        dataGridView1.Rows.Add(value, data);
                }
            }
            catch
            {
                
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var key = e.Node.Tag as RegistryKey;
            GetValuesAndData(key);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
