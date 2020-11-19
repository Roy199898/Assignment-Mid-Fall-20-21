using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Faculty
    {
        public string FacultyName { get; set; }
        public string FacultyId { get; set; }
        Teaching_Hour[] teaching_Hours;
        public int CreditCount { get; set; }
        public Faculty()
        {
            teaching_Hours = new Teaching_Hour[150];
        }
        public Departments Departments { get; set; }

        public Faculty(string facultyName, string facultyId)
        {
            this.FacultyName = facultyName;
            this.FacultyId = facultyId;
            teaching_Hours = new Teaching_Hour[150];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + FacultyName);
            Console.WriteLine("Id: " + FacultyId);
        }
        public void AddCredit(params Teaching_Hour[] teaching_Hour)
        {
            foreach (var b in teaching_Hour)
            {
                if (CreditCount < 7)
                {
                    this.teaching_Hours[CreditCount++] = b;

                }
                else
                {
                    Console.WriteLine("|you can not able to take more than 21 Credits");
                    Console.WriteLine("Cannot take any more course credit : " + b.CreditCount);
                }

            }


        }
        public void ShowAllCredits()
        {
            Console.WriteLine("++++");
            for (int i = 0; i < CreditCount; i++)
            {
                teaching_Hours[i].ShowInfo();
            }
            Console.WriteLine("++++");
        }
    }
}
