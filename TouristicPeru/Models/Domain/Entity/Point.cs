using System;

namespace TouristicPeru.Models.Domain.Entity
{
    public class Point
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}