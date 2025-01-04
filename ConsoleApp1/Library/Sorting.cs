

using System.Net.Http.Json;
using System.Text.Json;


namespace ConsoleApp1.Library;

internal class Sorting
{



public class TicketOffer
{
    public string RouteNo { get; set; }
    public string Airline { get; set; }
    public string From { get; set; }
    public string To { get; set; }

    public string fromAirportName { get; set; }

    public string toAirportName { get; set; }
    public string TransferCity { get; set; }

    public string transferAirportName { get; set; }
    public string Departure { get; set; }
    public string Arrival { get; set; }
    public string TransferRouteNo { get; set; }
    public string TransferDeparture { get; set; }
    public string TransferArrival { get; set; }
    public string TransferDuration { get; set; }
    public string TotalDuration { get; set; }
    public string EconomyPrice { get; set; }
    public string BusinessPrice { get; set; }
}


   public static void Sort()
    {
        string inputFilePath = "D:/STEP2/AVIABILETEBI/ConsoleApp1/TicketsResults_unOrdered.Json";
        string outputFilePath = "D:/STEP2/AVIABILETEBI/ConsoleApp1/TicketsResults.Json";

        try
        {
            // Read JSON data from the file
            List<TicketOffer> offers;
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string jsonContent = reader.ReadToEnd();
                offers = JsonSerializer.Deserialize<List<TicketOffer>>(jsonContent);
           
            }


            var orderedOffers = offers
                .OrderBy(o => decimal.Parse(o.EconomyPrice)).ToList();  //order by price
              //  .OrderBy(o => int.Parse(o.TotalDuration)).ToList();   //order by Duration






            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                string outputJson = JsonSerializer.Serialize(orderedOffers, new JsonSerializerOptions { WriteIndented = true });
                writer.Write(outputJson);
            }

            Console.WriteLine($"Ordered data has been written to {outputFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}



