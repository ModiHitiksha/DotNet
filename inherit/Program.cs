using System;

namespace inherit
{
    class A
    {
        public int x;
        public int y;
        public A() {
            x = 10;   
        }  
        public A(int a)
        {
            y= a;
            Console.WriteLine("base class parameter construct "+y);

        }
        public virtual void method1()

        {
            Console.WriteLine("Base class method 1");   
        }
        public void method2() {
            Console.WriteLine("base class virtual method");
        }

    }
    class B:A
    {
        int x;
        public int a;
        public B() {
            x = 15;
        }

        //xvalue assigned to the parameterized constructor of base class A 
      /*  public B(int x, int y) : base(x)
        {
            a = y;
            Console.WriteLine("DERIVED B CLASS "+a);
        }*/

        public override void method1()   //inheritance class A method overwritten 
        {
           Console.WriteLine("Derived class");
        }

        public  void method2()
        {
            Console.WriteLine("derived class overridden method");
        }
    }

    class C:B 
    { 
        public override void method1() 
        { Console.WriteLine("derived class c method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            A a1 = new A();
            B b1 = new B();
            C c1 = new C();


            //over riding 
            A k = a1;                                     //creating reference of base classA
            k.method1();

            k=b1;
            k.method1();

            k = c1;
            k.method1();
            
          //  a1 = k;                                   //calling base class method
            //a1.method1 ();
            
         //   k.method2 ();                                //overriden method
         //   a1.method2 ();                             //calling virtual method
           
            
            Console.ReadLine(); 
            
        }
    }
}
