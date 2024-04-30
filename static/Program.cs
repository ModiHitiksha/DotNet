using System;

namespace static_p
{
    static class A 
    {
      private static int a;
        static int b;
     static A()
     {
          a=5;
          b=a+5;
     }

     public static void m1()
        {
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
    }

    class B
    {
         int a;
        static int b;
        static int c;
        int y;
        static B()
        {
            c = 2;
            b=c+1;
        }
        public B()
        {
            a = 10;
            y = a * 5;
        }
        public static void m2()
        {
            Console.WriteLine(b);
        }

        public void m3()
        {
            
            Console.WriteLine(a);
            Console.WriteLine(y);
        }
    }
    internal class Program
{
    static void Main(string[] args)
    {
            A.m1();
            Console.WriteLine("CLASS B");
            B b1 = new B();
            b1.m3();
            B.m2();

            Console.ReadLine();

        }
    }
}
