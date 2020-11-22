using System;

namespace studentgrades
{
    public class Student
    {
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string Course{get; set;}
        public string StudentId{get; set;}

        public GradeProfile gradeProfile = new GradeProfile();

        public Student (string _firstName, string _lastName, string _course, string _studentId){
            FirstName = _firstName;
            LastName = _lastName;
            Course = _course;
            StudentId = _studentId;
        }

        public void ReportCard(){
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Student ID: {StudentId}");
            gradeProfile.DisplayGrades();
            
        }


        
        
    }
}
