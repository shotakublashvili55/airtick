
namespace ConsoleApp1.Models;

internal class Aircraft
{
    public int Id { get; set; }
    public string regNo { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }
    public int capacitySecondEconom { get; set; }

    public int capacityBuisness { get; set; }

    public int manufactureYear { get; set; }

    public Aircraft(string regNo, string brand, string model, int capacitySecondEconom, int capacityBuisness, int manufactureYear)
    {
        this.regNo = regNo;
        Brand = brand;
        Model = model;
        this.capacitySecondEconom = capacitySecondEconom;
        this.capacityBuisness = capacityBuisness;
        this.manufactureYear = manufactureYear;
    }
}
