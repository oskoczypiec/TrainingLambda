using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLambda
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public Animal(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }

        public void  PrintInfo()
        {
            Console.WriteLine($"{Name} {Age} {Type}");
        }
    }
}
