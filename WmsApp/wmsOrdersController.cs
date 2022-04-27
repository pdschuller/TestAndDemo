using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tlModels.wmsModels;

namespace tlWebApi.ControllersWms
{
    public class wmsOrdersController : ApiController
    {
        WMSContext wmsContext;
        public wmsOrdersController()
        {
            wmsContext = new WMSContext();
        }

        [Route("api/GetWmsOrders/{dispatchdate}/{wmscode}")]
        [HttpGet]
        public List<Order> GetWmsOrders(string dispatchdate, string wmscode)
        {
            List<Order> TheOrders = new List<Order>();
            CompanyLocation cl = wmsContext.CompanyLocation.Where(c => c.Wmscode == wmscode).FirstOrDefault();
            int clid = cl.CompanyLocationId;
            DateTime dateDd = Convert.ToDateTime(dispatchdate);
            TheOrders = wmsContext.Order.Where(o => o.ConsigneeId == clid && o.PlannedShipTargetDate == dateDd).ToList();
            // if we return that we get StackOverflowException - no really
            List<Order> BarebonesOrders = new List<Order>();
            foreach (Order theOrder in TheOrders)
            {
                Order bb = new Order();
                bb.OrderId = theOrder.OrderId; ;
                bb.ExpectedItems = theOrder.ExpectedItems;
                bb.ShipperNumber = theOrder.ShipperNumber;
                bb.ConsigneeShipperId = theOrder.ConsigneeShipperId;
                BarebonesOrders.Add(bb);
            }
            return BarebonesOrders;
        }





        #region === boiler plate methods ================================================
        // GET: api/wmsOrders
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET: api/wmsOrders/5
        public string Get(int id)
        {
            return id.ToString();
        }
        // POST: api/wmsOrders
        public void Post([FromBody]string value)
        {
        }
        // PUT: api/wmsOrders/5
        public void Put(int id, [FromBody]string value)
        {
        }
        // DELETE: api/wmsOrders/5
        public void Delete(int id)
        {
        }
        #endregion
    }
}
