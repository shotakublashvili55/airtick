

namespace ConsoleApp1.Models;

internal class Boarding
{
    public int Id { get; set; }
    public string RouteNo { get; set; }

    public string SeatNo { get; set; }

    public string Class { get; set; }

    public bool Window { get; set; }

    public bool PassengerId { get; set; }

    public Boarding(string routeNo, string seatNo, string @class, bool window, bool passengerId)
    {
        RouteNo = routeNo;
        SeatNo = seatNo;
        Class = @class;
        Window = window;
        PassengerId = passengerId;
    }
}

