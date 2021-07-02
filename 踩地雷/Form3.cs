using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 踩地雷
{
    public partial class Form3 : Form
    {
        string[] s = new string[6];
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            const string FILE_NAME = "record.txt";
            if(!File.Exists(FILE_NAME))
            {
                MessageBox.Show("none");
                Console.ReadLine();
                return;
            }
            FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);

            using (StreamReader sr = new StreamReader(fs))
            {
                int x = 0;
                while (sr.Peek() >= 0)
                {
                    //Console.WriteLine(sr.ReadLine());
                    s[x] = sr.ReadLine();
                    x++;
                }
            }
            fs.Close();

            Console.ReadLine();

            label1.Text = s[0];
            label2.Text = s[1];
            label3.Text = s[2];
            label4.Text = s[3];
            label5.Text = s[4];
            label6.Text = s[5];
        }
    }
}
