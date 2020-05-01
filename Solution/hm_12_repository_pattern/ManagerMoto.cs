using System;
using System.Collections.Generic;
using System.Text;

namespace hm_12_repository_pattern
{
    public class ManagerMoto : IRepositoryMoto
    {
        public void CreateMoto(int a)
        {
            RepositoryMoto.moto[a].Id = Console.ReadLine();
            RepositoryMoto.moto[a].Name = Console.ReadLine();
            RepositoryMoto.moto[a].Model = Console.ReadLine();
        }

        public void DeliteMoto(int a)
        {
            RepositoryMoto.moto[a].Id = "deleted";
            RepositoryMoto.moto[a].Name = "deleted";
            RepositoryMoto.moto[a].Model = "deleted";
        }
        public void ReadMoto(int a)
        {
            Console.WriteLine(RepositoryMoto.moto[a].Id + " " + RepositoryMoto.moto[a].Name + " " + RepositoryMoto.moto[a].Model);
        }
        public void UpdateMoto(int a)
        {
            RepositoryMoto.moto[a].Id = Console.ReadLine();
            RepositoryMoto.moto[a].Name = Console.ReadLine();
            RepositoryMoto.moto[a].Model = Console.ReadLine();
        }
        
    }
}
