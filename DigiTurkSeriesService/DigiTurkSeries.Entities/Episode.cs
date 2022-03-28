using System;

namespace DigiTurkSeries.Entities
{
    public class Episode
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long SeasonID { get; set; }
        public Season Season { get; set; }
    }
}
