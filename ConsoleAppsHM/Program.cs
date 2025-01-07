using AirplaneManagement;

class Program
{
    static void Main()
    {
        var airplane = new Airplane();

        airplane.SetAirplaneDetails("Boeing 737", "Boeing", 1967, "Passenger");
        Console.WriteLine(airplane.ToString());
    }
}