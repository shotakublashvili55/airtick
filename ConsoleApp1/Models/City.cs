

namespace ConsoleApp1.Models;

internal class City
{
    public int Id { get; set; }
    public string ShortName { get; set; }

    public string Fullname { get; set; }

    public string CityName { get; set; }

    public decimal DepartureFee { get; set; }
    public decimal ArrivalFee { get; set; }

    public City(string shortName, string fullname, string cityName, decimal departureFee, decimal arrivalFee)
    {
        ShortName = shortName;
        Fullname = fullname;
        CityName = cityName;
        DepartureFee = departureFee;
        ArrivalFee = arrivalFee;
    }
}
