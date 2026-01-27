public static int totalNoOfRoomsBooked(Motel[] m, string cabFacility)
{
    int t = 0;

    foreach (Motel i in m)
    {
        if (i.GetCabFacility().Equals(cabFacility,
            StringComparison.OrdinalIgnoreCase)
            && i.GetNoOfRoomsBooked() > 5)
        {
            t += i.GetNoOfRoomsBooked();
        }
    }
    return t;
}
