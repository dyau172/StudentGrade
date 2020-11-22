using System;
using System.Collections.Generic;

namespace studentgrades
{
    public class Grades
    {
        public string Module{get; set;}
        public int Grade{get; set;}

        public int Year{get; set;}

        public Grades(string module, int grade, int year){
            Module = module;
            Grade = grade;
            Year = year;
        }

        public void GradeDetails(){
            Console.Write($"Module: {Module}");
            Console.Write($"Grade: {Grade}");
            Console.Write($"Year of Study: {Year}");
        }

    }
}
