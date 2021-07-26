using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using SrijanData;
using Newtonsoft.Json;
using System.Web.Helpers;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System;

namespace SrijanDefenceAPI.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public List<tbl_mst_Country> GetCountry()
        {
            ddp_fdiFinalEntities entities = new ddp_fdiFinalEntities();
            List<tbl_mst_Country> mList = new List<tbl_mst_Country>();
            try
            {                       
                mList = entities.tbl_mst_Country.Where(x => x.IsActive.ToLower() == "y").ToList();
                return mList;
            }
            catch (Exception ex)
            {
                return mList;
            }           
        }
    }
}
