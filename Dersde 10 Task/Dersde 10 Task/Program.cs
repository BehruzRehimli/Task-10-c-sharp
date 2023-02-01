using System;
using Clas;

namespace Dersde_10_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clas.Student student1 = new Clas.Student();
            Clas.Student student2 = new Clas.Student();
            Clas.Student student3 = new Clas.Student();
            Console.WriteLine(student2.No);
            student3.GroupNo = "P23g";
            Console.WriteLine(student3.GroupNo);



            Student st1= new Student();
            Student st2= new Student();
            Student st3= new Student();
            Console.WriteLine(st1.No);




            Console.WriteLine("User Name daxil edin");
            string input= Console.ReadLine();
            string input2;
            do
            {
                Console.WriteLine("Password daxil edin"); 
                input2 = Console.ReadLine();
            } while (!CheckPassword(input2));
        }
        static bool CheckPassword(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || input.Length < 8 || input.Length > 25)
            {
                return false;
            }
            else
            {
                foreach (var item in input)
                {
                    if (char.IsDigit(item))
                    {
                        return true;
                    }
                }
            }
            return false;

        }



    }
}
