using hm_11_square;
using System;

namespace hm_12_repository_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            ManagerMoto manager = new ManagerMoto();
            Logger.Log.Info("создаём мотоцикл 1");
            manager.CreateMoto(0);
            Logger.Log.Info("создаём мотоцикл 2");
            manager.CreateMoto(1);
            Logger.Log.Info("удаляем мотоцикл");
            manager.DeliteMoto(1);
            Logger.Log.Info("считываем мотоцикл 1");
            manager.ReadMoto(0);
            Logger.Log.Info("считываем мотоцикл 2");
            manager.ReadMoto(1);
            Logger.Log.Info("конец работы программы");
        }
    }
}