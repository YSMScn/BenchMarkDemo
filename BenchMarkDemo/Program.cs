using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

namespace BenchMarkDemo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello BenchMark Test has started!");
            var summary = BenchmarkRunner.Run<StringConnectionTestDemo>();
            Console.WriteLine("Done");

        }
        
    }
}