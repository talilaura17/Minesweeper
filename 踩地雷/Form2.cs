using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 踩地雷
{
    public partial class Form2 : Form
    {
        string name;
        public Form2()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            { 
                name = textBox1.Text;
                Class1 ouo = new Class1();
                ouo.changename(name);
                Form3 f3 = new Form3();
                f3.Show();
                this.Close();
            }
        }
    }
}
