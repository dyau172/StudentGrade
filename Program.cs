using System;
using System.Collections.Generic;

namespace studentgrades {
    class Program {

        //GradeProfile stuGrades = new GradeProfile ();
        static void Main (string[] args) {

            List<Student> studentlist = new List<Student> ();

            Student stu1 = new Student ("John", "Knee", "English", "12345");
            Student stu2 = new Student ("Matt", "Few", "Maths", "23456");
            Student stu3 = new Student ("Ben", "Jamin", "Arts", "34567");

            studentlist.Add (stu1);
            studentlist.Add (stu2);
            studentlist.Add (stu3);

            Grades grades1 = new Grades ("Classics", 50, 2020);
            Grades grades2 = new Grades ("Algebra", 60, 2020);
            Grades grades3 = new Grades ("Bauhaus", 70, 2020);

            stu1.gradeProfile.AddGrade (grades1);
            stu2.gradeProfile.AddGrade (grades2);
            stu3.gradeProfile.AddGrade (grades3);

            Grades grades4 = new Grades ("Creative Writing", 60, 2020);
            Grades grades5 = new Grades ("Statistics", 70, 2020);
            Grades grades6 = new Grades ("Renaissance", 80, 2020);

            stu1.gradeProfile.AddGrade (grades4);
            stu2.gradeProfile.AddGrade (grades5);
            stu3.gradeProfile.AddGrade (grades6);

            foreach (Student student in studentlist) {
                Console.WriteLine ("--------------------------------");
                student.ReportCard ();

            }

        }

        /*

        public void Menu () {
            Console.WriteLine ("----------------------");
            Console.WriteLine ("1. Display Grades");
            Console.WriteLine ("2. Add Grades");
            Console.WriteLine ("3. Remove Grade");

            int select = Convert.ToInt32 (Console.ReadLine ());

            if (select == 1) {
                stuGrades.DisplayGrades ();
            } else if (select == 2) {
                Console.WriteLine ("Enter student ID");
                Console.WriteLine ("Somehow match the ID number and some kind of magic happens");

                Console.WriteLine ("Enter module name:");
                string module = Console.ReadLine ();
                Console.WriteLine ("Enter grade: ");
                int grade = Convert.ToInt32 (Console.ReadLine ());
                Console.WriteLine ("Enter year: ");
                int year = Convert.ToInt32 (Console.ReadLine ());
                stuGrades.AddGrade (new Grades (module, grade, year));
            } else if (select == 3) {

                //studentId == index 

                //index to remove 
                
                //stuGrades.Remove();
            }

        }

        */

    }
}