﻿namespace TaxiPark.Models
{
    public class Vodila
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public List<Car> Cars { get; set; }


    }
}
