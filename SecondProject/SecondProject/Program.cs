using System;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string template = @"
Dear <name>

Your name is <name> and is shitty!
Shame on you to have <name> as your name.
Shame on you and on your parents.
So change <name> to something else!

With regards your boss
";
            string ducoment = TemplateMerge(template, "li");
            Console.Write(ducoment);   
        }

        public static string TemplateMerge(string template, string name)
        {
            string newDucoment = template.Replace("<name>", name);
            return newDucoment;
        }
    }
}
