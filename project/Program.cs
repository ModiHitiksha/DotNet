using System;

namespace abstract_class   
{
    abstract class A
    {
        public abstract void method1();       //abstract method which needs to be overridden 

        public void method2()
        {
            Console.WriteLine("base abstract class method2");
        }
       
    }

    class B:A
    {
        public override void method1()
        {
            Console.WriteLine("abstract class body in B");
        }

    }

    class C:B 
    {
        public new void method1()
        {
            
            Console.WriteLine("this is class c abstract body");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            b1.method1();

            C c1 = new C();
            c1.method1();

           /* A t = new B();
            t.method2();
            t.method1();
           */
           Console.ReadKey();
        }
    }
}
