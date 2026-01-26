using System;

public class Motel
{
    private int motelId;
    private string motelName;
    private string dateOfBooking;
    private int noOfRoomsBooked;
    private string cabFacility;
    private double totalBill;

    public Motel(int motelId, string motelName, string dateOfBooking,
                 int noOfRoomsBooked, string cabFacility, double totalBill)
    {
        this.motelId = motelId;
        this.motelName = motelName;
        this.dateOfBooking = dateOfBooking;
        this.noOfRoomsBooked = noOfRoomsBooked;
        this.cabFacility = cabFacility;
        this.totalBill = totalBill;
    }

    public int GetMotelId() => motelId;
    public string GetMotelName() => motelName;
    public string GetDateOfBooking() => dateOfBooking;
    public int GetNoOfRoomsBooked() => noOfRoomsBooked;
    public string GetCabFacility() => cabFacility;
    public double GetTotalBill() => totalBill;
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Motel[] arr = new Motel[4];

        for (int i = 0; i < 4; i++)
        {
            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string d = Console.ReadLine();
            double e = double.Parse(Console.ReadLine());

            arr[i] = new Motel(a, b, c, n, d, e);
        }

        string s = Console.ReadLine();

        int result = TotalNoOfRoomsBooked(arr, s);
        if (result != 0)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("No such rooms booked");
        }
    }

    public static int TotalNoOfRoomsBooked(Motel[] arr, string s)
    {
        int total = 0;
        foreach (Motel m in arr)
        {
            if (m.GetCabFacility().Equals(s, StringComparison.OrdinalIgnoreCase)
                && m.GetNoOfRoomsBooked() > 5)
            {
                total += m.GetNoOfRoomsBooked();
            }
        }
        return total;
    }
}
