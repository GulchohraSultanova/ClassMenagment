using System.ComponentModel.Design;

namespace ClassMenagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = null; ;
            Console.WriteLine("Enter full name:");
            string name = Console.ReadLine();
            double point;
            do
            {
                Console.WriteLine("Enter the point:");
            } while (!double.TryParse(Console.ReadLine(), out point));
            Student student = new Student(name, point);
            bool flag = false;
            string no = "";
            int studentLimit = 0, id;
            MENU1:
            do
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-----------Welcome my GroupApp-----------");
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Show info!");
                Console.WriteLine("2.Create new group!");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();
              
                switch (choice)
                {

                    case "1":
                        student.StudentInfo();
                        break;
                    case "2":


                        do
                        {
                            Console.WriteLine("Enter the group name: ");
                            no = Console.ReadLine();

                        } while (!Group.CheckGroupNo(no));
                        do
                        {
                            Console.WriteLine("Enter the student limit: ");

                        } while (!int.TryParse(Console.ReadLine(), out studentLimit) || studentLimit < 6 || studentLimit > 18);
                        group = new Group(no, studentLimit);
                        group.AddStudent(student);
                        goto MENU;
                }
            }
            while (!flag);
            


            MENU:
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Show all students!");
                Console.WriteLine("2.Get student by id!");
                Console.WriteLine("3.Add student in group!");
                Console.WriteLine("0.Exit GroupApp....");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                string choice1 = Console.ReadLine();
                switch (choice1)
                {
                    case "1":
                        foreach (var item in group.GetAllStudents())
                        {
                            
                                item.StudentInfo();
                        }
                        goto MENU;
                    case "2":
                        do
                        {
                            Console.WriteLine("Enter the searching id: ");

                        } while (!int.TryParse(Console.ReadLine(), out id));
                        group.GetStudent(id).StudentInfo();
                        goto MENU;
                    case "3":
                        Console.WriteLine("Enter full name:");
                        string name1 = Console.ReadLine();
                        double point1;
                        do
                        {
                            Console.WriteLine("Enter the point:");
                        } while (!double.TryParse(Console.ReadLine(), out point1));
                        Student student1 = new Student(name1, point1);
                    group.AddStudent(student1);
                        goto MENU;
                    case "0":
                        Console.WriteLine("Exiting the program...");
                     goto MENU1;

                    default:
                        Console.WriteLine("This is not correct! Please, enter correct choice!");
                        break;
                }
              

            
            
        }
    }
}