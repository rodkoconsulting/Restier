using System;
using System.Diagnostics;
using System.Linq;
using System.Web.OData;

namespace RestierServiceV2.Controllers
{
    public class ODataInvoiceFilterController : ODataController
    {
        private readonly PolModel _db = new PolModel();

        [EnableQuery]
        // GET
        public IQueryable<ODataInvoices> Get()
        {
            Debug.WriteLine("ODataInvoicesController::Get");
            return _db.ODataInvoices.Distinct();
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