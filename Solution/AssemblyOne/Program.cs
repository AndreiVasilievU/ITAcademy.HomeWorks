using System;

namespace AssemblyOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();

            //2 константы только доступно в той же сборке из другого класса
            Console.WriteLine(Motorcycle.MinSpeedInternal); //доступен в той же сборке
            Console.WriteLine(Motorcycle.MinSpeedPublic); //доступен везде

            //через ссылку на обьект могу доступ получить ? магия
            Console.WriteLine(moto.MinSpeedProtectedInternal); //доступен из текущей сборки и из производных классов

            //3 поля доступно в той же сборке из другого класса
            moto.MaxSpeedInternal = 10;
            moto.MaxSpeedPublic = 10;
            moto.MaxSpeedProtectedInternal = 10;

            //3 метода доступно
            moto.MovePublic();
            moto.MoveInternal();
            moto.MoveProtectedInternal();


            SportBike bike = new SportBike();

            //наследнику доступно тоже что и родителю
            Console.WriteLine(SportBike.MinSpeedInternal); //доступен в той же сборке
            Console.WriteLine(SportBike.MinSpeedPublic); //доступен везде
            Console.WriteLine(bike.MinSpeedProtectedInternal); ////доступен из текущей сборки и из производных классов

            bike.MaxSpeedPublic = 10;
            bike.MaxSpeedInternal = 10;
            bike.MaxSpeedProtectedInternal = 10;

            bike.MovePublic();
            bike.MoveInternal();
            bike.MoveProtectedInternal();
        }
    }
}
