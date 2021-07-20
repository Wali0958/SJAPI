using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using SrijanData;
using Newtonsoft.Json;

namespace SrijanDefenceAPI.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public string GetCountry()
        {
            ddp_fdiFinalEntities entities = new ddp_fdiFinalEntities();
            List<tbl_mst_Country> mList = new List<tbl_mst_Country>();
            mList = entities.tbl_mst_Country.Where(x => x.IsActive.ToLower() == "y").ToList();
            return JsonConvert.SerializeObject(mList);
            
        }
    }
}
