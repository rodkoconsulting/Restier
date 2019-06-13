using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Restier.Core.Model;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.OData.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;
using Microsoft.Restier.Core;
using Microsoft.Restier.Core.Query;
using Microsoft.Restier.Providers.EntityFramework;
using Microsoft.Restier.Publishers.OData.Model;

namespace RestierService.Models
{
    public class PolApi : EntityFrameworkApi<PolModel>
    {





        private class CustomizedModelBuilder : IModelBuilder
        {

            public Task<IEdmModel> GetModelAsync(InvocationContext context, CancellationToken cancellationToken)
            {
                var builder = new ODataConventionModelBuilder();
                builder.EntityType<AR_Customer>();
                return Task.FromResult(builder.GetEdmModel());
            }

            public Task<IEdmModel> GetModelAsync(ModelContext context, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }

        [Resource]
        public IQueryable<ODataInvoices> GetPaInvoices
        {

            get
            {
                //return DbContext.AR_Customer.Where(p => (p.CustomerType).Length == 4 && (p.CustomerType).Substring(2, 2) == "ON");
                return DbContext.ODataInvoices.Where(p => p.Territory == "PA");
            }
        }

        public PolApi(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}