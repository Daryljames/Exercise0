namespace CarFactory.Models
{
    public class Truck : Vehicle
    {
        public string Model { get; set; }
        public float Capacity { get; set; }

        public Truck(string color, string brand, string model, float capacity) : base(color, brand)
        {
            this.Model = model;
            this.Capacity = capacity;
        }

        public string DisplayVehicle()
        {
            string truckInfo = base.DisplayVehicle() + " " + this.Model + " " + Convert.ToString(this.Capacity);

            return truckInfo;
        }
    }
}