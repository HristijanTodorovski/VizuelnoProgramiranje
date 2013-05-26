using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallJumper.Properties;

namespace WallJumper
{
    class Res
    {
     // public String name{get;set;}
       public int score { get; set; }
        public Res()
        {
            StreamReader file;
            string path = @"../../Resources/Scores.txt";
            file = new StreamReader(path);
            String line = file.ReadLine();
            score = Int16.Parse(line);
            file.Close();
         }
        public void writes(int k)
        {
            if (k > score)
            {
                StreamWriter file;
                string path = @"../../Resources/Scores.txt";
                file = new StreamWriter(path);
                file.Write(k);
                file.Flush();
                file.Close();
            }

        }
    }
}
