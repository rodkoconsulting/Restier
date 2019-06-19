using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Restier.Core.Model;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
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
        private string GetUser()
        {
            var authHeader = HttpContext.Current.Request.Headers["Authorization"];
            if (authHeader == null || !authHeader.StartsWith("Basic")) return "no username";
            var encodedUsernamePassword = authHeader.Substring("Basic ".Length).Trim();
            var encoding = Encoding.GetEncoding("iso-8859-1");
            var usernamePassword = encoding.GetString(Convert.FromBase64String(encodedUsernamePassword));
            var separatorIndex = usernamePassword.IndexOf(':');
            return usernamePassword.Substring(0, separatorIndex);
        }

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

        private class CustomizedAuthorizer : IQueryExpressionAuthorizer
        {
            public bool Authorize(QueryExpressionContext context)
            {

                return true;
            }
        }
        protected new static IServiceCollection ConfigureApi(Type apiType, IServiceCollection services)
        {
            //services.AddService<IModelBuilder, CustomizedModelBuilder>();
            //services.AddService<IQueryExpressionInspector, CustomizedModelBuilder>();
            //User = HttpContext.Current.Request.
            services.AddService<IQueryExpressionAuthorizer, CustomizedAuthorizer>();
            return EntityFrameworkApi<PolModel>.ConfigureApi(apiType, services);
        }

        protected IQueryable<AR_Customer> OnFilterAR_Customer(IQueryable<AR_Customer> entitySet)
        {

            return entitySet.Where(s => s.ARDivisionNo != "02").AsQueryable();
        }

        [Resource]
        public IQueryable<AR_Customer> OnPremiseCustomers
        {

            get
            {
                return DbContext.AR_Customer.Where(p => (p.CustomerType).Length == 4 && (p.CustomerType).Substring(2, 2) == "ON");
            }
        }

        [Resource]
        public IQueryable<ODataInvoices> GetPaInvoices
        {

            get
            {
                //return DbContext.AR_Customer.Where(p => (p.CustomerType).Length == 4 && (p.CustomerType).Substring(2, 2) == "ON");
                return DbContext.ODataInvoices.Where(p => p.Ter == "PA");
            }
        }

        public PolApi(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}