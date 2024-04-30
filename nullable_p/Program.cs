using System;

namespace nullable_p
{
    class A
    {
        public string[] names = new string[5];
        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //nullable program

           int? x = null;
           Nullable<int> y = null;
           int? z = 1000;
           int z1 = 130;
           int a=x.GetValueOrDefault(); //returns the value if null returns 0
           int b = z ?? 20;

            Console.WriteLine(b);
            Console.WriteLine(a);
            
            if(Nullable.Compare<int>(z,z1)<0) 
            {
                Console.WriteLine(z1 + " is greater");
            }
            else if(Nullable.Compare<int>(z,z1)>0)
            { 
                Console.WriteLine(z + " is greater");
            }
            else
            {
                Console.WriteLine("both are equals");
            }


            A a1 = new A();
            a1[0] = "Hitiksha";
            a1[1] = "vatsal";
            a1[2] = "kunjal";
            a1[3] = "paresh";
            a1[4] = "tanish";


            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine(a1[i]);
            }

            Console.ReadLine();


        }
    }
}
