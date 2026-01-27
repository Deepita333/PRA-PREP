// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
class  Movie
{
    private string movieName;
    private string company;
    private string genre;
    private int budget;
    public Movie(string movieName, string company, string genre, int budget)
    {
        this.movieName=movieName;
        this.company=company;
        this.genre=genre;
        this.budget=budget;
    }
    public string GetMovieName()
    {
        return movieName;
    }
    public void SetMovieName(string movieName)
    {
        this.movieName=movieName;
        
    }
    public string GetCompany()
    {
        return company;
    }
    public void SetCompany(string company)
    {
        this.company= company;
    }
    public string GetGenre()
    {
        return genre;
    }
    public void SetGenre(string genre)
    {
        this.genre=genre;
    }
    public int GetBudget()
    {
        return budget;
    }
    public void SetBudget(int budget)
    {
        this.budget=budget;
    }
    
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Movie[] m = new Movie[4];
        for(int i = 0; i < 4;i++)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            int d = Convert.ToInt32(Console.ReadLine());
            m[i] = new Movie(a,b,c,d);
        }
        string s = Console.ReadLine();
        Movie[] ans= getMovieByGenre(m,s);
         foreach (Movie i in ans)
        {
            if (i.GetBudget() > 80000000)
                Console.WriteLine("High Budget Movie");
            else
                Console.WriteLine("Low Budget Movie");
        }
    }
        
    
     static Movie[] getMovieByGenre(Movie[] m, string s)
    {
        List<Movie> result = new List<Movie>();
        foreach (Movie i in m)
        {
            if (i.GetGenre().Equals(s,
            StringComparison.OrdinalIgnoreCase))
            {
            result.Add(i);
            }
        }
        return result.ToArray();
    }
      
    

}
