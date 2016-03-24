using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string txt =
                "humpty dumpty sat on the wall\n" +
                "Шолтай болтай сидел на стене";
            Console.WriteLine("ИСХ\n" + txt);
            string rez = code.tarabar(txt);
            Console.WriteLine("\nЗАШИФР\n" + rez);
            string rez1 = code.tarabar(rez);
            Console.WriteLine("\nРАСШИФР\n" + rez1);
            Console.Read();
        }
    }
}
