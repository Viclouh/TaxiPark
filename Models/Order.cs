namespace TaxiPark.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string NameClient { get; set; }
        public string PhoneClient { get; set; }
        public Status Status{ get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int IdCar { get; set; }
        public Car Car { get; set; }
        public int Price { get; set; }

    }
}
