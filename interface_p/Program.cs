using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace interface_p
{
    interface A
    {

        void m1();      //intrface method does not have a body
    }

    interface B
    {
        void m2();

        interface b1
        {
            virtual void city()
            {
                Console.WriteLine("vadodara");
            }
        }

        static void m3();
    }

    interface C
    {
        string s1 { get; set; }
    }

    class animal : A, B, B.b1
    {
        void A.m1()
        {
            Console.WriteLine("class animal m1");
        }
        void B.m2()
        {
            Console.WriteLine("method 2 inside animal");
        }
        void B.b1.city()
        {
            Console.WriteLine("ankleshwar");
        }
        void B.m3()
        {
            Console.WriteLine("static method m3");
        }
    }
    class birds : B, B.b1
    {
        void B.m2()
        {
            Console.WriteLine("method2 inside Birds");
        }
        void B.b1.city()
        {
            Console.WriteLine("surat");
        }
    }

    class insects : C
    {
        private string name;

        public string s1
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {
                A a = new animal();
                B b2 = new animal();
                B.b1 c2 = new animal();
                a.m1();
                b2.m2();
                c2.city();

                B b = new birds();
                B.b1 c = new birds();
                b.m2();
                c.city();

                var C = new insects();
                C.s1 = "hitiksha";

                Console.WriteLine(C.s1);


                Console.ReadKey();
            }
        }
    
}
