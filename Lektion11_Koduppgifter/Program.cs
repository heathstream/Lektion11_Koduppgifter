namespace Lektion11_Koduppgifter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine($"Hello Git from {name}!");
        }
    }

    public class Person
    {
        string Name { get; set; }
        int Age { get; set; }
    }
}
