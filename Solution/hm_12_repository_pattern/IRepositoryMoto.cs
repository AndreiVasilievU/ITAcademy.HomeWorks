using System;
using System.Collections.Generic;
using System.Text;

namespace hm_12_repository_pattern
{
    interface IRepositoryMoto
    {
        void CreateMoto(int a);
        void UpdateMoto(int a);
        void DeliteMoto(int a);
        void ReadMoto(int a);
    }
}
