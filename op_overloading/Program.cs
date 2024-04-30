using System;

namespace op_overloading
{
    class A
    {
        private int a;
        private int b;  

        public A()
        {

        }

        public A(int i, int j)
        {
            a = i;
            b=j;

        }
        public void method1() 
        {
            Console.WriteLine("a=" +a+" b="+b);
        }
        public static A operator -(A a)      //unary operator
        {
            A temp = new A();
            temp.a = -a.a;
            temp.b = -a.b;
            return temp;
        }

        public static A operator +(A s, A t)
        {
            A temp = new A();
            temp.a = s.a + t.a;
            temp.b = s.b + t.b;
            return temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A(10,13);
            a1.method1 ();
            A a2 = new A();
            a2 = -a1;
            Console.WriteLine("unary operator");
            a2.method1 ();

            Console.WriteLine("binary operator");
            A a3 = new A();
            A a4 = new A(40,50);
            A a5 = new A(40,50);
            a3 = -a4 + -a5;
            a3.method1 ();

            Console.ReadLine();
        }
    }
}
