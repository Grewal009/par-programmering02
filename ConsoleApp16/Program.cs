// See https://aka.ms/new-console-template for more information

////Bilforhandleren
// // En bilforhandler har ulike biler i shappa si, det kan være biler med ulike merker, årsmodell, registreringsnummer og kilometerstand. Når kunden kommer inn i shappa skal han kunne se hvilke biler som finnes i shappa, eller han kan velge å finne en bil ut fra årsrange, eller en bil som har kjørt mer eller mindre enn en gitt kilometerstand. Kunden skal også ha mulighet til å kjøpe en av bilene. Bilen må da tilhøre kunden og ikke forhandleren.

using ConsoleApp16;

List<Car> cars = new List<Car>();
cars.Add(new Car("Toyota", 2022, "NK23412", 20123));
cars.Add(new Car("Nissan", 2012, "NN23888", 180990));
cars.Add(new Car("BMW", 2024, "BM00001", 10000));
cars.Add(new Car("Audi", 2016, "AD22226", 220210));
cars.Add(new Car("Tesla", 2023, "TS44422", 25320));

List<Car> sold = new List<Car>();

Console.WriteLine("*** Welcome to CarShop ***");

while (true)
{
    Menu();
    Console.Write("Enter your request: ");
    var input = Convert.ToInt32(Console.ReadLine());
    switch (input)
    {
        case 1:
            ShowAllCars();
            break;
        case 2:
            SearchCarsAsPerKM();
            break;
        case 3:
            break;
        case 4:
            Purchase();
            break;
        case 5:
            SoldCars();
            break;
        case 6:
            return;
        default:
            Console.WriteLine("wrong input!!! try again!");
            break;
    }
}

void Purchase()
{
    bool isCorrect = false;
    Console.WriteLine("Enter car registration number to purchase it: ");
    string regNumber = Console.ReadLine();
    
    for(int i=0;i<cars.Count;i++)
    {
        if ( cars[i].RegistrartionNumber == regNumber)
        {
            isCorrect = true;
            Console.Write("Enter new owner name: ");
            string name = Console.ReadLine();
            cars[i].PurchasedBy = name;
            sold.Add(cars[i]);
            
            cars.Remove(cars[i]);
        }
    }

    if (!isCorrect)
    {
        Console.WriteLine($"wrong input: {regNumber}");
    }
}

void SoldCars()
{
    foreach (var car in sold)
    {
        car.ShowSoldInfo();
    }
}

void SearchCarsAsPerKM()
{
    List<Car> searchResult = new List<Car>();
    Console.Write("Enter car kilometer range from: ");
    int searchFrom = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter car kilometer range to: ");
    int searchTo = Convert.ToInt32(Console.ReadLine());

    foreach (var car in cars)
    {
        if (car.Km >= searchFrom && car.Km <= searchTo)
        {
            searchResult.Add(car);
        }
    }

    if (searchResult.Count == 0)
    {
        Console.WriteLine($"No car found whose Km is from {searchFrom} to {searchTo}");
    }
    if(searchResult.Count!=0){
        foreach (var car in searchResult)
        {
            car.ShowInfo();
        }
    }
}

void ShowAllCars()
{
    foreach (var car in cars)
    {
        car.ShowInfo();
    }
}

void Menu()
{
    Console.WriteLine("\t*** MENU ***");
    Console.WriteLine("press 1 to see all cars\npress 2 to search cars as per KM\npress 3 to search cars as per year model\npress 4 to purchase car\npress 5 for see all sold cars\npress 6 to exit");
}

