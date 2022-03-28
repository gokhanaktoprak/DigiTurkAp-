using System;
using System.Collections.Generic;

namespace DigiTurkSeries.Entities
{
    public class Series
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public  List<Season> Season { get; set; }
    }
}
