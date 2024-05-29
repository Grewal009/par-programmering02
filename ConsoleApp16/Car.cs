namespace ConsoleApp16;

public class Car
{
    private string _brand;
    private int _yearModel;
    private string _registrartionNumber;
    private int _km;

    public string Brand { get; } = string.Empty;
    public int YearModel { get; }
    public string RegistrartionNumber { get; } = string.Empty;
    public int Km { get; } 


    public Car(string brand, int yearModel, string registrartionNumber, int km)
    {
        _brand = brand;
        _yearModel = yearModel;
        _registrartionNumber = registrartionNumber;
        _km = km;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Year Model: {YearModel}, Registration Number: {RegistrartionNumber}, Kilometer: {Km}");
    }
}