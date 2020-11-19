using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Teaching_Hour

    {
        public string CourseName{ get; set; }
        public int CourseCreditNumber { get; set; }
        public Departments Departments { get; set; }
        Course[] courses;
        public int CountCredit { get; set; }
        public Teaching_Hour()
        {
            courses = new Course[6];
        }
        public Teaching_Hour(string courseName, int courseCreditNumber, Departments departments)
        {
            CourseName= courseName;
            CourseCreditNumber = courseCreditNumber;
            Departments = departments;
            courses = new Course[6];
        }
        public void AddTeachingHours(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (CountCredit < 7)
                    this.courses[CountCredit++] = course;
            }

        }
        public void ShowInfo()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Course Credit Number : " + CourseCreditNumber);
            for (int y = 0; y < CountCredit; y++)
            {
                courses[y].ShowInfo();
            }
        }
    }
}