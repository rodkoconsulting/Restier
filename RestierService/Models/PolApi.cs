using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Restier.Core.Model;
using System.Runtime.Remoting.Contexts;
using System.Web;
using Microsoft.Restier.Providers.EntityFramework;
using Microsoft.Restier.Publishers.OData.Model;

namespace RestierService.Models
{
    public class PolApi : EntityFrameworkApi<PolModel>
    {
        protected IQueryable<AR_Customer> OnFilterAR_Customer(IQueryable<AR_Customer> entitySet)
        {
            return entitySet.Where(s => s.ARDivisionNo != "02").AsQueryable();
        }

        [Resource]
        public IQueryable<AR_Customer> OnPremiseCustomers
        {
            get { return DbContext.AR_Customer.Where(p => (p.CustomerType).Length == 4 && (p.CustomerType).Substring(2, 2) == "ON"); }
        }

        public PolApi(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}