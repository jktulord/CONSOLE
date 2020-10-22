using System;
using System.Collections.Generic;
using System.Text;

namespace CONSOLE
{
    public class Person
    {
        public string name;
        public int age;
        public string gender;

        public Person()
        {
            name = "dafoe";
            age = 65;
            gender = "True";
        }

        public void print_base_info()
        {
            Console.WriteLine(name + " " + age + " " + gender);
        }
    }
}
