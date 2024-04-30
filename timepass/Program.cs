using System;

namespace timepass
{
    interface C
    {
       abstract void method1();
        
    }
    abstract class A:C
    {
         void C.method1() {
            Console.WriteLine("Abstract class extended method");
        }

        public abstract void method2();
    }

    class B : A,C 
    {
        void C.method1()
        {
            Console.WriteLine("class B method of interface");
        }

        public override void method2()
        {
            Console.WriteLine("overridden method body in class B");
        }
    }
    class D : A
    {
        public override void method2()
        {
            Console.WriteLine("class D abstract method2 ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new B();
            c.method1();

            B b = new B();
            b.method2 ();

            B t = new B();
            t.method2 ();

            D d = new D();
            
            
        }
    }
}
