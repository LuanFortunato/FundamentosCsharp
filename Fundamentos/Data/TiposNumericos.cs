using System;

namespace DataApp
{
    public class TiposNumericos
    {
        public void Executa()
        {
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);

            Console.WriteLine(Int16.MinValue);
            Console.WriteLine(Int16.MaxValue);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);

            Console.WriteLine(Int64.MinValue);
            Console.WriteLine(Int64.MaxValue);
        }
    }
}
