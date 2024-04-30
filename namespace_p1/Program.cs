using System;
using name_p2;


namespace namespace_p1
{
    public class A1
    {
        public void method1()
        {
            Console.WriteLine("method of first space");

        }
    }
    public class m1
    {
        public static void Main()
        {
            namespace_p1.A1 a1 = new namespace_p1.A1();
            a1.method1();

            name_p2.A2 a2 = new name_p2.A2();
            a2.method2();

            Console.ReadKey();
        }
    }
}

namespace name_p2
{
    public class A2
    {
        public void method2()
        {
            Console.WriteLine("method of second class");
        }
    }
}
