using System;

namespace partial_class
{
    partial class A
    {
     public void method1()
        {
            Console.WriteLine("partial class a");
        }  
    }
    partial class A
    {
        public void method3() 
        {
            Console.WriteLine("hey!!!");
        }
        public void method2() 
        {
            Console.WriteLine("helo");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.method1();
            a.method2 ();

        }
    }
}
