

using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Models;

internal class Flights
{

    [Key]
    public string RouteNo { get; set; }
    public string AircraftRegNo { get; set; }
    public bool FromHostCity { get; set; }
    public DateTime Date { get; set; }
    public string FromCity { get; set; }
    public string ToCity { get; set; }
    public string Airline { get; set; }
    public TimeSpan DepartureTime { get; set; }
    public int Duration { get; set; }
    public decimal PriceBuiAdult { get; set; }
    public decimal PriceEcoAdult { get; set; }
    public decimal PriceBuiChild { get; set; }
    public decimal PriceEcoChild { get; set; }
    public decimal PriceBaggage { get; set; }
    public bool Food { get; set; }
    public int CancellationBefore { get; set; }

    public Flights(string routeNo, string aircraftRegNo, bool fromHostCity, DateTime date, string fromCity, string toCity, string airline, TimeSpan departureTime, int duration, decimal priceBuiAdult, decimal priceEcoAdult, decimal priceBuiChild, decimal priceEcoChild, decimal priceBaggage, bool food, int cancellationBefore)
    {
        RouteNo = routeNo;
        AircraftRegNo = aircraftRegNo;
        FromHostCity = fromHostCity;
        Date = date;
        FromCity = fromCity;
        ToCity = toCity;
        Airline = airline;
        DepartureTime = departureTime;
        Duration = duration;
        PriceBuiAdult = priceBuiAdult;
        PriceEcoAdult = priceEcoAdult;
        PriceBuiChild = priceBuiChild;
        PriceEcoChild = priceEcoChild;
        PriceBaggage = priceBaggage;
        Food = food;
        CancellationBefore = cancellationBefore;
    }
}
