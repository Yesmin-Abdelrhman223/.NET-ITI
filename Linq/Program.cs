using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{

    class Program
    {
        // private static IEnumerable<object> variableLengthValues;

        class Subject
        {
            private int code;
            private string name;


            public int Code { get; set; }
            public string Name { get; set; }
        }
        class Student
        {

            private int id;
            private string fname;
            private string lname;
            private Subject[] subjects;


            public int ID { get; set; }
            public string Fname { get; set; }
            public string Lname { get; set; }

            public Subject[] Subject { get; set; }



        }

        static void Main()
        {
            //////////////11111111111111111111
            List<int> numbers = new List<int>()
            {
               2,4,6,7,1,4,2,9,1
            };
            var NODuplication = numbers.Distinct().ToList();
            NODuplication.Sort();
            NODuplication.ForEach(num => Console.WriteLine(num + " "));
            Console.WriteLine("************\n");
            NODuplication.ForEach(num => Console.WriteLine("{ Number ="+num+" Multiply = "+num*num + " }"));

            Console.WriteLine("************\n");
            //////////////////22222222222222222
            string[] names = { "Tom", "Dick", "harry", "Mary", "Jay" };
            var lengths = names.Where(s => s.Length==3);
            foreach (var s in lengths) 
            {
                Console.WriteLine(s);

            }


            Console.WriteLine("************\n");

            var contain = names.Where(s => s.Contains('a') || s.Contains('A'));

            foreach (var s in contain)
            {
                Console.WriteLine(s);

            }
            ///////////////////333333333333333333



            List<Student> student = new List<Student>(){
                    new Student() {
                    ID = 1,
                    Fname = "Ali",
                    Lname = "Mohammed",
                    Subject= new Subject[] {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 33, Name = "UML" }
                     }
                 },
                new Student()
                {
                    ID = 2,
                    Fname = "Mone ",
                    Lname = "Gala",
                    Subject = new Subject[] {
                        new Subject()
                        { Code = 22, Name = "EF"},

                        new Subject() { Code = 34, Name = "XML" },
                        new Subject() { Code = 25, Name = "JS" }
                    }
                },
                new Student()
                {
                    ID = 3,
                    Fname = "Yara",
                    Lname = "Yousf",
                    Subject = new Subject[]
                    {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject()
                    { Code = 25, Name = "JS"}

                    }
                },

                new Student()
                {
                    ID = 2,
                    Fname = "Mone ",
                    Lname = "Gala",
                    Subject = new Subject[] {
                        new Subject()
                        { Code = 22, Name = "EF"},
                        new Subject() { Code = 34, Name = "XML" },
                        new Subject() { Code = 25, Name = "JS" }
                    }
                },
                new Student()
                {
                    ID = 1,
                    Fname = "Ali",
                    Lname = "Ali",
                     Subject= new Subject[]
                     {
                    new Subject() { Code = 33, Name = "UML" },
                    new Subject()
                    { Code = 25, Name = "JS" }
                     }
                },

                 };

            var q5 = student.Select((Student s) => new { name = s.Fname + " " + s.Lname, length = s.Subject.Length });
            foreach (var i in q5)
            {
                Console.WriteLine($"< full name : {i.name} ,nymber of subjects = {i.length} >");
            }
            Console.WriteLine("************\n");

            var q4 = from s in student.OrderByDescending(s => s.Fname).ThenBy(s => s.Lname) select s;
            foreach (var i in q4)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
