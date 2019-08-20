using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.OData;
using System.Web.Http.OData.Routing;
using RestierService;

namespace RestierService.Controllers
{
    public class ODataUsersController : ODataController
    {
        private PolModel db = new PolModel();

        [EnableQuery]
        public IQueryable<Web_ActiveUsers> Get()
        {
            var user = Helper.GetUser();
            if (user == null) return Enumerable.Empty<Web_ActiveUsers>().AsQueryable();
            return db.ODataUsers.Where(u => u.RepCode == user.RepCode);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
