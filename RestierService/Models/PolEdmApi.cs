using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.OData.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;
using Microsoft.Restier.Core;
using Microsoft.Restier.Core.Model;

namespace RestierService.Models
{
    public class PolEdmApi : ApiBase

    {
        protected new static IServiceCollection ConfigureApi(Type apiType, IServiceCollection services)
        {
            services.AddService<IModelBuilder, CustomizedModelBuilder>();
            return ApiBase.ConfigureApi(apiType, services);
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

        public PolEdmApi(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}