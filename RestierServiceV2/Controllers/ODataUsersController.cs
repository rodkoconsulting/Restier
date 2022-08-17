using System;
using System.Diagnostics;
using System.Linq;
using System.Web.OData;

namespace RestierServiceV2.Controllers
{
    public class ODataUsersController: ODataController
    {
        private readonly PolModel _db = new PolModel();

        [EnableQuery]
        public IQueryable<Web_ActiveUsers> Get()
        {
            Debug.WriteLine("ODataUsersController::Get");
            var user = Helper.GetUser();
            if (user == null) return Enumerable.Empty<Web_ActiveUsers>().AsQueryable();
            return _db.ODataUsers.Where(u => u.RepCode == user.RepCode);
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
