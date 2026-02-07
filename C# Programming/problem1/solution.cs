// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class Course
{
   public int courseId {get; set;}
   public string courseName {get; set;}
   public string courseAdmin {get; set;}
   public int quiz {get; set;}
   public int handson  {get; set;}
  
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
       
        List<Course> l = new List<Course>();
        for(int i =0; i<4;i++)
        {
            Course o = new Course();
            m.motelId= Convert.ToInt32(Console.ReadLine());
            m.motelName=Console.ReadLine();
            m.dateOfBooking=Console.ReadLine();
            m.noOfRoomsBooked=Convert.ToInt32(Console.ReadLine());
            m.cabFacility =Console.ReadLine();
            m.totalBill = Convert.ToDouble(Console.ReadLine());
            l.Add(m);
        }
        string s = Console.ReadLine();
        int n = totalNoOfRoomsBooked(l,s);
        if(n!=0)
        {
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine("No rooms exist");
        }
    }
  public static int totalNoOfRoomsBooked(List<Motel> l, strin8g s)

    {
        int t=0;
        foreach(var i in l)
        {
            if (i.cabFacility.Equals(s, StringComparison.OrdinalIgnoreCase)
    && i.noOfRoomsBooked > 5)

            {
                   t += i.noOfRoomsBooked   ;

            }
        }
        return t; 
    }
}
