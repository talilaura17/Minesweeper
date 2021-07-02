using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace 踩地雷
{
    public partial class Form1 : Form
    {
        int gen = 1, rgen = 1;
        Button[] brick;
        int[] f;
        int[] rr;
        Random random = new Random();
        int z; //按到0
        bool gg = false;
        int t = 0,tt=0;
        int w1 = 0;
        int rrow,x,y,b;
        bool flag = false;
        string stime = "17";
        string[] ttt = new string[3];
        bool[] fflag;
        int firsttab=0;
        bool[] canit;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            res.BackgroundImage= Properties.Resources.smile;
            res.BackgroundImageLayout= ImageLayout.Stretch; 
            Re();
            Generate(10,10,100,10);
            timer1.Stop();
        }
        private void Re()
        {
            const string FILE_NAME = "record.txt";
            FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                for (int i = 0; i < 3; i++)
                {
                    ttt[i] = sr.ReadLine();
                    sr.ReadLine();
                }
            }
            fs.Close();
        }
        private void Generate(int row, int col, int totalnum, int bombnum)
        {
            rrow = row; x = col; y = totalnum; b = bombnum;
            //生成按鈕
            if (w1 == 0)
                {
                    brick = new Button[totalnum];
                    f = new int[totalnum];
                    
                    int qq = 0;
                    for (int c = 0; c < row; c++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            brick[qq] = new Button();
                            //brick[qq].Margin = new System.Windows.Forms.Padding(0);
                            brick[qq].Size = new System.Drawing.Size(30, 30);
                            brick[qq].Location = new System.Drawing.Point(30 * j + 4, 56 + 30 * c);
                            brick[qq].BringToFront();
                            this.Controls.Add(brick[qq]);
                            brick[qq].MouseDown += new MouseEventHandler(this.Buttons_Click);
                            qq++;
                        }
                    }
                res.Left = this.Width / 2 - 23;
                label1.Left = this.Width - 60;
                label2.Left = 10;
            }
                w1=1;
                int p=0;
                for (int c = 0; c < row; c++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        brick[p].BackgroundImage = null;
                        brick[p].Enabled = true;
                        f[p] = 17;
                        p++;
                    }
                }
                
        }
        private void FirstTab(int a,int row,int col,int totalnum,int bombnum)
        {
            //第一次按到出現一大塊
            //a為第一次按到的按鈕編號
            fflag = new bool[totalnum];
            canit = new bool[totalnum];
            for (int i=0;i<totalnum;i++)
            {
                fflag[i] = false;
                canit[i] = true;
            }
            //不能為炸彈9人眾
            int[] aa = new int[9];
            aa[0] = a;
            aa[1] = a - col - 1;
            aa[2] = a - col;
            aa[3] = a - col + 1;
            aa[4] = a - 1;
            aa[5] = a + 1;
            aa[6] = a + col - 1;
            aa[7] = a + col;
            aa[8] = a + col + 1;

            //炸彈位址
            rr = new int[bombnum];
            int rrr = 0;
            int cou = bombnum;
            bool q;
            while (cou > 0)
            {
                q = true;
                int r = random.Next(totalnum);
                for (int j = 0; j < rrr; j++)
                {
                    if (r == rr[j])
                    {
                        q = false;
                        break;
                    }
                    
                }
                for (int i=0;i<9;i++)
                {
                    if (r == aa[i])
                    {
                        q = false;
                        break;
                    }
                }
                if (q)
                {
                    f[r] = 44;
                    cou--;
                    rr[rrr] = r;
                    rrr++;
                }
            }
            //數字
            for (int i = 0; i < totalnum; i++)
            {
                int num = 0;
                if (f[i] != 44)
                {
                    if (i % col != (col - 1) && i % col != 0)
                    {
                        if (i - col - 1 >= 0) { if (f[i - col - 1] == 44) { num++; } }
                        if (i - col >= 0) { if (f[i - col] == 44) { num++; } }
                        if (i - col + 1 >= 0) { if (f[i - col + 1] == 44) { num++; } }
                        if (i - 1 >= 0) { if (f[i - 1] == 44) { num++; } }

                        if (i + 1 < totalnum) { if (f[i + 1] == 44) { num++; } }
                        if (i + col - 1 < totalnum) { if (f[i + col - 1] == 44) { num++; } }
                        if (i + col < totalnum) { if (f[i + col] == 44) { num++; } }
                        if (i + col + 1 < totalnum) { if (f[i + col + 1] == 44) { num++; } }
                    }
                    else if (i % col == (col - 1))
                    {
                        if (i - col - 1 >= 0) { if (f[i - col - 1] == 44) { num++; } }
                        if (i - col >= 0) { if (f[i - col] == 44) { num++; } }
                        if (i - 1 >= 0) { if (f[i - 1] == 44) { num++; } }

                        if (i + col - 1 < totalnum) { if (f[i + col - 1] == 44) { num++; } }
                        if (i + col < totalnum) { if (f[i + col] == 44) { num++; } }
                    }
                    else if (i % col == 0)
                    {
                        if (i - col >= 0) { if (f[i - col] == 44) { num++; } }
                        if (i - col + 1 >= 0) { if (f[i - col + 1] == 44) { num++; } }

                        if (i + 1 < totalnum) { if (f[i + 1] == 44) { num++; } }
                        if (i + col < totalnum) { if (f[i + col] == 44) { num++; } }
                        if (i + col + 1 < totalnum) { if (f[i + col + 1] == 44) { num++; } }
                    }

                    f[i] = num;
                }
            }
            
        }
        private void Buttons_Click(object sender, MouseEventArgs e)
        {
            if (gg) { return; }
            Button button = (Button)sender;
            //z
            for (int i = 0; i < y; i++) 
            {
                 if (button == brick[i])
                 {
                      z = i;
                      break;
                 }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (firsttab == 0) { return; }
                flag = true;
                if (firsttab == 1 && fflag[z])
                {
                    button.BackgroundImage = null;
                    fflag[z] = false;
                    return;
                }
            }
            if (e.Button == MouseButtons.Left) { flag = false; }
            
            if (firsttab == 0) {
                FirstTab(z,rrow,x,y,b);
                timer1.Start();
                firsttab = 1;
            }

            if(flag)
            {
                if(canit[z]==true)
                {
                    button.BackgroundImage = Properties.Resources.flag;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    fflag[z] = true;
                    return;
                }
            }
            if (fflag[z]) { return; }
            //點數字
            if (canit[z] == false)
            {
                int xx = 0;
                if (z % x != (x - 1) && z % x != 0)
                {
                    if (z - x - 1 >= 0) { if (fflag[z - x - 1] == true) { xx++; } }
                    if (z - x >= 0) { if (fflag[z - x] == true) { xx++; } }
                    if (z - x + 1 >= 0) { if (fflag[z - x + 1] == true) { xx++; } }
                    if (z - 1 >= 0) { if (fflag[z - 1] == true) { xx++; } }

                    if (z + 1 < y) { if (fflag[z + 1] == true) { xx++; } }
                    if (z + x - 1 < y) { if (fflag[z + x - 1] == true) { xx++; } }
                    if (z + x < y) { if (fflag[z + x] == true) { xx++; } }
                    if (z + x + 1 < y) { if (fflag[z + x + 1] == true) { xx++; } }
                }
                else if (z % x == (x - 1))
                {
                    if (z - x - 1 >= 0) { if (fflag[z - x - 1] == true) { xx++; } }
                    if (z - x >= 0) { if (fflag[z - x] == true) { xx++; } }
                    if (z - 1 >= 0) { if (fflag[z - 1] == true) { xx++; } }

                    if (z + x - 1 < y) { if (fflag[z + x - 1] == true) { xx++; } }
                    if (z + x < y) { if (fflag[z + x] == true) { xx++; } }
                }
                else if (z % x == 0)
                {
                    if (z - x >= 0) { if (fflag[z - x] == true) { xx++; } }
                    if (z - x + 1 >= 0) { if (fflag[z - x + 1] == true) { xx++; } }

                    if (z + 1 < y) { if (fflag[z + 1] == true) { xx++; } }
                    if (z + x < y) { if (fflag[z + x] == true) { xx++; } }
                    if (z + x + 1 < y) { if (fflag[z + x + 1] == true) { xx++; } }
                }
                if(xx==f[z])
                {
                    //檢查沒按過也沒flag
                    if (z % x != (x - 1) && z % x != 0)
                    {
                        if (z - x - 1 >= 0) { if (canit[z - x - 1] == true && fflag[z - x - 1] == false) { bbb(z - x - 1); } }
                        if (z - x >= 0) { if (canit[z - x] == true && fflag[z - x] == false) { bbb(z - x); } }
                        if (z - x + 1 >= 0) { if (canit[z - x + 1] == true && fflag[z - x + 1] == false) { bbb(z - x + 1); } }
                        if (z - 1 >= 0) { if (canit[z - 1] == true && fflag[z - 1] == false) { bbb(z - 1); } }

                        if (z + 1 < y) { if (canit[z + 1] == true && fflag[z + 1] == false) { bbb(z + 1); } }
                        if (z + x - 1 < y) { if (canit[z + x - 1] == true && fflag[z + x - 1] == false) { bbb(z + x - 1); } }
                        if (z + x < y) { if (canit[z + x] == true && fflag[z + x] == false) { bbb(z + x); } }
                        if (z + x + 1 < y) { if (canit[z + x + 1] == true && fflag[z + x + 1] == false) { bbb(z + x + 1); } }
                    }
                    else if (z % x == (x - 1))
                    {
                        if (z - x - 1 >= 0) { if (canit[z - x - 1] == true && fflag[z - x - 1] == false) { bbb(z - x - 1); } }
                        if (z - x >= 0) { if (canit[z - x] == true && fflag[z - x] == false) { bbb(z - x); } }
                        if (z - 1 >= 0) { if (canit[z - 1] == true && fflag[z - 1] == false) { bbb(z - 1); } }

                        if (z + x - 1 < y) { if (canit[z + x - 1] == true && fflag[z + x - 1] == false) { bbb(z + x - 1); } }
                        if (z + x < y) { if (canit[z + x] == true && fflag[z + x] == false) { bbb(z + x); } }
                    }
                    else if (z % x == 0)
                    {
                        if (z - x >= 0) { if (canit[z - x] == true && fflag[z - x] == false) { bbb(z - x); } }
                        if (z - x + 1 >= 0) { if (canit[z - x + 1] == true && fflag[z - x + 1] == false) { bbb(z - x + 1); } }

                        if (z + 1 < y) { if (canit[z + 1] == true && fflag[z + 1] == false) { bbb(z + 1); } }
                        if (z + x < y) { if (canit[z + x] == true && fflag[z + x] == false) { bbb(z + x); } }
                        if (z + x + 1 < y) { if (canit[z + x + 1] == true && fflag[z + x + 1] == false) { bbb(z + x + 1); } }
                    }
                }
            }
            bbb(z);
        }
        private void bbb(int z)
        {
            canit[z] = false;
            //按到0
            if (f[z] == 0)
            {
                brick[z].BackgroundImage = Properties.Resources.tu;
                brick[z].BackgroundImageLayout = ImageLayout.Stretch;
                Presszero(z);
            }
            if (f[z] == 1) { brick[z].BackgroundImage = Properties.Resources._1; brick[z].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[z] == 2) { brick[z].BackgroundImage = Properties.Resources._2; brick[z].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[z] == 3) { brick[z].BackgroundImage = Properties.Resources._3; brick[z].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[z] == 4) { brick[z].BackgroundImage = Properties.Resources._4; brick[z].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[z] == 5) { brick[z].BackgroundImage = Properties.Resources._5; brick[z].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[z] == 6) { brick[z].BackgroundImage = Properties.Resources._6; brick[z].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[z] == 7) { brick[z].BackgroundImage = Properties.Resources._7; brick[z].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[z] == 8) { brick[z].Text = "8"; }

            if (f[z] == 44)
            {
                for (int i = 0; i < y; i++)
                {
                    if (f[i] == 44 && !fflag[i])
                    {
                        brick[i].BackgroundImage = Properties.Resources.bbbbbb;
                        brick[i].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    if (f[i] != 44 && fflag[i])
                    {
                        brick[i].BackgroundImage = Properties.Resources.falseflag;
                        brick[i].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                gg = true;
            }
        }
        private void Presszero(int i)
        {
            if (i % x != (x-1) && i % x != 0) //x=col,y=totalnum,b=bombnum
            {
                if (i - x-1 >= 0) {
                    if (f[i - x-1] == 0)
                    {
                        if (canit[i - x-1] == true) {  canit[i - x-1] = false; brick[i - x-1].BackgroundImage = Properties.Resources.tu; brick[i - x-1].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i - x-1);  }
                    }
                    else { Pzf(i - x-1);  }
                }
                if (i - x >= 0) {
                    if (f[i - x] == 0)
                    {
                        if (canit[i - x] == true) { canit[i - x] = false; brick[i -x].BackgroundImage = Properties.Resources.tu; brick[i -x].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i - x);  }
                    }
                    else { Pzf(i - x);  }
                }
                if (i - x+1 >= 0) {
                    if (f[i - x+1] == 0)
                    {
                        if (canit[i - x + 1] == true) { canit[i - x + 1] = false; brick[i - x + 1].BackgroundImage = Properties.Resources.tu; brick[i - x + 1].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i - x + 1);  }
                    }
                    else { Pzf(i - x + 1);  }
                }
                if (i - 1 >= 0) {
                    if (f[i - 1] == 0) {
                        if (canit[i - 1] == true) { canit[i - 1] = false; brick[i -1].BackgroundImage = Properties.Resources.tu; brick[i -1].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i - 1);  }
                    }
                    else { Pzf(i - 1);  }
                }

                if (i + 1 < y) {
                    if (f[i + 1] == 0)
                    {
                        if (canit[i + 1] == true) { canit[i +1] = false; brick[i + 1].BackgroundImage = Properties.Resources.tu; brick[i + 1].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i + 1);  }
                    }
                    else { Pzf(i + 1);  }
                }
                if (i + x-1 < y) {
                    if (f[i + x - 1] == 0)
                    {
                        if (canit[i + x - 1] == true) { canit[i + x - 1] = false; brick[i + x - 1].BackgroundImage = Properties.Resources.tu; brick[i + x - 1].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i + x - 1);  }
                    }
                    else { Pzf(i + x - 1); }
                }
                if (i + x < y) {
                    if (f[i + x] == 0) {
                        if (canit[i + x] == true) { canit[i +x] = false; brick[i + x].BackgroundImage = Properties.Resources.tu; brick[i + x].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i + x);  }
                    }
                    else { Pzf(i + x);  }
                }
                if (i + x+1 < y) {
                    if (f[i + x+1] == 0) {
                        if (canit[i + x + 1] == true) { canit[i + x + 1] = false; brick[i + x + 1].BackgroundImage = Properties.Resources.tu; brick[i + x + 1].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i + x + 1);  }
                    }
                    else { Pzf(i + x + 1); }
                }
            }
            else if (i % x == x-1)
            {
                if (i - x - 1 >= 0)
                {
                    if (f[i - x - 1] == 0)
                    {
                        if (canit[i - x - 1] == true) { canit[i - x - 1] = false; brick[i - x - 1].BackgroundImage = Properties.Resources.tu; brick[i - x - 1].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i - x - 1); }
                    }
                    else { Pzf(i - x - 1); }
                }
                if (i - x >= 0)
                {
                    if (f[i - x] == 0)
                    {
                        if (canit[i - x] == true) { canit[i - x] = false; brick[i - x].BackgroundImage = Properties.Resources.tu; brick[i - x].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i - x); }
                    }
                    else { Pzf(i - x); }
                }
                if (i - 1 >= 0)
                {
                    if (f[i - 1] == 0)
                    {
                        if (canit[i - 1] == true) { canit[i - 1] = false; brick[i - 1].BackgroundImage = Properties.Resources.tu; brick[i - 1].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i - 1); }
                    }
                    else { Pzf(i - 1); }
                }
                if (i + x - 1 < y)
                {
                    if (f[i + x - 1] == 0)
                    {
                        if (canit[i + x - 1] == true) { canit[i + x - 1] = false; brick[i + x - 1].BackgroundImage = Properties.Resources.tu; brick[i + x - 1].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i + x - 1); }
                    }
                    else { Pzf(i + x - 1); }
                }
                if (i + x < y)
                {
                    if (f[i + x] == 0)
                    {
                        if (canit[i + x] == true) { canit[i + x] = false; brick[i + x].BackgroundImage = Properties.Resources.tu; brick[i + x].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i + x); }
                    }
                    else { Pzf(i + x); }
                }
            }
            else if (i % x == 0)
            {
                if (i - x >= 0)
                {
                    if (f[i - x] == 0)
                    {
                        if (canit[i - x] == true) { canit[i - x] = false; brick[i - x].BackgroundImage = Properties.Resources.tu; brick[i - x].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i - x); }
                    }
                    else { Pzf(i - x); }
                }
                if (i - x + 1 >= 0)
                {
                    if (f[i - x + 1] == 0)
                    {
                        if (canit[i - x + 1] == true) { canit[i - x + 1] = false; brick[i - x + 1].BackgroundImage = Properties.Resources.tu; brick[i - x + 1].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i - x + 1); }
                    }
                    else { Pzf(i - x + 1); }
                }
                if (i + 1 < y)
                {
                    if (f[i + 1] == 0)
                    {
                        if (canit[i + 1] == true) { canit[i + 1] = false; brick[i + 1].BackgroundImage = Properties.Resources.tu; brick[i + 1].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i + 1); }
                    }
                    else { Pzf(i + 1); }
                }
                if (i + x < y)
                {
                    if (f[i + x] == 0)
                    {
                        if (canit[i + x] == true) { canit[i + x] = false; brick[i + x].BackgroundImage = Properties.Resources.tu; brick[i + x].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i + x); }
                    }
                    else { Pzf(i + x); }
                }
                if (i + x + 1 < y)
                {
                    if (f[i + x + 1] == 0)
                    {
                        if (canit[i + x + 1]== true) { canit[i + x + 1] = false; brick[i + x + 1].BackgroundImage = Properties.Resources.tu; brick[i + x + 1].BackgroundImageLayout = ImageLayout.Stretch; Presszero(i + x + 1); }
                    }
                    else { Pzf(i + x + 1); }
                }
            }
        }
        private void Res_Click(object sender, EventArgs e)
        {
            Clear();
            Regenerate(gen);
        }
        private void Clear()
        {
            gg = false;
            t = 0;
            tt = 0;
            firsttab = 0;
            timer1.Stop();
            flag = false;
            label1.Text = "";
            label2.Text = "";
            res.BackgroundImage = Properties.Resources.smile;
            res.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            int bb = 0;
            for(int i=0;i<y;i++)
            {
                if (fflag[i] == true)
                    bb++;
            }
            int d = b - bb;
            label2.Text = ""+d;
            t++;
            if(gg)
            {
                timer1.Stop();
                res.BackgroundImage = Properties.Resources.die;
                res.BackgroundImageLayout = ImageLayout.Stretch;
            }
            int aa=0;
            for(int a=0;a<y;a++)
            {
                if (canit[a]==false)
                {
                    aa++;
                }
            }
            if (aa >= y-b&&!gg) {
                timer1.Stop();
                res.BackgroundImage = Properties.Resources.bigsmile; res.BackgroundImageLayout = ImageLayout.Stretch;
                gg = true;
                if (gen == 1)
                {
                    int t1 = int.Parse(ttt[0]);
                    if (t1 > tt)
                    {
                        ttt[0]= Convert.ToString(tt);
                        stime = Convert.ToString(tt);
                        Class1 owo = new Class1();
                        owo.changetime(gen,stime);
                        Form2 newrecord = new Form2();
                        newrecord.Show();
                    }
                }
                if (gen == 2)
                {
                    int t2 = int.Parse(ttt[1]);
                    if (t2 > tt)
                    {
                        ttt[1] = Convert.ToString(tt);
                        stime = Convert.ToString(tt);
                        Class1 owo = new Class1();
                        owo.changetime(gen, stime);
                        Form2 newrecord = new Form2();
                        newrecord.Show();
                    }
                }
                if (gen == 3)
                {
                    int t3 = int.Parse(ttt[2]);
                    if (t3 > tt)
                    {
                        ttt[2] = Convert.ToString(tt);
                        stime = Convert.ToString(tt);
                        Class1 owo = new Class1();
                        owo.changetime(gen, stime);
                        Form2 newrecord = new Form2();
                        newrecord.Show();
                    }
                }
            }
            if (t == 10) { tt++; t = 0; }
            label1.Text = ""+tt;
        }

        private void 簡單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gen = 1;
            Clear();
            Regenerate(gen);
        }

        private void 作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void 排名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void 困難ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gen = 3;
            Clear();
            Regenerate(gen);
        }

        private void Regenerate(int geen)
        {
            if (rgen!=geen)
            {
                w1 = 0;
                rgen = geen;
                for (int i = 0; i < y; i++)
                {
                    //panel1.Controls.Add(brick[i]);
                    this.Controls.Remove(brick[i]);
                }
                            }
            res.Left = 0;
            label1.Left = 0;
            if (geen == 1) {
                Generate(10,10,100,10);
                res.Left = this.Width / 2 - 23;
                label1.Left = this.Width - 60;
                label2.Left = 10;
            }
            else if (geen == 2) {
                Generate(16,16,256,40);
                res.Left = this.Width / 2 - 23;
                label1.Left = this.Width - 60;
                label2.Left = 10;
            }
            else if (geen == 3) {
                Generate(16,30,480,99);
                res.Left = this.Width / 2 - 23;
                label1.Left = this.Width - 60;
                label2.Left = 10;
            }
        }

        private void 中等ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gen = 2;
            Clear();
            Regenerate(gen);
        }

        private void Pzf(int k)
        {
            
            if (f[k]==1) { brick[k].BackgroundImage = Properties.Resources._1; brick[k].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[k] ==2) {  brick[k].BackgroundImage = Properties.Resources._2; brick[k].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[k] ==3) {  brick[k].BackgroundImage = Properties.Resources._3; brick[k].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[k] ==4) {  brick[k].BackgroundImage = Properties.Resources._4; brick[k].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[k] ==5) {  brick[k].BackgroundImage = Properties.Resources._5; brick[k].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[k] ==6) {  brick[k].BackgroundImage = Properties.Resources._6; brick[k].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[k] ==7) {  brick[k].BackgroundImage = Properties.Resources._7; brick[k].BackgroundImageLayout = ImageLayout.Stretch; }
            if (f[k] ==8) { brick[k].Text = "8"; }
            //brick[k].Enabled = false;
            canit[k] = false;
        }
    }
}
