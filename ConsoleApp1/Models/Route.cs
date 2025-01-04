
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Models;

internal class Route
{

    public int Id { get; set; }
    public string RouteNo { get; set; }
    public string AircrafRegNo { get; set; }
    public bool FromHostCity { get; set; }
    public DateTime Date { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public string Airline { get; set; }
    public DateTime DepartureTime { get; set; }
    public int Duration { get; set; }

    public decimal Price_Bui_Adult { get; set; }
    public decimal Price_Eco_Adult { get; set; }

    public decimal Price_Bui_Child { get; set; }
    public decimal Price_Eco_Child { get; set; }

    public decimal PriceBagege { get; set; }

    public bool Food {  get; set; }

    public int CancelationBefore { get; set; }

    public Route(string routeNo, string aircrafRegNo, bool fromHostCity, DateTime date, string from, string to, string airline, DateTime departureTime, int duration, decimal price_Bui_Adult, decimal price_Eco_Adult, decimal price_Bui_Child, decimal price_Eco_Child, decimal priceBagege, bool food, int cancelationBefore)
    {
        RouteNo = routeNo;
        AircrafRegNo = aircrafRegNo;
        FromHostCity = fromHostCity;
        Date = date;
        From = from;
        To = to;
        Airline = airline;
        DepartureTime = departureTime;
        Duration = duration;
        Price_Bui_Adult = price_Bui_Adult;
        Price_Eco_Adult = price_Eco_Adult;
        Price_Bui_Child = price_Bui_Child;
        Price_Eco_Child = price_Eco_Child;
        PriceBagege = priceBagege;
        Food = food;
        CancelationBefore = cancelationBefore;
    }
}
//routeNo	regNo(aircraft)	frombase	date	from	to	airline	departureTime	Duration	price_bc_adult	price_ec_adult	price_bc_child	price_ec_child	bagageprice	Food	cancalation
