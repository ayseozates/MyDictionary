using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string>Plaka = new MyDictionary<int, string>();
            Plaka.Add(23, "Elazığ");
            Plaka.Add(12, "Bingöl");
            //foreach (KeyValuePair<string, string> kvp in myDictionary)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //}
        }
    }
}
