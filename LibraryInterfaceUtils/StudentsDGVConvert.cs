using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryLogic;
using System.Windows.Forms;

namespace LibraryInterfaceUtils
{
    public class StudentsDGVConvert
    {
       public static List<Student> DGVToStudentList(DataGridView dgv)
       {
            List<Student> studentList = new List<Student>();

            foreach(DataGridViewRow row in dgv.Rows)
            {
                string fullName = row.Cells["FullName"].Value.ToString();
                string sex = row.Cells["Sex"].Value.ToString();
                int course = (int)Convert.ChangeType(row.Cells["Course"].Value, typeof(int));

                int points = (int)Convert.ChangeType(row.Cells["Marks"].Value, typeof(int));

                Student student = new Student(fullName, sex, course, points);

                studentList.Add(student);
            }
            return studentList;
       }

        public static void StudentListToDGV(DataGridView dgv, List<Student> studentList)
        {
            dgv.Rows.Clear();
           
            foreach (Student student in studentList)
            {
                dgv.Rows.Add();

                DataGridViewRow lastRow = dgv.Rows[dgv.RowCount - 1];
                lastRow.Cells["FullName"].Value = student.FullName;
                lastRow.Cells["Sex"].Value = student.SexValue;
                lastRow.Cells["Course"].Value = student.Course;
                lastRow.Cells["Marks"].Value = student.Points;
            }
        }
    }
}
