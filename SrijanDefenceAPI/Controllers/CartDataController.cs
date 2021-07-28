using SrijanData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SrijanDefenceAPI.Controllers
{
    public class CartDataController : ApiController
    {
        [HttpGet]
        public List<tbl_trn_ProductFilterSearchTemp> GetCartDefault()
        {
            ddp_fdiFinalEntities entities = new ddp_fdiFinalEntities();
            List<tbl_trn_ProductFilterSearchTemp> mMainData = new List<tbl_trn_ProductFilterSearchTemp>();
            try
            {
                mMainData = entities.tbl_trn_ProductFilterSearchTemp.OrderByDescending(x => x.LastUpdated).ToList();
                return mMainData;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return mMainData;
            }
        }
    }
}
