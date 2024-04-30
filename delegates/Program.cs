using System;

namespace delegates
{
    public delegate void del1();
    public delegate void del2(int x, int y);
    public delegate void anony();    //anonymous delegate method


    class A
    {
        public static void method1()
        {
            Console.WriteLine("class P static method1");
        }

        public void method2()
        {
            Console.WriteLine("class P method2");
        }

        public static void method3(int x, int y)
        {
            Console.WriteLine(x+y);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            del1 d1 = A.method1;
            del1 d2 = new del1 (A.method1);
            d1();
            d2();
            

            A a1 = new A ();
            a1.method2 ();

            del2 d3 =A.method3;
            d3(10, 20);

            //anoymous method
            anony show = delegate ()
            {
                Console.WriteLine("on the spot method");
            };


            Console.ReadKey();  
        }
    } 
}
