using System;
using System.Diagnostics;
using System.Text;


namespace Basic
{
    class Nullable
    {
        class Program
        {
            static void Main(string[] args)
            {
                Nullable<int> i = null;
                Console.WriteLine("i=" + i);
                Console.WriteLine(i.GetValueOrDefault());
                if (i.HasValue)
                    Console.WriteLine(i.Value); // or Console.WriteLine(i)
                else
                    Console.WriteLine("Null");
                int? x = null;
                int j = x ?? 0;
                Console.WriteLine("x = {0}, j = {1}", x, j);
                Console.WriteLine("x >= 10 ? {0}", x >= 10);
                Console.WriteLine("x < 10 ? {0}", x < 10);
                if (System.Nullable.Compare<int>(i, j) < 0)
                    Console.WriteLine("i < j");
                else if (System.Nullable.Compare<int>(i, j) > 0)
                    Console.WriteLine("i > j");
                else
                    Console.WriteLine("i = j");
            }
        }
    }
}
