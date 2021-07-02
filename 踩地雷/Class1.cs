using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 踩地雷
{
    class Class1
    {
        private const string FILE_NAME = "record.txt";
        private static string[] s=new string[6];
        private static int level;
        public void changetime(int t,string time)
        {
            //t用來決定改變哪個難度的時間
            //先存原本檔案的資料
            
            FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                for (int i=0;i<6;i++)
                {
                    s[i]=sr.ReadLine();
                }
            }
            fs.Close();
            //存要改的部分
            level = t;
            if (t == 1) { s[0] = time; }
            if (t == 2) { s[2] = time; }
            if (t == 3) { s[4] = time; }
        }
        public void changename(string name)
        {
            FileInfo f = new FileInfo(FILE_NAME);
            if (level == 1) { s[1] = name; }
            if (level == 2) { s[3] = name; }
            if (level == 3) { s[5] = name; }
            //StreamReader sr;
            StreamWriter sw;
            sw = f.CreateText();
            for(int i=0;i<6;i++)
            {
                sw.WriteLine(s[i]);
            }
            sw.Flush();
            sw.Close();
        }
    }
}
