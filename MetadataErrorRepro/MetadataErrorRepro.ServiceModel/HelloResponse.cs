namespace MetadataErrorRepro.ServiceModel
{
    public class HelloResponse
    {
        public string Result { get; set; }
    
        // The error does not occur unless the HelloDetail-class is inside a wrapper.
        public Wrapper Wrapper { get; set; }
    }
}