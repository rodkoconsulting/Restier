using System;
using System.Diagnostics;
using System.Linq;
using System.Web.OData;

namespace RestierServiceV2.Controllers
{
    public class ODataOrdersController : ODataController
    {
        private readonly PolModel _db = new PolModel();

        [EnableQuery]
        public IQueryable<ODataOrders> Get()
        {
            Debug.WriteLine("ODataOrdersController::Get");
            var user = Helper.GetUser();
            if (user == null) return Enumerable.Empty<ODataOrders>().AsQueryable();
            return Helper.IsManager(user) ? _db.ODataOrders : _db.ODataOrders.Where(u => u.Rep == user.RepCode);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
