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
using Microsoft.Restier.Core.Query;

namespace RestierService.Models
{
    public class PolEdmApi : ApiBase

    {
        public string User;





        public PolEdmApi(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}