using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilaba45
{
    public partial class Form_2 : Form
    {
        private PropertiesForm2 propForm2;

        public Form_2(AbstractProperties abstractProperties)
        {
            propForm2 = (PropertiesForm2)abstractProperties;

            InitializeComponent();
        }

        private void Form_2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = propForm2.madeProperties();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }
    }
}
