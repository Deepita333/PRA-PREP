using System;
using System.Collections.Generic;

public class Employee
{
    public int employeeId { get; set; }
    public string employeeName { get; set; }
    public string department { get; set; }
    public double salary { get; set; }
    public int experience { get; set; }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Employee> l = new List<Employee>();

        for (int i = 0; i < 4; i++)
        {
            Employee ob = new Employee();
            ob.employeeId = Convert.ToInt32(Console.ReadLine());
            ob.employeeName = Console.ReadLine();
            ob.department = Console.ReadLine();
            ob.salary = Convert.ToDouble(Console.ReadLine());
            ob.experience = Convert.ToInt32(Console.ReadLine());
            l.Add(ob);
        }

        string s = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());

        double avg = getAverageSalaryByDepartment(l, s);

        if (avg != 0)
            Console.WriteLine($"{avg:F2}");
        else
            Console.WriteLine("0.0");

        Dictionary<string, List<Employee>> r =
            getExperiencedEmployeesByDepartment(l, k);

        if (r.Count > 0)
        {
            foreach (var entry in r)
            {
                Console.WriteLine(entry.Key);
                foreach (Employee e in entry.Value)
                {
                    Console.WriteLine(e.employeeName);
                }
            }
        }
        else
        {
            Console.WriteLine("No such employee");
        }
    }

    public static double getAverageSalaryByDepartment(List<Employee> l, string s)
    {
        int count = 0;
        double sum = 0;

        foreach (Employee i in l)
        {
            if (i.department.Equals(s, StringComparison.OrdinalIgnoreCase))
            {
                sum += i.salary;
                count++;
            }
        }

        return (count > 0) ? sum / count : 0;
    }

    public static Dictionary<string, List<Employee>>
        getExperiencedEmployeesByDepartment(List<Employee> l, int k)
    {
        Dictionary<string, List<Employee>> map =
            new Dictionary<string, List<Employee>>(StringComparer.OrdinalIgnoreCase);

        foreach (Employee i in l)
        {
            if (i.experience >= k)
            {
                if (map.ContainsKey(i.department))
                {
                    map[i.department].Add(i);
                }
                else
                {
                    List<Employee> li = new List<Employee>();
                    li.Add(i);
                    map[i.department] = li;
                }
            }
        }
        return map;
    }
}
