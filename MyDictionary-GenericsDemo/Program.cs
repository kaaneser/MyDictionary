using System;
using System.Collections.Generic;

namespace MyDictionary_GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dict = new MyDictionary<string, string>();
            dict.Add("Ahmet", "Aşçı");
            dict.Add("Semih", "Asker");
            Console.WriteLine(dict.Length);
            dict.Add("Kaan", "Programcı");
            Console.WriteLine(dict.Length);
            Console.WriteLine(dict.Yazdir("Kaan"));
        }
    }
}
