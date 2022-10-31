 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using QR_Feedback.Models;

namespace QR_Feedback.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IConfiguration Configuration;
        public AdminController(IConfiguration config)
        {
            Configuration = config;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IEnumerable<Stations> getStations()
        {
            adminDataAccessLayer objAdmin = new adminDataAccessLayer(Configuration);
            List<Stations> data = new List<Stations>();
            data = objAdmin.getStations().ToList();
            return data;
        }
        
        [HttpGet]
        [Route("api/[controller]/districts")]
        public IEnumerable<Districts> getDistricts()
        {
            adminDataAccessLayer objAdmin = new adminDataAccessLayer(Configuration);
            List<Districts> data = new List<Districts>();
            data = objAdmin.GetDistricts().ToList();
            return data;
        }

        [HttpGet]
        [Route("api/[controller]/areaDropdown/{id}")]
        public IEnumerable<Stations> getStationsBySubDivision(int id)
        {
            adminDataAccessLayer objAdmin = new adminDataAccessLayer(Configuration);
            List<Stations> data = new List<Stations>();
            data = objAdmin.getStationsBySubdivision(id).ToList();
            return data;
        }

        [HttpGet]
        [Route("api/[controller]/subdivisionDropdown/{id}")]
        public IEnumerable<Subdivisions> getSubdivisionsByDistrict(int id)
        {
            adminDataAccessLayer objAdmin = new adminDataAccessLayer(Configuration);
            List<Subdivisions> data = new List<Subdivisions>();
            data = objAdmin.getSubDivisionsByDistrict(id).ToList();
            return data;
        }

        [HttpDelete]
        [Route("api/controller/districts/{id}")]
        public JsonResult deleteDistrict(int id)
        {
            adminDataAccessLayer objAdmin = new adminDataAccessLayer(Configuration);
        }
    }
}
