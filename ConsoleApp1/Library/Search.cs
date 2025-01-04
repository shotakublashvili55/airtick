
using ConsoleApp1.Data;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using static ConsoleApp1.Library.Search;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Library;

internal class Search


{




    public static void Results()
    {


        DataContext _context = new DataContext();
        var dt = DateTime.Now;
        string dateFormat = "dd.MM.yyyy";


        string content = "[";

        string filePathtoFront = "D:/STEP2/AVIABILETEBI/ConsoleApp1/TicketsResults_unOrdered.Json";

        string From_ = FrontLink.SearchParameters().Item1;
        string To_ = FrontLink.SearchParameters().Item2;
        string depDate = FrontLink.SearchParameters().Item3;
        string retDate = FrontLink.SearchParameters().Item4;
        int adult = FrontLink.SearchParameters().Item5;
        int child = FrontLink.SearchParameters().Item6;


        int found = 0;
        string toAirportName = "";
        string fromAirportName = "";
        string transferAirportName = "";

        string dateString = depDate;
        DateTime depDate_ = DateTime.ParseExact(dateString, dateFormat, CultureInfo.InvariantCulture).Date;

        var fromAirportName_ = _context.city.FirstOrDefault(p => p.ShortName.ToUpper() == From_);
        if (fromAirportName_ != null)
        {
            fromAirportName = fromAirportName_.Fullname;
        }


        var toAirportName_ = _context.city.FirstOrDefault(p => p.ShortName.ToUpper() == To_);
        if (toAirportName_ != null)
        {
            toAirportName = toAirportName_.Fullname;
        } 

          var directs = _context.flights.Where(p => p.FromCity == From_ && p.ToCity==To_ && p.Date >= depDate_).Take(1).ToList();
        if (directs!=null)
        {
            foreach (var direct in directs)
            {
                found++;

                DateTime arrivalTime = direct.Date.AddMinutes(direct.Duration);

                if (content != "[")
                {
                    content = content + ",\n";

                }


                content = content + "{\n";
                content = content + $"\"RouteNo\": \"{direct.RouteNo}\",\n";
                content = content + $"\"Airline\": \"{direct.Airline}\",\n";
                content = content + $"\"From\": \"{From_}\",\n";
                content = content + $"\"To\": \"{To_}\",\n";
                content = content + $"\"fromAirportName\": \"{fromAirportName}\",\n";
                content = content + $"\"toAirportName\": \"{toAirportName}\",\n";
                content = content + $"\"TransferCity\": \"{""}\",\n";
                content = content + $"\"traisferAirportName\": \"{""}\",\n";
                content = content + $"\"Departure\": \"{direct.Date}\",\n";
                content = content + $"\"Arrival\": \"{arrivalTime}\",\n";
                content = content + $"\"TransferRouteNo\": \"{""}\",\n";
                content = content + $"\"TransferDeparture\": \"{""}\",\n";
                content = content + $"\"TransferArrival\": \"{""}\",\n";
                content = content + $"\"TransferDuration\": \"{""}\",\n";
                content = content + $"\"TotalDuration\": \"{arrivalTime - direct.Date}\",\n";
                content = content + $"\"EconomyPrice\": \"{direct.PriceEcoAdult}\",\n";
                content = content + $"\"BusinessPrice\": \"{direct.PriceBuiAdult }\"\n";
                content = content + "}";
            }

        }

        if (found==0)
        {
            bool transferReady = false;
            string transferCity = "";
            DateTime arrivalTime = new DateTime(2020, 1, 1, 1, 1, 1);
            DateTime deparTime = new DateTime(2020, 1, 1, 1, 1, 1);
            DateTime tra_deparTime = new DateTime(2020, 1, 1, 1, 1, 1);
            DateTime tra_arrivalTime = new DateTime(2020, 1, 1, 1, 1, 1);
           

            var nondirects = _context.flights.OrderBy(u => u.Date).Where(p => p.FromCity == From_  && p.Date >= depDate_  && p.FromHostCity == false).ToList();
            foreach (var nondirect in nondirects) { 
                if (nondirect != null)
            {
               transferCity = nondirect.ToCity;
               deparTime = nondirect.Date.Date.Add(nondirect.DepartureTime);
               arrivalTime = deparTime.AddMinutes(nondirect.Duration);
            }
              

                if (transferCity != null)
                {
                    var nondirect2 = _context.flights.OrderBy(u => u.Date).Where(p => p.FromCity == transferCity && p.ToCity == To_ && p.FromHostCity == true && p.Date >= depDate_).ToList();
                    if (nondirect2 != null)
                    {

                        foreach (var retu in nondirect2)
                        {

                            tra_deparTime = retu.Date.Date.Add(retu.DepartureTime);
                            tra_arrivalTime = tra_deparTime.AddMinutes(retu.Duration);
                            if (tra_deparTime > arrivalTime)
                            {
                                transferReady = true;

                            }

                            TimeSpan totalDur = tra_arrivalTime - deparTime;
                            if (transferReady && totalDur.TotalMinutes > 0 && totalDur.TotalMinutes < 4320)
                            {
                                if (transferCity != null)
                                {
                                   var transferAirportName_ = _context.city.FirstOrDefault(p => p.ShortName.ToUpper() == transferCity);

                                    if (transferAirportName_ != null)
                                    {
                                        transferAirportName = transferAirportName_.Fullname;
                                    }
                                }
                                if (content != "[")
                                {
                                    content = content + ",\n";

                                }

                                content = content + "{\n";
                                content = content + $"\"RouteNo\": \"{nondirect.RouteNo}\",\n";
                                content = content + $"\"Airline\": \"{nondirect.Airline}\",\n";
                                content = content + $"\"From\": \"{From_}\",\n";
                                content = content + $"\"To\": \"{To_}\",\n";
                                content = content + $"\"fromAirportName\": \"{fromAirportName}\",\n";
                                content = content + $"\"toAirportName\": \"{toAirportName}\",\n";
                                content = content + $"\"TransferCity\": \"{transferCity}\",\n";
                                content = content + $"\"transferAirportName\": \"{transferAirportName}\",\n";
                                content = content + $"\"Departure\": \"{deparTime}\",\n";
                                content = content + $"\"Arrival\": \"{arrivalTime}\",\n";
                                content = content + $"\"TransferRouteNo\": \"{retu.RouteNo}\",\n";
                                content = content + $"\"TransferDeparture\": \"{tra_deparTime}\",\n";
                                content = content + $"\"TransferArrival\": \"{tra_arrivalTime}\",\n";
                                content = content + $"\"TransferDuration\": \"{tra_deparTime - arrivalTime}\",\n";
                                content = content + $"\"TotalDuration\": \"{totalDur.TotalMinutes}\",\n";
                                content = content + $"\"EconomyPrice\": \"{nondirect.PriceEcoAdult + retu.PriceEcoAdult}\",\n";
                                content = content + $"\"BusinessPrice\": \"{nondirect.PriceBuiAdult + retu.PriceBuiAdult}\"\n";
                                content = content + "}\n";




                            };

                        }

                    }
                }

            }
         

        }
        content = content + "\n]";
        File.WriteAllText(filePathtoFront, content);
    }
}


