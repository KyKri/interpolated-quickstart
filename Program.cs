using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolatedStrings
{
    class Program
    {
        public class Vegetable
        {
            public Vegetable(string name) => Name = name;

            public string Name { get; }

            public override string ToString() => Name;
        }

        public void PrintName()
        {
            var name = "<name>";
            Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");
        }

        static void Main(string[] args)
        {
            
        }
    }
}
