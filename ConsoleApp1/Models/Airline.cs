
namespace ConsoleApp1.Models;
    internal class Airline
    {
    public int Id { get; set; }
    public string ShortName { get; set; }

    public string FullName { get; set; }

    public string HostAirport { get; set; }

    public string color1 { get; set; }
    public string color2 { get; set; }

    public Airline(string shortName, string fullName, string hostAirport, string color1, string color2)
    {
        ShortName = shortName;
        FullName = fullName;
        HostAirport = hostAirport;
        this.color1 = color1;
        this.color2 = color2;
    }
}




