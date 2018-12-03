using System.Text;
using System;

namespace csFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");

            builder
            .Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10)

            .Replace('-', '+')

           .Remove(0,10)

            .Insert(0, new string('-', 10));

            System.Console.WriteLine(builder);

            Console.WriteLine("First Char " + builder[0]);
        }
    }
}
