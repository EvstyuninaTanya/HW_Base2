using System;

namespace HW_Base2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "аЕавасатаюанаианаа";

            int n = 0;

            for (int i = 1; i < s.Length; i = i+2)
            {
                Console.Write(s[i]);
            }

        }
    }
}
