using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMenagment
{
    internal class Student
    {
        private static int _id;
        public int Id { get; set; }
       
        public string FullName { get; set; }
        public double Point { get; set; }
        public Student(string fullname, double point)
        {
            Id = ++_id;
            FullName = fullname;
            Point = point;

        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id} Full name: {FullName}  Point: {Point}");
        }
    }
}
