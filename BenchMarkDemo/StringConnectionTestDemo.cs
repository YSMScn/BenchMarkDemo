using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchMarkDemo
{
    [MemoryDiagnoser]
    public class StringConnectionTestDemo
    {

        [Benchmark]
        public string ConnectStringsUsingPlus()
        {
            var result = string.Empty;
            foreach (var s in GenerateStringList())
            {
                result = result + s;
            }
            return result;
        }
        [Benchmark]
        public  string ConnectStringUsingStringBuilder()
        {
            var stringbuilder = new StringBuilder();
            foreach (var s in GenerateStringList())
            {
                stringbuilder.Append(s);
            }
            return stringbuilder.ToString();
        }

        public List<string> GenerateStringList()
        {
            var stringList = new List<string>();
            for (var i = 0; i < 10000; i++)
            {
                stringList.Add(i.ToString());
            }
            return stringList;
        }


    }
}
