using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetadataErrorRepro.Another.ServiceModel;
using ServiceStack;

namespace MetadataErrorRepro.Another.ServiceInterface
{
    public class MyOtherServices : IService
    {
        public object Any(Hey request)
        {
            return new HeyResponse { Result = "Hey, {0}!".Fmt(request.Name) };
        }
    }
}
