using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALS
{
    internal class Scratch
    {   
        public List<int[]> Accounts = new List<int[]>();
        public void StreamRead()
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\Lorenzo Miguel Cruz\\Downloads\\Accounts.txt"))
            {
                string line;
                string[] lines;
                
                while ((line = sr.ReadLine()) != null)
                {
                    lines = line.Split('$', '#', System.StringSplitOptions.RemoveEmptyEntries);
                    int[] accs = { int.Parse(lines[0]), int.Parse(lines[1]) };
                    Accounts.Add(accs);
                }
            }
        }
        public static List<string> LogBook(int x)
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\Lorenzo Miguel Cruz\\Downloads\\LogBook.txt"))
            {
                string line;
                List<string> lines = new List<string>();
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                return lines;
            }

        }

    }
}
