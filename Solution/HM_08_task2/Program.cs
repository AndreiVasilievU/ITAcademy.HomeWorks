using System;

namespace HM_08_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "любовь ещё быть может";
            string str2 = "Самое длинное слово: {0}";
            string str3 = "Замена длинного с коротким: {0}";
            string str4 = "Сортировка: {0}";

            Console.WriteLine(str2, DeleteMaxWord(str));
            Console.WriteLine(str3, ChangeWord(str));
            CountChr(str);
            Console.WriteLine(str4, Sort(str));
        }
        static string DeleteMaxWord(string str)
        {
            string[] strMas = str.Split(" ");
            int maxLen = 0;
            int index = 0;

            for (int i = 0; i < strMas.Length; i++) 
            {
                if (strMas[i].Length > maxLen) 
                {
                    maxLen = strMas[i].Length;
                    index = i;
                }
            }
            return strMas[index];
        }
        static string ChangeWord(string str)
        {
            string[] strMas = str.Split(" ");
            int maxLen = 0;
            int minLen = strMas[0].Length;
            int minIndex = 0;
            int maxIndex = 0;

            for(int i = 0; i < strMas.Length; i++)
            {
                if(strMas[i].Length > maxLen)
                {
                    maxLen = strMas[i].Length;
                    maxIndex = i;
                }
                if(strMas[i].Length < minLen)
                {
                    minLen = strMas[i].Length;
                    minIndex = i;
                }
            }

            string word = strMas[minIndex];
            strMas[minIndex] = strMas[maxIndex];
            strMas[maxIndex] = word;
            string str2 = String.Join(" ", strMas);
            return str2;
        }
        static string CountChr(string str)
        {
            char k = ' ';
            int chIndex = 0;
            int markIndex = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    chIndex++;
                }
                else 
                {
                    if (k.Equals(' '))
                    {
                        markIndex += 0;
                    }
                    else
                        markIndex++;
                }
            }
            Console.WriteLine("Количество букв: {0} , Количество знаков: {1}", chIndex, markIndex);
            return "";
        }
        static string Sort(string str)
        {
            string[] strMas = str.Split(" ");

            for(int i = strMas.Length - 1; i > 0 ; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if(strMas[j].Length < strMas[j + 1].Length)
                    {
                        string temp = strMas[j];
                        strMas[j] = strMas[j + 1];
                        strMas[j + 1] = temp;
                    }
                }
            }
            string str2 = String.Join(" ", strMas);
            return str2;
        }
    }
}
