using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Departments
    {

        public string DeptName { get; set; }
        Course[] courseList;
        public int courseTotal { get; set; }
        public Section Section { get; set; }
        Teaching_Hour[] teachingHours;
        public int CountCredit { get; set; }
        public Departments()
        {
            courseList = new Course[80];
            teachingHours = new Teaching_Hour[200];
        }
        public Departments(string name)
        {
           DeptName = name;
            courseList = new Course[80];
            teachingHours = new Teaching_Hour[200];


        }
        public void ShowInfo()
        {
            Console.WriteLine("Name Of The Department: " +DeptName);
            Console.WriteLine("Total Number Of Courses: " + courseTotal);
        }
        public void AddCourse(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (courseTotal < 80)
                    courseList[courseTotal++] = course;
            }
        }
        public void RemoveCourse(Course course)
        {
            for (int i = 0; i < courseTotal; i++)
            {
                if (course.CourseId.Equals(courseList[i].CourseId))
                {
                    for (int j = i; j < courseTotal - 1; j++)
                    {
                        courseList[j] = courseList[j + 1];
                    }
                    courseTotal--;
                    break;
                }

            }
        }
        public void AddNewCourseNumber(Course course, int number)
        {
            course.AddCourseNumber(number);
        }
        public Course SearchCourse(string id)
        {
            Course b = null;
            for (int i = 0; i < courseTotal; i++)
            {
                if (courseList[i].CourseId.Equals(id))
                {
                    b = courseList[i];
                    break;
                }
            }
            return b;
        }
        public void ShowAllCourses()
        {
            for (int i = 0; i < courseTotal; i++)
            {
                courseList[i].ShowInfo();
            }
        }
        public void AddTeachingHours(Teaching_Hour teachingHour)
        {
            teachingHours[CountCredit++] = teachingHour;
        }
        public void ShowAllCredits()
        {

            for (int i = 0; i < CountCredit; i++)
            {
                Console.WriteLine("*Department Info");
                teachingHours[i].Departments.ShowInfo();
                Console.WriteLine("Teaching  Hours");
                teachingHours[i].ShowInfo();
                Console.WriteLine("");
            }

        }


    }
}
    

