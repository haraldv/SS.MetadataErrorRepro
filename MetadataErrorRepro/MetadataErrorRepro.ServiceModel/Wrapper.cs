using System.Collections.Generic;

namespace MetadataErrorRepro.ServiceModel
{
    /// <summary>
    /// The error does not occur unless the HelloDetail-class is inside a wrapper.
    /// </summary>
    public class Wrapper
    {
        public List<HelloDetail> HelloDetails { get; set; }
    }
}