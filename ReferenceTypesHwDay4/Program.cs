using System;

namespace ReferenceTypesHwDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is your practice that first homework of 4th day in camp
            Student student1 = new Student();
            

            Student student2 = new Student();
            student2.Name = "Azra";
            student2.LastName = "Özdemir";
            student2.SchoolNumber = 123456;

            UniStudents uniStudent1 = new UniStudents();
            uniStudent1.UniversityName = "AÜ";
            uniStudent1.Year = 3; 

            UniStudents uniStudent2 = new UniStudents();
            uniStudent2.UniversityName = "BÜ";
            uniStudent2.Year = 3;

            Expertise expertise1 = new Expertise();
            expertise1.MarkInDus = 70;
            expertise1.Profession = "Endodonthy";

            Expertise expertise2 = new Expertise();
            expertise2.MarkInDus = 75;
            expertise2.Profession = "Orthodonty";


            student1 = uniStudent1;
            uniStudent1.Name = "Fatime";
            uniStudent2.Name = "fatma";
            



            StudentManager studentManager = new StudentManager();
            studentManager.Add(uniStudent2);
            


        }
    }


    class Student // let s say that this class is our "BASE CLASS"
    {
        public string Name { get; set; }

        public string LastName { get; set; }
        public int SchoolNumber { get; set; }
        

    }

    class UniStudents:Student //inheritance
    {
        public string UniversityName { get; set; }
        public int Year { get; set; }
    }

    class Expertise:Student //inheritance again
    {
        public string Profession { get; set; }
        public int MarkInDus { get; set; }

    }

    class StudentManager
    {
        public void Add(Student student)
        {
            Console.WriteLine(student.Name);
            Console.WriteLine(student.LastName);
            


        }

    }
}
