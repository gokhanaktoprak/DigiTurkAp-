using System;
using System.Collections;
using System.Collections.Generic;

namespace DigiTurkSeries.Entities
{
    public class Season
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Episode> Episodes { get; set; }
        public long SeriesID { get; set; }
        public Series Series { get; set; }

    }
}
