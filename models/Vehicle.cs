namespace CarFactory.Models
{
    public class Vehicle
    {
        private string color;
        private string brand;
        public Vehicle(string color, string brand)
        {
            this.color = color;
            this.brand = brand;
        }

        public string DisplayVehicle()
        {
            string vehicleInfo = this.color + " " + this.brand;

            return vehicleInfo;
        }
    }
}