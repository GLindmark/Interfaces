using System;

namespace InterfaceProject {



    class Program {
        static void Main(string[] args) {

            IStudent greg = new Fakegreg();
            Student[] students = greg.GetStudents();
            int index = 0;
            while(index < students.Length) {
                Console.WriteLine($"Student name is {students[index].Name}");
                index = index + 1;
            }
        }
    }
    

    class Student {

        public string Name { get; set; }
    }

    interface IStudent {

        Student[] GetStudents();//An interface have no body, they are simply the signature of a method

    }
    
    class Fakegreg: IStudent {//This is test data that we created while we wait on Greg to complete his work

        public Student[] GetStudents() {
            Student[] students = new Student[] {
                new Student { Name = "Denise"},
                new Student { Name = "Kim"},
                new Student { Name = "Greg"}

            };

            return students;

        }

    }
}
