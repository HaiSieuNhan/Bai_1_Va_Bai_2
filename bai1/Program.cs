using System;
using System.Collections.Generic;
using System.Linq;

namespace bai1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Bai 1:
            //Viết console application để thực hiện hoá hàm sau, và in ra kết quả lên màn hình console

            //public string[][] GhepPhanTuNangCao(params string[][] args)
            //{
            //    // đầu vào là 1 mảng, trong mỗi phần tử là 1 mảng 1 chiều
            //    //vd: args=[ ["1","2"], ["a","b"], ["x","y","z"] ];
            //    //return [[ "1", "a","x" ], [ "1", "a","y" ] , [ "1", "a","z" ] , ... , , [ "2", "b","z" ]]
            //}

            List<List<string>> Foo = new List<List<string>>() { };
            List<string> list = new List<string>() { "1", "a" };
            List<string> list6 = new List<string>() { "1", "b" };
            List<string> list7 = new List<string>() { "2", "a" };
            List<string> list8 = new List<string>() { "2", "b" };
            //List<string> list1 = new List<string>() { "a", "b" };
            List<string> list2 = new List<string>() { "x", "y", "z" };
            List<string> list3 = new List<string>() { "Ac", "Bb", "Cc" };
            //List<string> list4 = new List<string>() { "XX", "YY", "ZZ" };

            //Foo.Add(list);
            //Foo.Add(list1);
            Foo.Add(list2);
           // Foo.Add(list3);
            //Foo.Add(list4);

            List<List<string>> result = new List<List<string>>();
            result.Add(list);
            result.Add(list6);
            result.Add(list7);
            result.Add(list8);

            List<List<string>> RList = new List<List<string>>();
            List<List<string>> KQQ = new List<List<string>>();


            for (int i = 0; i < Foo.Count; i++)
            {
                result = Ghep2Mang2(result, Foo[i]);

                //break;
            }
            for (int i = 0; i < RList.Count; i++)
            {
                Console.Write("Mang Thu " + i + " :");
                for (int j = 0; j < RList[i].Count; j++)
                {
                    Console.Write("\t" + RList[i][j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }



        }



        private static List<List<string>> Ghep2Mang(List<string> a, List<string> b)
        {
            List<List<string>> KQ = new List<List<string>>();
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < b.Count; j++)
                {
                    List<string> arrString = new List<string>();
                    arrString.Add(a[i]);
                    arrString.Add(b[j]);
                    KQ.Add(arrString);
                }
            }
            return KQ;
        }
        private static List<List<string>> Ghep2Mang2(List<List<string>> a, List<string> b)
        {
            List<List<string>> KQ = new List<List<string>>();
            for (int i = 0; i < a.Count; i++)
            {
                
                for (int k = 0; k < b.Count; k++)
                {
                    List<string> arrString = new List<string>();
                    arrString = a[i];
                    arrString.Add(b[k]);
                    KQ.Add(arrString);
                    a[i].Remove(b[k]);
                }
            }
            return KQ;
        }
        //}
        static void GhepPhanTuNangCao(List<List<string>> Foo)
        {



        }
    }
}
