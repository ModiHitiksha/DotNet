using System;

namespace practice
{ //enum class,var,dynamic

    internal class Program
    {
        enum city
        {
            vadodara,
            surat,
            bharuch,
            ankleshwar,
            ahemdabad
        }
        static void Main(string[] args)
        {
            //enum conversion
            int c1 = (int)city.vadodara; //string to int conversion-- op is index value
            Console.WriteLine(c1);

            var c2 = (city)1;
            Console.WriteLine(c2); //int to string conversion--op is the name on index number

            double y = 3.14;
            int x = (int)y;
            Console.WriteLine(x);

            char z = 'x';
            string s = "modi";
       
            //dynamic prints the last allocated value
            dynamic a;
            a = 10;
            a = 13;
            Console.WriteLine(a);

            object o;
            o = a;
            o = y;
            Console.WriteLine(o); //prints the last variable assigned

            //var can be assigned int and string both
            var a1 = 30;
            var a2 = "hii";
            Console.WriteLine(a1);
            Console.WriteLine(a2);

            Console.ReadLine();
        }
    }
}
