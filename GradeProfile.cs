using System;
using System.Collections.Generic;

namespace studentgrades {
    public class GradeProfile {
        List<Grades> gradelist = new List<Grades> ();

        public GradeProfile () { }

        public void AddGrade (Grades grade) {
            gradelist.Add (grade);
        }

        public string RemoveGrade (int index) {
            try {
                gradelist.RemoveAt (index);
            } catch (Exception ex) {
                return ex.Message;
            }

            return "Grade removed";
        }

        public void AverageGrade () {

            //create a new list to temporarily store details

            List<int> average = new List<int> ();

            //select which year to average 

            //store the grades into the list 

            //average the list (sum list and divide by count)

        }

        public void DisplayGrades () {

            foreach (Grades grade in gradelist) {
              
                Console.WriteLine ($"Grade: {grade.Grade}");
                Console.WriteLine ($"Module: {grade.Module}");
                Console.WriteLine ($"Year: {grade.Year}");

                
            }
        }

    }
}