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
