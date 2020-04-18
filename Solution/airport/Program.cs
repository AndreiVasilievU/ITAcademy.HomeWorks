using System;

namespace airport
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            ChekIn ch = new ChekIn();
            Security sec = new Security();
            PassControl pas = new PassControl();

            ch.CheckTicket(p);
            ch.CheckBaggage(p);

            sec.CheckSmallBag(p);
            sec.GoToPassControl(p);

            pas.PassportControl(p);
        }
    }
}
