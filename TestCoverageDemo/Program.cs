namespace TestCoverageDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Balto");
            Console.WriteLine(dog.Bark());

            Console.ReadLine();
        }
    }

    public class Dog
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public string Bark()
        {
            return Name;
        }
    }
}