using System;
using System.Collections.Generic;

class Course
{
    private int courseId;
    private string courseName;
    private string courseAdmin;
    private int quiz;
    private int handson;

    // Parameterized constructor
    public Course(int courseId, string courseName, string courseAdmin, int quiz, int handson)
    {
        this.courseId = courseId;
        this.courseName = courseName;
        this.courseAdmin = courseAdmin;
        this.quiz = quiz;
        this.handson = handson;
    }

    // Getters
    public int GetCourseId() { return courseId; }
    public string GetCourseName() { return courseName; }
    public string GetCourseAdmin() { return courseAdmin; }
    public int GetQuiz() { return quiz; }
    public int GetHandson() { return handson; }
}

class CourseProgram
{
    public static void Main(string[] args)
    {
        Course[] courses = new Course[4];

        for (int i = 0; i < 4; i++)
        {
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string admin = Console.ReadLine();
            int quiz = int.Parse(Console.ReadLine());
            int handson = int.Parse(Console.ReadLine());

            courses[i] = new Course(id, name, admin, quiz, handson);
        }

        string adminToSearch = Console.ReadLine();
        int handsonLimit = int.Parse(Console.ReadLine());

        int avgQuiz = findAvgOfQuizByAdmin(courses, adminToSearch);
        if (avgQuiz != 0)
            Console.WriteLine(avgQuiz);
        else
            Console.WriteLine("No Course found");

        Course[] sortedCourses = sortCourseByHandsOn(courses, handsonLimit);
        if (sortedCourses != null)
        {
            foreach (Course c in sortedCourses)
            {
                Console.WriteLine(c.GetCourseName());
            }
        }
        else
        {
            Console.WriteLine("No Course found with mentioned attribute.");
        }
    }

    // Method 1
    public static int findAvgOfQuizByAdmin(Course[] courses, string admin)
    {
        int sum = 0, count = 0;

        foreach (Course c in courses)
        {
            if (c.GetCourseAdmin().Equals(admin, StringComparison.OrdinalIgnoreCase))
            {
                sum += c.GetQuiz();
                count++;
            }
        }

        if (count > 0)
            return sum / count;
        else
            return 0;
    }

    // Method 2
    public static Course[] sortCourseByHandsOn(Course[] courses, int limit)
    {
        List<Course> list = new List<Course>();

        foreach (Course c in courses)
        {
            if (c.GetHandson() < limit)
            {
                list.Add(c);
            }
        }

        if (list.Count == 0)
            return null;

        list.Sort((a, b) => a.GetHandson().CompareTo(b.GetHandson()));
        return list.ToArray();
    }
}
