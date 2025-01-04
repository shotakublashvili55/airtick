

using ConsoleApp1.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Library;

internal class ExportAirpirts
{

    public static void AirpotsToJson ()
    {
        DataContext _context = new DataContext();

        string content = "[";
        string filePath = @"D:\\STEP2\\AVIABILETEBI\\ConsoleApp1\\AirpotsList.Json";
        var airports = _context.city.ToList();
        foreach (var airport in airports)
        {
            if (content != "[")
            {
                content = content + ",\n";

            }
            content = content + "{\n";
            content = content + $"\"ICAO_Code\": \"{airport.ShortName}\",\n";
            content = content + $"\"Airport_Name\": \"{airport.Fullname}\",\n";
            content = content + $"\"City\": \"{airport.CityName}\"\n";
            content = content + "}\n";
        }

        content = content + "]";
        File.WriteAllText(filePath, content);

    }
}
