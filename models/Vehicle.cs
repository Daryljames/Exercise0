namespace CarFactory.Models
{
    public class Vehicle
    {
        public string Color { get; set; }
        private string Brand { get; set; }
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