using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Welcome to University Management System");
            Console.WriteLine("created by ROY,DIP");
            Console.WriteLine("Developer At Kuratoli Software Solutions");
            Console.WriteLine("===========================================");
   
            Course c = new Course("Computer Networks", 3203, 3, 4, 1);
            Course c1 = new Course("Data Communications", 5498, 3, 4.0, 1);
            Section se = new Section("A", "Computer Networks", 2640, 3, 5.0);
            Section se1 = new Section("B", "Computer Networks", 2640, 3, 3.0);
            Section se2 = new Section("C", "Computer Networks", 2640, 3, 3.0);
            Section se3 = new Section("D", "Computer Networks", 2640, 3, 3.0);
            Section se4 = new Section("E", "Computer Networks", 2640, 3, 3.0);
            Section se5 = new Section("F", "Bangladesh Studies", 6903, 3, 3.0);
            Section se6 = new Section("G", "Bangladesh Studies", 6903, 3, 3.0);
            Section se7 = new Section("H", "Bangladesh Studies", 6903, 3, 3.0);
            Section se8 = new Section("I", "Bangladesh Studies", 6903, 3, 3.0);
            Section se9 = new Section("J", "Bangladesh Studies", 6903, 3, 3.0);
            Section se10 = new Section("K", "Bangladesh Studies", 6903, 3, 3.0);
            Section se11 = new Section("L", "Bangladesh Studies", 6903, 3, 3.0);
            Section se12= new Section("M", "Bangladesh Studies", 6903, 3, 3.0);
            Section se13= new Section("N", "Bangladesh Studies", 6903, 3, 3.0);
            Section se14 = new Section("O", "Bangladesh Studies", 6903, 3, 3.0);
            se.SearchSection(2640);
            Console.WriteLine("===========Seacrhing For Section=========");
            c.SearchSection(2640);
            Console.WriteLine("=====================");
            c.ShowInfo();
            Console.WriteLine("==================");
            se.ShowInfo();
            Console.WriteLine("================");
            Departments d = new Departments("FASS");
            Departments d1 = new Departments("COE");
            Departments d2 = new Departments("FBA");
            Departments d3 = new Departments("FST");
            d.AddCourse(c1, c);
            d.ShowAllCourses();
            Console.WriteLine("================");
            Console.WriteLine("=======Adding Courses In Department========");
            d.AddCourse(se, se1, se2, se3, se4, se5, se6, se7, se8, se9);
            d.ShowAllCourses();
            Console.WriteLine("==============");
            Console.WriteLine("========Faculty Taking Courses=========");
            Faculty f = new Faculty("KUNDU ARUN", "21-38628-2");
            Faculty f1 = new Faculty(" Dr.SAHA UPAL", "21-38798-2");
            Faculty f2 = new Faculty("RAMJAN ALI", "21-38800-2");
            Faculty f3 = new Faculty("CHAND SAWADAGAR", "21-38801-2");
            Faculty f4 = new Faculty("PAUL HIMEL", "21-38890-2");
            Teaching_Hour te = new Teaching_Hour("English Reading and writing", 3, d);
            Teaching_Hour te1 = new Teaching_Hour("C++", 3, d);
            Teaching_Hour te2 = new Teaching_Hour("Alternative Current", 3, d);
            Teaching_Hour te3 = new Teaching_Hour("Direct Current", 3, d);
            Teaching_Hour te4 = new Teaching_Hour("Object oriented Aalysis and Design", 3, d);
            Teaching_Hour te5 = new Teaching_Hour(" Software Engineering", 3, d);
            Teaching_Hour te6 = new Teaching_Hour("Device", 3, d2);
            Teaching_Hour te7 = new Teaching_Hour("COmpueter Networks", 3, d);
            Teaching_Hour te8 = new Teaching_Hour(" Data com", 3, d1);
            Teaching_Hour te9 = new Teaching_Hour("AI", 3, d1);
            Teaching_Hour te10 = new Teaching_Hour("Data base", 3, d1);
            Teaching_Hour te11 = new Teaching_Hour("Cheyistry", 3, d1);
            Teaching_Hour te12 = new Teaching_Hour("Physics 1", 3, d2);
            Teaching_Hour te13 = new Teaching_Hour("Physics 2", 3, d2);
            Teaching_Hour te14 = new Teaching_Hour("Buisness Communication", 3, d2);
            Teaching_Hour te15 = new Teaching_Hour("Algorithm", 3, d3);
            Teaching_Hour te16 = new Teaching_Hour("English 2", 3, d3);
            Teaching_Hour te17 = new Teaching_Hour("Advance data base", 3, d3);
            Teaching_Hour te18 = new Teaching_Hour("Computer vision", 3, d);
            Teaching_Hour te19 = new Teaching_Hour("Image preocessing", 3, d);
            Teaching_Hour te20 = new Teaching_Hour("Computer Graphics", 3, d);
            Console.WriteLine("===========Faculty Iformation==========");
            f.ShowInfo();
            f.AddCredit(te, te1, te2, te3, te4, te5, te8);
            f.ShowAllCredits();
            Console.WriteLine("=========Faculty Information==========");
            f1.ShowInfo();
            f1.AddCredit(te, te1, te2, te3, te4, te5, te18, te19);
            f1.ShowAllCredits();


        }
    }
}