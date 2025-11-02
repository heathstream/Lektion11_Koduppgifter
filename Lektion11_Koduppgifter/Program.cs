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

            StudentRecord[] studentRecords = new StudentRecord[3];
            for (int i = 0; i < studentRecords.Length; i++)
            {
                studentRecords[i] = new StudentRecord();
                studentRecords[i].StudentName = "Test Testsson";
                studentRecords[i].StudentGrade = Grade.B;
                studentRecords[i].ExamDate = new DateTime(2025, 11, 14);
            }
            foreach (var record in studentRecords)
            {
                Console.WriteLine($"Student: {record.StudentName}, Grade: {record.StudentGrade}, Exam date: {record.ExamDate.ToString("d")}");
            }
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

        public bool IsPassingGrade() => StudentGrade > Grade.F;
    }
}
