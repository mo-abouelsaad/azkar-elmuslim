using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ZadElMuslim
{
    public class LocationModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Double Longitude { get; set; }
        public Double Latitude { get; set; }
        public string City { get; set; }
        public bool vib { get; set; }
        public bool snd { get; set; }
        public bool nav { get; set; }
    }
}