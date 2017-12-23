using System;
using static System.Console;

namespace FluentGenericMethods
{
    class Program
    {
        static void Main()
        {
            var f = MensuringTimeOf(PrintingResultsOf((Func<int, int>)IncrementerOne));
            f(1);

            var f2 = ((Func<int, int>)IncrementerOne).Map(PrintingResultsOf).Map(MensuringTimeOf);
            f2(2);

            f(3);

            f2(4);


            ReadLine();
        }

        static int IncrementerOne(int a) => a + 1;


        static Func<T, TResult> MensuringTimeOf<T, TResult>(Func<T, TResult> func) => (input) =>
        {
            var before = DateTime.Now;
            var result = func(input);
            var totalTime = DateTime.Now - before;

            WriteLine($"Time for {input}: {totalTime}");

            return result;
        };

        static Func<T, TResult> PrintingResultsOf<T, TResult>(Func<T, TResult> func) => (n) =>
        {
            var result = func(n);

            WriteLine($"Result for {n} is {result}");

            return result;
        };
    }

    static class Extensions
    {
        public static Func<T, TResult> Map<T, TResult>(this Func<T, TResult> input, Func<Func<T, TResult>, Func<T, TResult>> mapperFunc) => mapperFunc(input);
    }
}