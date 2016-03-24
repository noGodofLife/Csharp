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
        public BASE (double aa, double bb, double cc)
        {
            a = aa;b = bb;c = cc;
            Console.Write("  конструктор BASE\n");
        }
        ~BASE () { Console.Write("  деструктор BASE\n"); }
        public void funA () { Console.Write("  a =" + a); }
    }

    class DERIVED:BASE
    {
        public int k;
        public DERIVED (int kk, double aa, double bb, double cc):base(aa,bb,cc)
        {
            k = kk;
            Console.Write("  конструктор DERIVED\n");
        }
        ~DERIVED() { Console.Write("  деструктор DERIVED"); }
        public void funDer() { Console.Write("  b= " + b + "  c= " + c); }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            double e = 0.22, ee = 1.2, eee = -126.5; int i = 13;

            DERIVED obD = new DERIVED(i,e,ee,eee);
            Console.WriteLine("  b = " + obD.b + "   доступ к открытой переменной базового класса");
            obD.funDer();
            Console.WriteLine("  доступ к закр и защищ переменным базового класса");
            obD.funA();
            Console.WriteLine("  доступ к закр эл базового класса");
            Console.WriteLine("  k = " + obD.k + " доступ к открытой переменной производного класса");
            Console.Read();
        }
    }
}
