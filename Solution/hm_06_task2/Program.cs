using System;

namespace hm_06_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[5];
            for (int i = 0; i < mas.Length - 1; i++)
            {
                string num = Console.ReadLine();
                int num1 = int.Parse(num);
                mas[i] = num1;
            }
            Console.WriteLine("Вывод массива ");
            foreach (int item in mas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("введите число из массива ");
            string num2 = Console.ReadLine();
            int num3 = int.Parse(num2);
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == num3)
                {
                    int a = i + 1;
                    Console.WriteLine("номер элемента массива ");
                    Console.WriteLine(a);
                    if (a >= 0 && a < mas.Length )
                    {

                        for (int k = mas.Length - 1; k > i; k--)
                        {
                            mas[k] = mas[k - 1];
                        }
                    }
                    else
                    {
                        i = mas.Length - 1;
                        mas[i] = 1000;
                    }
                    mas[i] = 1000;
                    Console.WriteLine("Вывод массива2 c заменой нужного элемента на 1000 ");
                    foreach (int item in mas)
                    {
                        Console.WriteLine(item);
                    }
                    
                    break;
                } 
            }
        }
    }
}
