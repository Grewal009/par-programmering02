namespace ConsoleApp16;

public class Car
{
    public string Brand { get; }

    public int YearModel { get; }

    public string RegistrartionNumber { get; }

    public int Km { get; }

    public string PurchasedBy { get; set; } = string.Empty;


    public Car(string brand, int yearModel, string registrartionNumber, int 
            km)
    {
        Brand = brand;
        YearModel = yearModel;
        RegistrartionNumber = registrartionNumber;
        Km = km;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Year Model: {YearModel}, Registration Number: {RegistrartionNumber}, Kilometer: {Km}");
    }

    public void ShowSoldInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Year Model: {YearModel}, Registration Number: {RegistrartionNumber}, Kilometer: {Km}, Purchased by: {PurchasedBy}");
    }
}