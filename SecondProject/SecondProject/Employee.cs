using System;

namespace SecondProject
{
    public class Employee
    {
        public int Age;
        public string Name;

        public string Foo()
        {
            int yearOfBirth = DateTime.Now.Year - Age;
            string ret = Name + " " + yearOfBirth;
            return ret;
        }
    }
}
