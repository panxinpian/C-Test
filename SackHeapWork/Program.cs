using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SackHeapWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = ReturnValue2();
            Console.WriteLine(x);
            Console.ReadKey();
        }

        public static int ReturnValue()
        {
            int x = new int();
            x = 3;
            int y = new int();
            y = x;
            y = 4;
            return x;
        }
        public static int ReturnValue2()
        {
            MyInt x = new MyInt();
           
            x.MyValue = 3;
            MyInt y = new MyInt();
            y = x;
            y.MyValue = 4;
            return x.MyValue;
        }

    }

    public class MyInt
    {
        public int MyValue;
    }
}
