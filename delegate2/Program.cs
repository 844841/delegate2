using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate2
{
    class Program
    {
        public delegate string Mydel(int x);

        static void Main(string[] args)
        {
            Mydel delg = new Mydel(Area);
            Console.WriteLine(delg(5));
            delg += new Mydel(Area);

        }
        public static string Area(int a)
        {
            int c = a * a;
            return Convert.ToString(c);
        }
    }
}
