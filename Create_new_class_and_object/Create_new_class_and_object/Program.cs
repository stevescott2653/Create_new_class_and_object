using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_new_class_and_object
{
    public class Student
    {
        public int id;

        public String name;
    }

    class TestStudent
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.id = 101;
            s1.name = "John Doe";
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);

        }
    }
}
