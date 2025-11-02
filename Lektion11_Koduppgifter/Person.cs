using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion11_Koduppgifter
{
    public class Person
    {
        string Name { get; set; }
        int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello! My name is {Name} and I'm {Age} years old.");
        }
    }
}
