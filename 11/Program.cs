using System;
using System.Collections.Generic;
using System.Linq;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> Foo = new List<List<string>>() { };
            List<string> list1 = new List<string>() { "1", "a" };
            List<string> list2 = new List<string>() { "1", "b" };
            List<string> list3 = new List<string>() { "2", "a" };
            List<string> list4 = new List<string>() { "2", "b" };
            List<string> list5 = new List<string>() { "x", "y", "z" };
            Foo.Add(list1);
            Foo.Add(list2);
            Foo.Add(list3);
            Foo.Add(list4);
            Foo.Add(list5);

            List<List<string>> result = new List<List<string>>();
            List<String> temp3 = Foo.ElementAt(Foo.Count-1);
            for (int i = 0; i < Foo.Count; i++)
            {
                for (int j = 0; j < temp3.Count; j++)
                {
                    List<string> arrString = new List<string>();
                    arrString.Add(temp3[j]);
                    var merge=  Foo[i].Concat(arrString).ToList();
                    result.Add(merge);
                }
            }
        }
    }
}
