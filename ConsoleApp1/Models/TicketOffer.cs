

namespace ConsoleApp1.Models;

internal class TicketOffer
{
    public string RouteNo { get; set; }

    public string Airline { get; set; }
    public string From { get; set; }
    public string To { get; set; }

    public string TransferCity { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }

    public DateTime Tra_DepartureTime { get; set; }
    public DateTime Tra_ArrivalTime { get; set; }
    public TimeSpan TransferTime { get; set; }
    public TimeSpan TotalDuration { get; set; }

    public decimal EconomClassPrice { get; set; }

    public decimal BuissnesClassPrice { get; set; }

    public TicketOffer(string routeNo, string airline, string from, string to, string transferCity, DateTime departureTime, DateTime arrivalTime, DateTime tra_DepartureTime, DateTime tra_ArrivalTime, TimeSpan transferTime, TimeSpan totalDuration, decimal economClassPrice, decimal buissnesClassPrice)
    {
        RouteNo = routeNo;
        Airline = airline;
        From = from;
        To = to;
        TransferCity = transferCity;
        DepartureTime = departureTime;
        ArrivalTime = arrivalTime;
        Tra_DepartureTime = tra_DepartureTime;
        Tra_ArrivalTime = tra_ArrivalTime;
        TransferTime = transferTime;
        TotalDuration = totalDuration;
        EconomClassPrice = economClassPrice;
        BuissnesClassPrice = buissnesClassPrice;
    }
}
