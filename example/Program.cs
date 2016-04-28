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
            Console.WriteLine(Environment.CurrentDirectory.md5());
            try
            {
                string html = Request.get("http://qt.hk/contact/", "qthkabc");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}
