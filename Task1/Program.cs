using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Student {
       public string first_name;
       public string last_name;
       public int gpa;
       public int age;

       public string GetInfo()
       {

           return first_name + " " + last_name+ " " + gpa + " " + age;
       }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            a.first_name="Zere";
            a.last_name = "Zarkymova";
            a.gpa = int.Parse("3");
            a.age = int.Parse("17");
            Console.WriteLine(a.GetInfo());

        
        }
    }
}
