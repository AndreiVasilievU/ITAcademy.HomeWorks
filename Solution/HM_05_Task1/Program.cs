using System;

namespace HM_05_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<=25; i++)
            {
                int count = 90;
                char ch = (char)(count-i);
                Console.WriteLine(ch);                
            } 
        }
    }
}
