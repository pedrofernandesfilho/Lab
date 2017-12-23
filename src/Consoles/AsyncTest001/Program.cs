using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTest001
{
    class Program
    {
        static string f;
        static string g;

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            F();
            G();
            Console.WriteLine(f + g);

            Console.ReadLine();
        }

        static async void F()
        {
            //Console.WriteLine("F start");
            await Task.Delay(10);
            f = "Hello";
            //Console.WriteLine("F end");
        }

        static async void G()
        {
            //Console.WriteLine("G start");
            Thread.Sleep(10);
            g = " World!";
            //Console.WriteLine("G end");
        }
    }
}
