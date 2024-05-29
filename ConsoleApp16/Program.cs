// See https://aka.ms/new-console-template for more information

////Bilforhandleren
// // En bilforhandler har ulike biler i shappa si, det kan være biler med ulike merker, årsmodell, registreringsnummer og kilometerstand. Når kunden kommer inn i shappa skal han kunne se hvilke biler som finnes i shappa, eller han kan velge å finne en bil ut fra årsrange, eller en bil som har kjørt mer eller mindre enn en gitt kilometerstand. Kunden skal også ha mulighet til å kjøpe en av bilene. Bilen må da tilhøre kunden og ikke forhandleren.

using System.Diagnostics;
using ConsoleApp16;
CarShop shop = new CarShop();
shop.AddCar(new Car("Toyota", 2022, "NK23412", 20123));
shop.AddCar(new Car("Nissan", 2012, "NN23888", 180990));
shop.AddCar(new Car("BMW", 2024, "BM00001", 10000));
shop.AddCar(new Car("Audi", 2016, "AD22226", 220210));
shop.AddCar(new Car("Tesla", 2023, "TS44422", 25320));

Console.WriteLine("*** Welcome to CarShop ***");

while (true)
{
    Menu();
    var input = Convert.ToInt32(Console.ReadLine());
    switch (input)
    {
        case 1:
            Console.WriteLine(shop.Cars);
            
           
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            return;
            break;
        default:
            
            break;
    
    }
}


void Menu()
{
    Console.WriteLine("press 1 to see all cars\npress 2 to search cars as per KM\npress 3 to search cars as per year model\npress 4 to purchase car\npress 5 to exit");
}

