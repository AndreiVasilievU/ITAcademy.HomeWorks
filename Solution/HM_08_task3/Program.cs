using System;
using System.Text;

namespace HM_08_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            char k1 = '.';
            char k2 = '!';
            char k = '?';
            string str = "1a!2.3!!.. 4.!.?6 7! ..?";
            int indexMin = str.IndexOf(k);

            string str1 = str.Substring(indexMin);
            string str2 = str.Substring(0, indexMin);

            StringBuilder sb1 = new StringBuilder(str1);
            sb1.Replace(" ", "_");
            StringBuilder sb2 = new StringBuilder(str2);
            for(int i=0 ; i < sb2.Length; i++)
            {
                if(sb2[i].Equals('.') || sb2[i].Equals('!'))
                {
                    sb2.Remove(i, 1);
                    i--;
                }
            }

            Console.WriteLine(sb1);
            Console.WriteLine(sb2);
        }
    }
}
