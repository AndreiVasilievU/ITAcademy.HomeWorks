using System;

namespace HM_05_Task2
{
    class Program
    {
        static void Main(string[] args)
        {  
            int a = Console.Read();
            if(a == 119 || a == 87)
            {
                Console.WriteLine("вверх");
            }
            else if(a == 115 || a == 83)
            {
                Console.WriteLine("вниз");
            }
            else if(a == 65 || a == 97)
            {
                Console.WriteLine("влево");
            }
            else if(a == 68 || a == 100)
            {
                Console.WriteLine("вправо");
            }
            else
            {
                Console.WriteLine("пока постоим");
            }
        }
    }
}
