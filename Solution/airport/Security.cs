using System;
using System.Collections.Generic;
using System.Text;

namespace airport
{
    class Security
    {
        public void CheckSmallBag(Person p)
        {
            Console.WriteLine("есть ли у вас ручная кладь?");
            if (p.isSmallBag == Console.ReadLine())
            {
                Console.WriteLine("покажите что внутри");
                Console.WriteLine("а теперь покажите что в карманах");
            }
            else
            {
                Console.WriteLine("покажите что в карманах");
            }
        }
        public void GoToPassControl(Person p)
        {
            Console.WriteLine("проходите в паспортный контроль");
        }
    }
}
