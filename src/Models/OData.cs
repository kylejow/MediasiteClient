using System.Text.Json.Serialization;

namespace MediasiteUtil.Models
{
    internal class OData<T>
    {
        [JsonPropertyName("odata.metadata")]
        public string Metadata { get; set; }
        [JsonPropertyName("odata.count")]
        public string Count { get; set; }
        [JsonPropertyName("odata.nextLink")]
        public string NextLink { get; set; }
        [JsonPropertyName("value")]
        public T Value { get; set; }
    }
}
