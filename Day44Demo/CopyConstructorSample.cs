using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day44Demo
{
    /*
     * Copy constructor
     * 1 - Parameterized constructor that contains object of same class type
     * 2. when you want to create a new object from existing object use copy constructor
     */
    public class Student
    {
        int Id;
        string Name;

        public Student(int valId, string valName)
        {
            Id = valId;
            Name = valName;           
        }

        public Student(Student obj)
        {
            Id = obj.Id;
            Name = obj.Name;
        }
        public void ShowData()
        {
            Console.WriteLine("Student name is {0} and Id is {1}", Name, Id);
        }

        public void UpdateName(string newName)
        {
            Name = newName;
        }
    }
    public class CopyConstructorSample
    {
        public void Demo()
        {
            Student s1 = new Student(10, "abc");

            //Student s2 = s1;

            Student s2 = new Student(s1);

            s1.UpdateName("xyz");

            s1.ShowData();
            s2.ShowData();
        }
    }
}
