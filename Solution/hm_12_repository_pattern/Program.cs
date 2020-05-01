using System;

namespace hm_12_repository_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMoto manager = new ManagerMoto();
            manager.CreateMoto(0);
            manager.CreateMoto(1);
            manager.DeliteMoto(1);
            manager.ReadMoto(0);
            manager.ReadMoto(1);
        }
    }
}
