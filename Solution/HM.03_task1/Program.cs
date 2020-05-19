using System;
using System.Collections;

namespace HM._03_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //явное преобразование
            int a= 20;
            short b;
            b = (short)a;

            double a1 = 12.02f;
            float b1;
            b1 = (float)a1;

            short a2 = 2;
            byte b2;
            b2 = (byte)a2;

            //неявное преобразование
            short a3 = 20;
            int b3 = a3;

            float a4 = 23.45f;
            double b4 = a4;

            byte a5 = 4;
            int b5 = a5;

            //упаковка
            int i = 123;
            object o = (object)i;

            int f1 = 34;
            Converter(f1);
            static void Converter(object f)
            {

            }

            ArrayList i2 = new ArrayList();
            int i4 = 8;
            i2.Add(i4);

            //распаковка
            int c = (int)o;

            string g = "privet";
            object j = (object)g;
            string n = (string)j;

            float g1 = 34.4f;
            object j1 = g1;
            float n1 = (float)j1;

            //Пример с упаковкой int типа и распаковкой вushortтип
            int value = 34;
            object value1 = value;
            ushort value2 = (ushort)(int)value1;

            //Пример с упаковкой Логического типа и распаковой в byte тип
            bool isTrue = true;
            object q1 = isTrue;
            Convert.ToByte(q1);

            //Пример с упаковкой charтипа и распаковкой в intтип
            char l = 'a';
            object l1 = l;
            Convert.ToInt32(l1); 


        }
    }
}
