using System;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết console application để thực hiện hoá hàm sau, và in ra kết quả lên màn hình console

            //public string ChangeToText(long NumberOfVersion)
            //{
            //    // do your code here
            //    // if NumberOfVersion < 1000000 return text (eg: NumberOfVersion =1 return "Mot", NumberOfVersion=99999 return "Chin muoi chin nghin chin tram chin chin" ...
            //    //else return NumberOfVersion.ToString()
            //}
            Console.WriteLine("Nhap vao So Cua Ban ; ");
            string[] Ones = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
            string[] Tens = { "Mười", "Hai Mươi", "Ba Mươi", "Bốn Mươi", "Năm Mươi", "Sáu Mươi", "Bảy Mươi", "Tám Mươi ", "Chín Mươi " };
            int number = int.Parse(Console.ReadLine());
            string strWords = "";
            if (number > 99999 && number < 1000000)
            {
                int i = number / 100000;
                strWords = strWords + Ones[i - 1] + " Trăm ";
                number = number % 100000;
            }
            if (number > 9999 && number < 100000)
            {
                int i = number / 10000;
                strWords = strWords + Ones[i - 1] + " Mươi ";
                number = number % 10000;
            }
            if (number > 999 && number < 10000)
            {
                int i = number / 1000;
                strWords = strWords + Ones[i - 1] + "  Nghìn ";
                number = number % 1000;
            }
            if (number > 99 && number < 1000)
            {
                int i = number / 100;
                strWords = strWords + Ones[i - 1] + " Trăm ";
                number = number % 100;
            }
            if (number > 19 && number < 100)
            {
                int i = number / 10;
                strWords = strWords + Tens[i - 1] + " ";
                number = number % 10;
            }
            if (number > 0 && number < 20)
            {
                strWords = strWords + Ones[number - 1];
            }
            Console.WriteLine(strWords);
        }
    }
}
