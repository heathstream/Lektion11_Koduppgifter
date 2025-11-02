namespace Lektion11_Koduppgifter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine($"Hello Git from {name}!");

            Person person = new("Anders", 32);
            person.Introduce();
        }
    }

    public enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }

    public struct StudentRecord
    {
        public string StudentName;
        public Grade StudentGrade;
        public DateTime ExamDate;
    }
}
