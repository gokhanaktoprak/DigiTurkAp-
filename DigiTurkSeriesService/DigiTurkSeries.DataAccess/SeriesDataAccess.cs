using DigiTurkSeries.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DigiTurkSeries.DataAccess
{
    public class SeriesDataAccess
    {
        public List<Series> GetAllSerries()
        {
            List<Series> listSeries = new List<Series>();

            var JsonPath = System.AppDomain.CurrentDomain.BaseDirectory + "Series.Json";
            if (File.Exists(JsonPath))
            {
                using (System.IO.StreamReader _StreamReader = new System.IO.StreamReader(JsonPath))
                {
                    string jsonData = _StreamReader.ReadToEnd();
                    listSeries = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Series>>(jsonData);
                }
            }
            return listSeries;
        }

        public Series GetSerries(long ID)
        {
            Series Series = new Series();
            if (ID > 0)
            {
                Series = this.GetAllSerries().Where(op => op.ID == ID).FirstOrDefault();
            }
           
            return Series;
        }
    }
}
