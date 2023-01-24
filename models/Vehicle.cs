namespace CarFactory.Models
{
    public class Vehicle
    {
        private string Color;
        private string Brand;
        public Vehicle(string color, string brand)
        {
            this.Color = color;
            this.Brand = brand;
        }

        public string DisplayVehicle()
        {
            string vehicleInfo = this.Color + " " + this.Brand;

            return vehicleInfo;
        }
    }
}