using staticandsealedandnullabletask.Models;

namespace staticandsealedandnullabletask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student("Fateh Aliverdiev");
            //Student student3 = new Student("fateh Aliverdiev");
            //Student student2= new Student("Fateh      Aliverdiev");
            //Student student1 = new Student("Fateh aliverdiev");
            //Console.WriteLine(student.Fullname);
            //Console.WriteLine(student1.Fullname);
            //Console.WriteLine(student2.Fullname);
            //Console.WriteLine(student3.Fullname);
            //Console.WriteLine(Student.Count);
            while (true)
            {           
                Console.WriteLine("Enter fullname :");
                string fullname = Console.ReadLine();                
                if (Student.CheckFullname(fullname))
                {
                    Student student1 = new Student(fullname);
                    Student student2 = new Student(fullname);
                    Student student = new Student(fullname);

                    Console.WriteLine(student.Id+ " " +fullname);
                    Console.WriteLine("Student Added");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong fullname try again!");
                }


            }
        }
    }
}