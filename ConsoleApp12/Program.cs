using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Now;
            DateTime d2 = DateTime.UtcNow;
            DateTime d3 = data.AddDays(1);
            
            TimeSpan t = new TimeSpan(0, 5, 22);
            DateTime d4 = data.Subtract(t);

            DateTime d5 = DateTime.Parse("2000-09-28T13:38:38Z");




            Console.WriteLine(data);
            Console.WriteLine(d2.ToLocalTime());
            Console.WriteLine(d3);
            Console.WriteLine(t);
            Console.WriteLine(data.ToUniversalTime());
            Console.WriteLine(d5);
            Console.WriteLine(d5.ToUniversalTime());
            Console.WriteLine("teste");
            
        }
    }
}
