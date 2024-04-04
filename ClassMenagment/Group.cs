using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassMenagment
{
    internal class Group
    {
        public string GroupNo { get; set; }
        public int StudenLimit { get; set; }
        private Student[] Students=new Student[0];
        public Group(string groupNo, int studentLimit)

        {
            GroupNo = groupNo;
            StudenLimit = studentLimit;


        }
        public void AddStudent(Student student)
        {
            if (Students.Length < StudenLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Group is Full");
            }

        }
        public Student GetStudent(int id)
        {
          foreach (Student student in Students)
            {
                if(student.Id == id ) 
                    return student;    
            }
            return null;

        }
        public Student[] GetAllStudents()
        {
            return Students;
        }
        public static bool CheckGroupNo(string no)
        {
            if (no.Length != 5)
            {
                return false;
            }

            if (!char.IsUpper(no[0]) || !char.IsUpper(no[1]))
            {
                return false;
            }
            if (!char.IsDigit(no[2]) || !char.IsDigit(no[3]) || !char.IsDigit(no[4]))
            {
                return false;
            }
            return true;
        }
    }
}
