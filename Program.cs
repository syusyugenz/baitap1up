using System;

namespace AsciiStringTest
{
     public class Program
    {
        public static void Main(string[] args)
        {
            AsciiString ascii = new AsciiString('H', 'e', 'l', 'l', 'o');

            // In chuỗi ban đầu
            Console.WriteLine("Original: " + ascii.ToString());

            // Chuyển đổi thành chữ in hoa
            AsciiString upperAscii = ascii.ToUpper();
            Console.WriteLine("Upper: " + upperAscii.ToString());

            // Chuyển đổi thành chữ thường
            AsciiString lowerAscii = ascii.ToLower();
            Console.WriteLine("Lower: " + lowerAscii.ToString());

            // Tìm chỉ số của ký tự
            char characterToFind = 'e';
            int index = ascii.FindIndex(characterToFind);
            Console.WriteLine($"Index of '{characterToFind}': " + index);

            // // Thử hợp nhất hai AsciiString
            // AsciiString ascii2 = new AsciiString(' ', 'W', 'o', 'r', 'l', 'd');
            // AsciiString combined = AsciiString.Operate(ascii, ascii2);
            // Console.WriteLine("Combined: " + combined.ToString());
        }
    }
}