namespace AirplaneManagement
{
    public class Airplane
    {
        public string AirplaneName { get; private set; }
        public string Manufacturer { get; private set; }
        public int YearOfManufacture { get; private set; }
        public string AirplaneType { get; private set; }

        public Airplane()
        {
            AirplaneName = "Unknown";
            Manufacturer = "Unknown";
            YearOfManufacture = 0;
            AirplaneType = "Unknown";
        }

        public Airplane(string airplaneName, string manufacturer, int yearOfManufacture, string airplaneType)
        {
            AirplaneName = airplaneName;
            Manufacturer = manufacturer;
            YearOfManufacture = yearOfManufacture;
            AirplaneType = airplaneType;
        }

        public void SetAirplaneDetails(string airplaneName, string manufacturer, int yearOfManufacture, string airplaneType)
        {
            AirplaneName = airplaneName;
            Manufacturer = manufacturer;
            YearOfManufacture = yearOfManufacture;
            AirplaneType = airplaneType;
        }

        public void SetAirplaneDetails(string airplaneName, string manufacturer)
        {
            AirplaneName = airplaneName;
            Manufacturer = manufacturer;
        }

        public string GetAirplaneDetails()
        {
            return $"Airplane Name: {AirplaneName}\n" +
                   $"Manufacturer: {Manufacturer}\n" +
                   $"Year of Manufacture: {YearOfManufacture}\n" +
                   $"Airplane Type: {AirplaneType}";
        }

        public override string ToString()
        {
            return GetAirplaneDetails();
        }
    }
}