﻿namespace TaxiPark.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string StateNum { get; set; }
        public string Color { get; set; }
        public bool IsSale { get; set; }
        public int IdVodila { get; set; }
        public Vodila Vodila { get; set; }




    }
}
