using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp
{
    public class TiposNumericos3
    {
        public static void Executar()
        {
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            float f1 = 10.5f;
            Console.WriteLine(f1);

            double d1 = 10.1;
            double d2 = 20.2;
            double r = 30.3;
            Console.WriteLine($"{(d1 + d2)} == {r}");
            Console.WriteLine($"{(d1 + d2) == r}");

            decimal dc1 = 10.1m;
            decimal dc2 = 20.2m;
            decimal rd = 30.3m;
            Console.WriteLine($"{(dc1 + dc2)} == {rd}");
            Console.WriteLine($"{(dc1 + dc2) == rd}");
        }
    }
}
