using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingLambda
{
    /*
     * More examples: 
     * https://www.c-sharpcorner.com/UploadFile/0f68f2/using-lambda-expression-over-a-list-in-C-Sharp/
     * https://linqsamples.com/linq-to-objects
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Animal> animals = new List<Animal>();

            Animal animal1 = new Animal("Hela", 2, "dog");
            Animal animal2 = new Animal("Loki", 3, "cat");
            Animal animal3 = new Animal("Luna", 5, "cat");

            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);

            Console.WriteLine("Display all cats");
            var result = animals.Where(x => x.Type == "cat").ToList(); 
            result.ForEach(x => x.PrintInfo());

            Console.WriteLine("\nDisplay animals younger than 4 years");
            animals.Where(x => x.Age < 4).ToList().ForEach(x=> x.PrintInfo());

            Console.WriteLine("\nMax age");
            Console.WriteLine(animals.Max(x => x.Age));

            Console.WriteLine("\nLast animal in list");
            animals.Last().PrintInfo();
      
        }
    }
}