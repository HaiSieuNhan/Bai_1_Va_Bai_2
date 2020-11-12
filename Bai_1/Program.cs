using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai_1
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
            List<string> list = new List<string>() { "1", "2" };
            List<string> list1 = new List<string>() { "a", "b" };
            List<string> list2 = new List<string>() { "x", "y", "z" };
            Foo.Add(list);
            Foo.Add(list1);
            Foo.Add(list2);
            GhepPhanTuNangCao(Foo);
        }
        static void GhepPhanTuNangCao(List<List<string>> Foo)
        {
            List<List<string>> result = new List<List<string>>();
            for (int i = 0; i < Foo.Count - 1;)
            {
                for (int x = 0; x < Foo[i].Count; x++)
                {
                    List<String> temp2 = Foo.ElementAt(i + 1);
                    for (int j = 0; j < temp2.Count; j++)
                    {
                        List<String> temp3 = Foo.ElementAt(i + 2);
                        for (int k = 0; k < temp3.Count; k++)
                        {
                            List<string> arrString = new List<string>();
                            arrString.Add(Foo[i][x]);
                            arrString.Add(temp2[j]);
                            arrString.Add(temp3[k]);
                            result.Add(arrString);
                        }
                    }
                }
                break;
            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write("Mang Thu "+i+" :");
                for (int j = 0; j < result[i].Count; j++)
                {
                    Console.Write("\t"+result[i][j]);
                }
                Console.WriteLine();
                Console.WriteLine();

            }

        }

    }
}
