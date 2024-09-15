using System;

namespace AsciiStringTest
{
     public class Program
    {
        public static void Main(string[] args)
        {
            AsciiString ascii = new AsciiString('H', 'e', 'l', 'l', 'o');
            ascii.ToUpper1();
        }
    }
}