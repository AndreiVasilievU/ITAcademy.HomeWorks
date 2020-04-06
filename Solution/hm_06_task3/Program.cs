using System;
using System.Diagnostics;

namespace hm_06_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            long[] mas = new long[100000000];
            for (long i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(100000000);
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(long k = 0; k < mas.Length/2; k++)
            {
                long num = mas[k];
                mas[k] = mas[mas.Length - k-1];
                mas[mas.Length - k-1] = num;
            }
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine(ts);
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            Array.Reverse(mas);
            sw2.Stop();
            long ts2 = sw2.ElapsedMilliseconds;
            Console.WriteLine(ts2);
        }
    }
}
