using System;
using System.Diagnostics;
using System.Linq;
using System.Web.OData;

namespace RestierServiceV2.Controllers
{
    public class ODataInvoicesController : ODataController
    {
        private readonly PolModel _db = new PolModel();

        [EnableQuery]
        public IQueryable<ODataInvoices> Get()
        {
            Debug.WriteLine("ODataInvoicesController::Get");
            var user = Helper.GetUser();
            if (user == null) return Enumerable.Empty<ODataInvoices>().AsQueryable();
            return Helper.IsManager(user) ? _db.ODataInvoices : _db.ODataInvoices.Where(u => u.InvR == user.RepCode || u.AcctR == user.RepCode);
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