//public static void DisplayTicketDetails(TicketOffer offers)
//{
//    Console.WriteLine($"Route: {offers.RouteNo}");
//    Console.WriteLine($"Airline: {offers.Airline}");
//    Console.WriteLine($"From: {offers.From} To: {offers.To}");
//    Console.WriteLine($"Transfer City: {offers.TransferCity}");
//    Console.WriteLine($"Departure: {offers.DepartureTime}");
//    Console.WriteLine($"Arrival: {offers.ArrivalTime}");

//}



// List<string> outputList = new List<string>();










// return ticket;
//outputList.Add($"{nondirect.RouteNo} {From_} - {transferCity}: {deparTime} {arrivalTime}");
//                            outputList.Add($"Transfer Time: {tra_deparTime - arrivalTime}");
//                            outputList.Add($"{retu.RouteNo} {transferCity} - {retu.ToCity}: {tra_deparTime} {tra_arrivalTime}");
//                            outputList.Add($"       Total Dudation: {totalDur} \n");


//    outputList.Add($"{nondirect.RouteNo} {From_} - {transferCity}: {deparTime} {arrivalTime}");
//outputList.Add($"Transfer Time: {tra_deparTime - arrivalTime}");
//outputList.Add($"{retu.RouteNo} {transferCity} - {retu.ToCity}: {tra_deparTime} {tra_arrivalTime}");
//outputList.Add($"       Total Dudation: {totalDur} \n");


//foreach (var line in outputList)
//{
//    Console.WriteLine(line);
//}


//TicketOffer offers = new TicketOffer(
//    nondirect.RouteNo,
//    nondirect.Airline,
//    From_,
//    To_,
//    transferCity,
//    deparTime,
//    arrivalTime,
//    tra_deparTime,
//    tra_arrivalTime,
//    tra_deparTime - arrivalTime,
//    totalDur,
//    nondirect.PriceEcoAdult + retu.PriceEcoAdult,
//    nondirect.PriceBuiAdult + retu.PriceBuiAdult);


//  ResultsToJson.DisplayTicketDetails(offers);

//Console.WriteLine($"{direct.RouteNo} {direct.FromCity} {direct.ToCity} {direct.Date}  {arrivalTime}");
//Console.WriteLine($"    Total durarion: {arrivalTime - direct.Date} \n");
//Console.WriteLine("-------------------------------");



                //TicketOffer offers = new TicketOffer(
                //               direct.RouteNo,
                //               direct.Airline,
                //               From_,
                //               To_,
                //               "",
                //               direct.Date,
                //               arrivalTime,
                //               dt,
                //               dt,
                //               dt - dt,
                //               arrivalTime - direct.Date,
                //               direct.PriceEcoAdult,
                //               direct.PriceBuiAdult);
                //ResultsToJson.DisplayTicketDetails(offers);