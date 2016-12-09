using ServiceStack;

namespace MetadataErrorRepro.Another.ServiceModel
{
    [Route("/hey/{Name}")]
    public class Hey : IReturn<HeyResponse>
    {
        public string Name { get; set; }
    }
}