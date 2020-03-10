using System;
using System.IO;

namespace HM._02
{
    /*      1) Считываем текстовый файлик
            2) Создаём массив для хранения байтов
            3) Создаём цикл, в котором конвертируем байты в картинку
            4) Сохраняем полученую картинку на диске
            5) И освобождаем память */
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);
            textReader.Dispose();
        }
    }
}
