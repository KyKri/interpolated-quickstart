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

        public enum Unit { item, kilogram, gram, dozen };

        public static void PrintName()
        {
            var name = "<name>";
            Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");
        }

        public static void Eggplant()
        {
            var item = new Vegetable("eggplant");
            var date = DateTime.Now;
            var price = 1.99m;
            var unit = Unit.item;
            Console.WriteLine($"On {date:d}, the price of {item} was {price:C2} per {unit}");
        }

        public static void WidthAndAlignment()
        {
            var titles = new Dictionary<string, string>()
            {
                ["Doyle, Arthur Conan"] = "Hound of the Baskervilles, The",
                ["London, Jack"] = "Call of the Wild, The",
                ["Shakespeare, William"] = "Tempest, The"
            };

            Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
            Console.WriteLine("Author and Title List");
            Console.WriteLine();
            Console.WriteLine($"|{"Author",25}|{"Title",30}|");
            foreach (var title in titles)
            {
                Console.WriteLine($"|{title.Key,25}|{title.Value,30}|");
            }
        }

        static void Main(string[] args)
        {
            //Eggplant();

            //PrintName();

            WidthAndAlignment();

            Console.ReadKey();
        }
    }
}
