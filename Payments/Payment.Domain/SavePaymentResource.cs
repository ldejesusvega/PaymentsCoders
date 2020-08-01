using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payment.Domain
{
    [NotMapped]
    public class SavePaymentResource
    {
        public string Concept { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}