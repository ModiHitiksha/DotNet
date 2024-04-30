using System;

namespace over_hiding
{
    class A
    {
     
        public static void method1()
        {
            Console.WriteLine("Base class static method 1");
        }
        public virtual void method2() 
        {
            Console.WriteLine("base class method 2");
        }
    }

    class B:A 
    {
        public static void method1()
        {
            Console.WriteLine("Derived class B method1");
        }

        public override void method2()        //overriding the base class method
        {
            Console.WriteLine("derived class B method 2");
        }
    }
    class C : B
    {
        public static void method1()
        {
            Console.WriteLine("Derived class C method1");
        }

        public new void method2()
        {
            Console.WriteLine("derived class C method 2");
        }
    }
//sealed
    class cars
    {
        public virtual void car1()
        {
            Console.WriteLine("swift 1st car");
        }
    }
    class vehicle : cars
    {
        sealed override public void car1()          
        {
            Console.WriteLine("swift 2nd car");
        }
    }

    class bus : vehicle
    {
        public void car1()
        {
            Console.WriteLine("swift 3rd car");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.method2 ();
            A.method1 ();

            B b1 = new B();
            C c1 = new C();

            A t = a1;
            t.method2();

            t = b1;
            t.method2 ();

            t= c1;
            t.method2();


            cars c2 = new cars();
            vehicle v1 = new vehicle();
            bus b2 = new bus();


            cars t1 = c2;
            t1.car1 ();

            t1 = v1;
            t1.car1();

            t1 = b2;
            t1.car1();
            

            Console.ReadLine();


        }
    }
}
