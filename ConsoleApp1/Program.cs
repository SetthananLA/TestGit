
namespace ConsoleApp1
{
    class Animal
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.Name = "Test";
            Console.WriteLine(cat.Name);
        }
    }
}
