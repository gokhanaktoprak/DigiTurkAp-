using DigiTurkSeries.DataAccess;
using DigiTurkSeries.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace DigiTurkSeries.Business
{
    public class SeriesManager
    {
        public List<Series> GetAllSeries()
        {
            SeriesDataAccess seriesDataAccess = new SeriesDataAccess();
            return seriesDataAccess.GetAllSerries();
        }
        public Series GetSeries(long ID)
        {
            SeriesDataAccess seriesDataAccess = new SeriesDataAccess();
            if (ID > 0)
            {
                var series= seriesDataAccess.GetSerries(ID);
                if (series != null)
                {
                    var ImagePath= System.AppDomain.CurrentDomain.BaseDirectory + series.Image;
                    if (File.Exists(ImagePath))
                    {
                        var jsonData = File.ReadAllBytes(ImagePath);
                        series.Image = Convert.ToBase64String(jsonData);
                        return series;
                    }
                }
                throw new Exception("Object Not Found");
            }
            throw new Exception("ID can not be less than 1");
        }


    }
}
