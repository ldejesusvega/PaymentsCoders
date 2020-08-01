using Newtonsoft.Json;
using System.Collections.Generic;

namespace Payment.Domain
{
    public class ResultT
    {
        [JsonProperty("statuscode", NullValueHandling = NullValueHandling.Ignore)]
        public int StatusCode { get; set; }
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("issuccess", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsSuccess { get; set; }
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public PaymentResource PaymentResource { get; set; }
        [JsonProperty("payments", NullValueHandling = NullValueHandling.Ignore)]
        public List<PaymentResource> PaymentResourceList { get; set; }
    }
}
