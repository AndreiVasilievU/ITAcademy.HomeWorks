using System;
using log4net;
using log4net.Config;
using System.IO;
using System.Reflection;

namespace hm_11_square
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("Старт приложения");

            Figure[] fig = new Figure[] {new Circle(), new Square(), new Triangle()};
            for (int i = 0; i < fig.Length; i++)
            {
                Logger.Log.Info("Создаём фигуру");
                string cusMessage = "This figure is {0}. This square is {1}. This type is {2}";
                string format = string.Format(cusMessage, fig[i].name, fig[i].area, fig[i].GetType().Name);
                Console.WriteLine(format);
            }
            Logger.Log.Info("Конец работы приложения");
        }
    }
}
