using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp
{
    public class TiposNmericos2
    {
        public static void Executa()
        {
            char letra = 'Y';
            Console.WriteLine(letra);

            Console.WriteLine(char.MinValue);
            Console.WriteLine(char.MaxValue);

            Console.WriteLine((byte) char.MinValue);
            Console.WriteLine((int) char.MaxValue);
        }
    }
}
