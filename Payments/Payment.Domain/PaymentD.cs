using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payment.Domain
{
    public class PaymentD
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [JsonProperty("concept", NullValueHandling = NullValueHandling.Ignore)]
        [Column("Concept")]
        [MaxLength(250)]
        [Required]
        public string Concept { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        [Column("Date")]
        public DateTime Date { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        [Required]
        [Column("Amount", TypeName = "decimal(18, 4)")]
        public decimal Amount { get; set; }
    }

}
