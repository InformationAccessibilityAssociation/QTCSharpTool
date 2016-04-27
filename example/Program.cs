using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QTCSharpTool;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "abc";
            Console.WriteLine(a.md5());
            Console.WriteLine(a.UrlEncode());
        }
    }
}
