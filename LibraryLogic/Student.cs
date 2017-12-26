using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic
{
    public enum Sex
    {
        Male, Female
    }

    public class Student
    {
        public string FullName { get; set; }
        public Sex Sex { get; set; }
        public string SexValue {
            get
            {
                return (Sex == Sex.Male) ? "м" : "ж";
            }
        }

        public int Course { get; set; }
        public int Points { get; set; }

        public Student(string fullName, string sex, int course, int points)
        {
            if (sex != "м" && sex != "ж")
                throw new ArgumentException();

            this.FullName = fullName;
            this.Sex = (sex == "м") ? Sex.Male : Sex.Female;
            this.Course = course;
            this.Points = points;
        }
            
            
    }
}
