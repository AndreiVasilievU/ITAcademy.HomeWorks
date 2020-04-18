using System;
using System.Collections.Generic;
using System.Text;

namespace airport
{
    class ChekIn
    {
        public void CheckTicket(Person p)
        {
            Console.WriteLine("Добрый день, представтесь пожалуйста");
            p.name = Console.ReadLine();
            Console.WriteLine(p.name + " есть-ли у вас билет?");

            if (p.isTicket == Console.ReadLine())
            {
                Console.WriteLine("хорошо");
            }
            else
            {
                Console.WriteLine("купите билет и возвращайтесь");
                System.Environment.Exit(0);
            }
        }
        public void CheckBaggage(Person p)
        {
                Console.WriteLine("есть ли у вас багаж?");
                if(p.isBigBag == Console.ReadLine())
                {
                    Console.WriteLine("Сдавайте и проходите в зону досмотра");
                }
                else
                {
                    Console.WriteLine("проходите в зону досмотра");
                }
        }
    }
}
