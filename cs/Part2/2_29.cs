using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BASE
    {
        double a;
        public double b;
        protected double c;
        public void funInit () { a = 0.33; b = 11.5; c = -1.45; }
        public void funA () { Console.Write("  a =" + a); }

    }

    class DERIVED:BASE
    {
        public void funDer () { Console.Write("  b =" + b + "  c =" + c); }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            DERIVED obD = new DERIVED();
            obD.funInit();
            Console.WriteLine("  b = " + obD.b + "   доступ к открытой переменной базового класса");
            obD.funDer();
            Console.WriteLine("  доступ к закр и защищ переменным базового класса");
            obD.funA();
            Console.WriteLine("  доступ к закр эл базового класса");               
            Console.Read();
        }
    }
}
