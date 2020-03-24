using System;

namespace hm_06_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mas1 = new int[2];
            int sum1 = 0;
            for(int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = rnd.Next(25);
                sum1 = sum1 + mas1[i];
                Console.WriteLine(mas1[i]);
            }
            int[] mas2 = new int[2];
            int sum2 = 0;
            for (int i = 0; i < mas2.Length; i++)
            {
                string num = Console.ReadLine();
                int num1 = int.Parse(num);
                mas2[i] = num1;
                sum2 = sum2 + mas2[i];
                Console.WriteLine(mas2[i]);
            }
            int[] mas3 = new int[2];
            mas3[0] = sum1;
            mas3[1] = sum2;
            foreach (int item in mas3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
