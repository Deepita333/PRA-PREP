// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string[] parts= s.Split(' ');
        List<int> l = new List<int>();
        foreach(string p in parts)
        {
            int n= int.Parse(p);
            if(!l.Contains(n))
            {
                l.Add(n);
            }
        }
        foreach(int i in l)
        {
            Console.WriteLine(i+ " ");
        }
    }
}
