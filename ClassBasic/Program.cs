using System.Reflection;
using ClassBasic;

Vehicle myVehicle = new Vehicle("S M", "Sabir");

myVehicle.Brand = "Volvo";
myVehicle.Type = "SUV";
myVehicle.Year = 2021;
myVehicle.Model = "XC90";
myVehicle.FuelType = "Petrol";

Console.WriteLine("Brand: {0} \nYear: {1}", myVehicle.Brand, myVehicle.Year);

//A way of getting the properties and printing them
PropertyInfo[] properties = myVehicle.GetType().GetProperties();
foreach (PropertyInfo p in properties)
{
    System.Console.WriteLine($"{p.Name} : {p.GetValue(myVehicle)}");
}