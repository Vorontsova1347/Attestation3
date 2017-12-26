using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryLogic
{
    public class StudentsFileUtils
    {
        public static List<Student> ReadStudentsListFromFile(string path)
        {
            List<Student> studentsList = new List<Student>();

            string[] lines = FileUtils.ReadStringArrFromFile(path);

            foreach (string line in lines)
            {
                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = parts[0] + " " + parts[1] + " " + parts[2];
                string sex = parts[3];
                int course = int.Parse(parts[4]);
                int points = int.Parse(parts[5]);

                studentsList.Add(new Student(name, sex, course, points));
            }

            return studentsList;
        }

        public static void SaveStudentsListInFile(string path, List<Student> students)
        {
            List<string> lines = new List<string>();

            foreach (Student student in students)
            {
                lines.Add(student.FullName + " " + student.SexValue + " " + student.Course + " " + student.Points);
            }

            FileUtils.WriteStringArrToFile(path, lines.ToArray());
        }
    }
}