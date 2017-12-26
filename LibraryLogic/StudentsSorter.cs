using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic
{


    public class StudentsSorter
    {
        public List<Student> Students { get; set; }

        public StudentsSorter(List<Student> students)
        {
            this.Students = students;
        }

        private List<Student> GetStudentsWithMaxPoint(int course, Sex sex)
        {
            int maxPoints = 0;

            foreach (Student student in Students) {
                if (student.Course != course || student.Sex != sex)
                    continue;

                if (student.Points > maxPoints) {
                    maxPoints = student.Points;
                }
            }

            return Students.Where(student => (student.Course == course && student.Sex == sex && student.Points == maxPoints)).ToList();
        }

        public List<Pair> GetStudentsForParty()
        {
            Random rnd = new Random();

            List<int> courses = new List<int>();

            // Отбираем набор возможных курсов
            foreach (Student student in Students) {
                if (!courses.Contains(student.Course))
                    courses.Add(student.Course);
            }

            List<Pair> pairs = new List<Pair>();

            foreach (int course in courses) {
                List<Student> boys = GetStudentsWithMaxPoint(course, Sex.Male);
                List<Student> girls = GetStudentsWithMaxPoint(course, Sex.Female);

                Student boy = (boys.Count > 0) ? boys[rnd.Next(boys.Count)] : null;
                Student girl = (girls.Count > 0) ? girls[rnd.Next(girls.Count)] : null;

                pairs.Add(new Pair(boy, girl, course));
            }

            pairs.Sort((a, b) => a.Course - b.Course);

            return pairs;
        }
    }
}
