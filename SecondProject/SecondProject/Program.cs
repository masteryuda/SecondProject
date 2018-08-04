using System;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee firstEmployee = new Employee();
            //firstEmployee.Age = 13;
            //firstEmployee.Name = "Juda";

            //Employee secondEmployee = new Employee();
            //secondEmployee.Age = 34;
            //secondEmployee.Name = "Haludi";

            //string a = "gaga";
            //Console.WriteLine(a.Length);

            //string str = secondEmployee.Foo();
            //firstEmployee.Foo();

            MyString myString = new MyString();
            myString.str = "Ten li Mishpat";
            myString.Print();
            myString.ReversePrint();
            bool a = myString.Contain('N',true);
            Console.WriteLine(a);

            MyString ShemAcher = new MyString();
            ShemAcher.str = "EiN Li Mishpat";
            
            bool b = ShemAcher.Contain('n',true);
            Console.WriteLine(b);
        }
    }

    public class MyString
    {
        public string str;
        public bool Contain(char letter, bool isCaseSense)
        {
            
            if (isCaseSense == false)
            {
                letter = Char.ToUpper(letter);

            }
            for (int i = 0; i < str.Length; i++)
            {
                char currentLetter = str[i];
                if (isCaseSense == false)
                {
                    currentLetter = Char.ToUpper(str[i]);
                }
                if (str[i] == letter)
                {
                    return true;
                }
            }
            return false;
        }

        public void ReversePrint()
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();

        }

        public void Print()
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
    }

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
