using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payment.Domain
{
    [NotMapped]
    public class PaymentResource
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("concept", NullValueHandling = NullValueHandling.Ignore)]
        [DisplayName("Concepto")]
        public string Concept { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        [DisplayName("Fecha")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        [DisplayName("Monto")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal Amount { get; set; }
    }

}