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
using RestierService;

namespace RestierService.Controllers
{
    public class ODataInvoicesController : ODataController
    {
        private PolModel db = new PolModel();

        [EnableQuery]
        public IQueryable<ODataInvoices> Get()
        {
            var user = Helper.GetUser();
            if (user == null) return Enumerable.Empty<ODataInvoices>().AsQueryable();
            //return Helper.IsManager(user) ? db.ODataInvoices : db.ODataInvoices.Where(u => u.InvR == user.RepCode || u.AcctR == user.RepCode);
            return db.ODataInvoices;
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