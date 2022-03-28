using DigiTurkSeries.Business;
using DigiTurkSeries.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiTurkSeries.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {

        [HttpGet]
        public List<Series> GetAllSeries()
        {
            SeriesManager seriesManager = new SeriesManager();
            return seriesManager.GetAllSeries();            
        }

        [HttpGet("{ID}")]
        public Series GetSeries(long ID)
        {
            SeriesManager seriesManager = new SeriesManager();
            return seriesManager.GetSeries(ID);
        }      

       
    }
}
