using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>()
            {
                { 1, "Ukraine" },
                { 2, "Russia"},
                { 3, "Poland"},
                { 4, "USA"}
            };
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            Dictionary<int, string> d2 = new Dictionary<int, string>();
            Console.WriteLine("in list");
            foreach (KeyValuePair<int, string> i in d)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");
            }
            int k;
            Console.Write("key=");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("list for key");
            foreach (KeyValuePair<int, string> i in d)
            {
                if (i.Key <= k)
                {
                    Console.WriteLine($"{i.Key} - {i.Value}");
                    d1.Add(i.Key, i.Value);
                }
                else
                {
                    d2.Add(i.Key, i.Value);
                }
            }
            Console.WriteLine("out dic 1");
            string jsond1 = JsonConvert.SerializeObject(d1, Formatting.Indented);
            Console.WriteLine(jsond1);
            Console.WriteLine("out dic 2");
            string jsond2 = JsonConvert.SerializeObject(d2, Formatting.Indented);
            Console.WriteLine(jsond2);
        }
    }
}
