using System;
using System.Collections.Generic;

namespace labgit
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            for(var i = 0; i < 10; i++)
            {
                list.Add(i);
                list.Add(i+1);
            }

            foreach (var el in list)
            {
                Console.WriteLine(el);
            }
        }
    }
}
