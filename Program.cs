using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string name;
        public static int countStudents = 0;
     

        public Student(string name)
        {
            this.name = name;
            countStudents++;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                Student currentStudent = new Student(command);

                command = Console.ReadLine();
            }

            Console.WriteLine(Student.countStudents);
        }
    }
}
