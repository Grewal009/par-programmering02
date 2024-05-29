namespace ConsoleApp16;

public class CarShop
{
    private List<Car> _cars = new List<Car>();

    public List<Car> Cars { get; }


    public void AddCar(Car car)
    {
        _cars.Add(car);
    }

    public void Show()
    {
        foreach (var car in _cars)
        {
            Console.WriteLine($"Brand: {car.Brand}");
        }
    }

}