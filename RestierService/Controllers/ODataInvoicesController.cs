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
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using RestierService;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<ODataInvoices>("ODataInvoices");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class ODataInvoicesController : ODataController
    {
        private PolModel db = new PolModel();

        [EnableQuery]
        public IQueryable<ODataInvoices> Get()
        {
            var user = Helper.GetUser();
            if (user == null) return null;
            return Helper.IsManager(user) ? db.ODataInvoices.Take(200000) : db.ODataInvoices.Where(u => u.InvR == user.RepCode || u.AcctR == user.RepCode).Where(p => p.Ter == "PA");
        }

        //// GET: odata/ODataInvoices(5)
        //[EnableQuery]
        //public SingleResult<ODataInvoices> GetODataInvoices([FromODataUri] string key)
        //{
        //    return SingleResult.Create(db.ODataInvoices.Where(oDataInvoices => oDataInvoices.InvoiceNo == key));
        //}

        //// PUT: odata/ODataInvoices(5)
        //public async Task<IHttpActionResult> Put([FromODataUri] string key, Delta<ODataInvoices> patch)
        //{
        //    Validate(patch.GetEntity());

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    ODataInvoices oDataInvoices = await db.ODataInvoices.FindAsync(key);
        //    if (oDataInvoices == null)
        //    {
        //        return NotFound();
        //    }

        //    patch.Put(oDataInvoices);

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ODataInvoicesExists(key))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return Updated(oDataInvoices);
        //}

        //// POST: odata/ODataInvoices
        //public async Task<IHttpActionResult> Post(ODataInvoices oDataInvoices)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.ODataInvoices.Add(oDataInvoices);

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (ODataInvoicesExists(oDataInvoices.InvoiceNo))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return Created(oDataInvoices);
        //}

        //// PATCH: odata/ODataInvoices(5)
        //[AcceptVerbs("PATCH", "MERGE")]
        //public async Task<IHttpActionResult> Patch([FromODataUri] string key, Delta<ODataInvoices> patch)
        //{
        //    Validate(patch.GetEntity());

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    ODataInvoices oDataInvoices = await db.ODataInvoices.FindAsync(key);
        //    if (oDataInvoices == null)
        //    {
        //        return NotFound();
        //    }

        //    patch.Patch(oDataInvoices);

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ODataInvoicesExists(key))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return Updated(oDataInvoices);
        //}

        //// DELETE: odata/ODataInvoices(5)
        //public async Task<IHttpActionResult> Delete([FromODataUri] string key)
        //{
        //    ODataInvoices oDataInvoices = await db.ODataInvoices.FindAsync(key);
        //    if (oDataInvoices == null)
        //    {
        //        return NotFound();
        //    }

        //    db.ODataInvoices.Remove(oDataInvoices);
        //    await db.SaveChangesAsync();

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ODataInvoicesExists(string key)
        {
            return db.ODataInvoices.Count(e => e.InvNo == key) > 0;
        }
    }
}
