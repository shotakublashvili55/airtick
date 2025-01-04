

using ConsoleApp1;
using System.IO;

namespace ConsoleApp1;
using System.Text.Json;

internal class FrontLink
{

    class FlightDetails
    {
        public string From { get; set; }
        public string To { get; set; }
        public string DepartureDate { get; set; }
        public string ReturnDate { get; set; }
        public int Adult { get; set; }
        public int Child { get; set; }
    }

    public static (string, string,string,string,int,int) SearchParameters()
    {
        string filePath = @"D:\STEP2\AVIABILETEBI\ConsoleApp1\UserWhrie.Json";


        FlightDetails flightDetails = ReadFlightDetailsFromFile(filePath);


        //Console.WriteLine("Flight Details:");
        //Console.WriteLine($"From: {flightDetails.From}");
        //Console.WriteLine($"To: {flightDetails.To}");
        //Console.WriteLine($"Departure Date: {flightDetails.DepartureDate}");
        //Console.WriteLine($"Return Date: {flightDetails.ReturnDate}");
        //Console.WriteLine($"Adults: {flightDetails.Adult}");
        //Console.WriteLine($"Children: {flightDetails.Child}");
        return (flightDetails.From, flightDetails.To, flightDetails.DepartureDate, flightDetails.ReturnDate, flightDetails.Adult, flightDetails.Child);
    }


    static FlightDetails ReadFlightDetailsFromFile(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string json = reader.ReadToEnd();
            return JsonSerializer.Deserialize<FlightDetails>(json);
        }
    }





























    /// //////////////////////////////////////




    public static void WebEntered()
    {
        Console.WriteLine("Airport from");
        string from_ = Console.ReadLine().ToUpper();

        Console.WriteLine("Airport to");
        string to_ = Console.ReadLine().ToUpper();

        Console.Clear();

        Console.WriteLine("1 - one way");
        Console.WriteLine("2 - return");

        string tripType = Console.ReadLine();

        Console.Clear();

        string depDate = "";
        string retDate = "";

        if (tripType == "1")
        {
            Console.WriteLine("Departure Date (DD.MM.YYYY)");
            depDate = Console.ReadLine();
        }
        else if (tripType == "2")
        {
            Console.WriteLine("Departure Date (DD.MM.YYYY)");
            depDate = Console.ReadLine();

            Console.WriteLine("Return Date (DD.MM.YYYY)");
            retDate = Console.ReadLine();

        }

        Console.WriteLine("Quantity of Adult");
        int adu = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantity of Child");
        int child = int.Parse(Console.ReadLine());

        Console.Clear();

       // Console.WriteLine($"from {from_} - to {to_}, {depDate} - {retDate}, Adult {adu}, Child {child}");

        string content = "";
        string filePath = @"D:\\STEP2\\AVIABILETEBI\\ConsoleApp1\UserWhrie.Json";
        content = content + "{\n";
        content = content + $"  \"From\": \"{from_}\",\n";
        content = content + $"  \"To\": \"{to_}\",\n";
        content = content + $"  \"DepartureDate\": \"{depDate}\",\n";
        content = content + $"  \"ReturnDate\": \"{retDate}\",\n";
        content = content + $"  \"Adult\": {adu},\n";
        content = content + $"  \"Child\": {child}\n";
        content = content + "}";
        File.WriteAllText(filePath, content);

    }
    //////////////////////////////////////////////////////////////




};


