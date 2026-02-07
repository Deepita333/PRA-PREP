using System;
using System.Collections.Generic;
using System.Linq;

public class Course
{
    public int courseId { get; set; }
    public string courseName { get; set; }
    public string courseAdmin { get; set; }
    public int quiz { get; set; }
    public int handson { get; set; }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Course> l = new List<Course>();

        for (int i = 0; i < 4; i++)
        {
            Course m = new Course();
            m.courseId = Convert.ToInt32(Console.ReadLine());
            m.courseName = Console.ReadLine();
            m.courseAdmin = Console.ReadLine();
            m.quiz = Convert.ToInt32(Console.ReadLine());
            m.handson = Convert.ToInt32(Console.ReadLine());
            l.Add(m);
        }
        string s = Console.ReadLine();
        int n = findAvgOfQuizByAdmin(l, s);
        if (n != 0)
            Console.WriteLine(n);
        else
            Console.WriteLine("No such courseId exists");
        int k = Convert.ToInt32(Console.ReadLine());
        List<Course> res = sortCourseByHandsOn(l, k);

        if (res.Count > 0)
        {
            foreach (Course c in res.OrderBy(x => x.handson))
            {
                Console.WriteLine(c.courseName);
            }
        }
        else
        {
            Console.WriteLine("No Course found with mentioned attributes.");
        }
    }

    public static int findAvgOfQuizByAdmin(List<Course> l, string s)
    {
        int sum = 0;
        int count = 0;

        foreach (Course i in l)
        {
            if (i.courseAdmin.Equals(s, StringComparison.OrdinalIgnoreCase))
            {
                sum += i.quiz;
                count++;
            }
        }

        return (count > 0) ? sum / count : 0;
    }

    public static List<Course> sortCourseByHandsOn(List<Course> l, int k)
    {
        List<Course> o = new List<Course>();

        foreach (Course i in l)
        {
            if (i.handson < k)
            {
                o.Add(i);
            }
        }
        return o;
    }
}
