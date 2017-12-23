using System;
using System.Threading.Tasks;

namespace AsyncTest002
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> t = F(5000);
            Task<string> u = F(10000);

            Console.WriteLine("x");
            Console.WriteLine(u.Result);
            Console.WriteLine(t.Result);

            Console.ReadLine();
        }

        static async Task<string> F(int ms)
        {
            await Task.Delay(ms);
            return ms.ToString();
        }
    }
}
