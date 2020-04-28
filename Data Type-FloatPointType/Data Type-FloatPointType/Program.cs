using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type_FloatPointType
{
    class Program
    {
        static void Main(string[] args)
        {

            float flMin = float.MinValue;
            float flMax = float.MaxValue;

            Console.WriteLine("Min_Value = {0} Max_Value = {1}", flMin, flMax);


            float flVar = 1F / 3;

            double dlVar = 1D / 3;

            decimal dcVar = 1M / 3;

            Console.WriteLine("\nfloat Value ={0}\ndouble Value ={1}\ndecimal Value ={2}\n", flVar, dlVar, dcVar);

            Console.ReadKey();

        }
    }
}
