namespace OOP;

public class Vehicle
{
    public string Brand;
    private string _type;
    // Field with specified default value.
    public int Year = 2023;
    private string _userFirstName;
    private string _userLastName;
    string _fuelType;

    //Constructor
    public Vehicle(string userFirstName, string userLastName)
    {
        _userFirstName = userFirstName;
        _userLastName = userLastName;
    }

    // A property with logics
    public string Type
    {
        get
        {
            if (_type == null)
            {
                return string.Empty;
            }
            else
                return _type;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                _type = "Car";
            else
                _type = value;
        }
    }

    // Auto-implemented property
    public string Model { get; set; }

    //Property with Expression body
    public string UserName => $"{_userFirstName} {_userLastName}";

    //With Expression body we can get and set value
    public string FuelType
    {
        get => _fuelType;
        set => _fuelType = value;
    }
}
