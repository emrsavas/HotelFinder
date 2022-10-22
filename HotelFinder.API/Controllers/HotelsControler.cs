using HotelFinder.Business.Concrete;
using HotelFinder.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsControler : ControllerBase
    {
        private IHostedService _hotelservice;
        public HotelsControler()
        {
            _hotelservice = new HotelManager();

        [HttpGet]
        public List<Hotel> Get()
            {
                return _hotelservice.GetAllHotels();
            }
    }
}
