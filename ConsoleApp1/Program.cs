
using System.ComponentModel;

namespace ConsoleApp1
{
    class Animal
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        public void disPlayName()
        {
            Console.WriteLine(name);
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.Name = "Test";
            cat.disPlayName();
        }
    }
}
