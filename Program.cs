using System;

namespace FunçõesParaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string origin = "   abc DEF GhI";
            string s1 = origin.ToLower();
            Console.WriteLine(s1);
            Console.WriteLine("-------------------------");
            string s2 = origin.ToUpper();
            Console.WriteLine(s2);
            Console.WriteLine("-------------------------");
            string s3 = origin.Trim();
            Console.WriteLine(s3);
            Console.WriteLine("-------------------------");
            bool b1 = string.IsNullOrWhiteSpace(origin);
            Console.WriteLine(b1);
            Console.WriteLine("-------------------------");
            string s4 = origin.Replace("G", "h");
            Console.WriteLine(s4);
            Console.WriteLine("-------------------------");
            int n1 = origin.IndexOf("a");
            Console.WriteLine(n1);
            Console.WriteLine("-------------------------");


        }
    }
}
