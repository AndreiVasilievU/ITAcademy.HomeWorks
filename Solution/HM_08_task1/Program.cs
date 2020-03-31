using System;

namespace HM_08_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите стихотворение в одну строку разделяя строки точкой с запятой");

            string s = Console.ReadLine();
            string s2 = s.Replace('о', 'а');
            string[] mass = s2.Split(';');

            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
        }
    }
}
