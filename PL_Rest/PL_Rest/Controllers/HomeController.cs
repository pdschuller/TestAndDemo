using PL_Rest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PL_Rest.Controllers
{
    public class HomeController : ApiController
    {
        [HttpPost]
        public bool AddEmpDetails()
        {
            return true;
            //write insert logic  

        }
        // http://localhost:54480/PL/GetVaj
        [Route("PL/GetVaj")]
        [HttpGet]
        public string GetEmpDetails()
        {
            return "Vithal Wadje";
        }
        // http://localhost:54480/PL/GetPhil
        [Route("PL/GetPhil")]
        [HttpGet]
        public string GetPhil()
        {
            PL_DbContext AppDbContext = new PL_DbContext();
            DateTime ShipDate = new DateTime(2018, 05, 23);
            List<Run> TodaysRuns = AppDbContext.Runs.Where(r => r.PlannedShipDate == ShipDate).ToList();

            return "Phil";
        }
        [HttpDelete]
        public string DeleteEmpDetails(string id)
        {
            return "Employee details deleted having Id " + id;

        }
        [HttpPut]
        public string UpdateEmpDetails(string Name, String Id)
        {
            return "Employee details Updated with Name " + Name + " and Id " + Id;

        }
    }
}
