using System;

namespace struct_practice
{
    struct A
    {
        public int x;
      //  public int y = 12;   //cannot initialize value 
        public A(int a)    //cannot create default constructor in struct
        {
            x = a;
        }
        public static implicit operator int(A a)
        { return a.x; }

        public void method1()
        {
            int a = 60;
            Console.WriteLine(a);   
        }
        public static void method2()
        {
            int b = 20;
            Console.WriteLine(b);
        }
    }
    internal class Program

    {
        static void Main(string[] args)
        {
            A a = new A(10);
            Console.WriteLine(a.x);

            a.method1();
            A.method2();

        }

    }
}
