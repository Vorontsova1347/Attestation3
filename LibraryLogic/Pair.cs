using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic
{
    public class Pair
    {
        public Student Boy { get; set; }
        public Student Girl { get; set; }

        public int Course { get; set; }

        public Pair(Student boy, Student girl, int course) {
            this.Boy = boy;
            this.Girl = girl;
            this.Course = course;
        }
    }
}
