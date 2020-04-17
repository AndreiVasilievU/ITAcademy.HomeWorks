using AssemblyOne;
using System;

namespace AssemblyTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();

            //видны только паблик модификаторы из другой сборки
            Console.WriteLine(Motorcycle.MinSpeedPublic);

            moto.MovePublic();

            moto.MaxSpeedPublic = 10;

            //а наследника невидно из другой сборки вообще, у Motorcycle - publik, у SportBike - internal
        }
    }
}
