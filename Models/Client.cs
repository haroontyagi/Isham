namespace Invoicebook.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? Number { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? JoinedDate { get; set; }
        public DateTime? Created_at { get; set; }
        public string? Website { get; set; }

        // Contact info
        public string ContactName => $"{ContactFirstName} {ContactLastName}".Trim();

        public string? ContactFirstName { get; set; }
        public string? ContactLastName { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }

        // Financial info
        public decimal? Balance { get; set; }
        public decimal? paid_to_date { get; set; }
        public string? Currency { get; set; }
        public string? InvoicePaymentTerms { get; set; }
        public string? QuoteValidUntil { get; set; }
        public decimal? TaskRate { get; set; }

        // Billing address
        public string? BillingAptSuite { get; set; }
        public string? BillingStreet { get; set; }
        public string? BillingCity { get; set; }
        public string? BillingStateProvince { get; set; }
        public string? BillingPostalCode { get; set; }
        public string? BillingCountry { get; set; }

        // Shipping address
        public string? ShippingAptSuite { get; set; }
        public string? ShippingStreet { get; set; }
        public string? ShippingCity { get; set; }
        public string? ShippingStateProvince { get; set; }
        public string? ShippingPostalCode { get; set; }
        public string? ShippingCountry { get; set; }

        // Extra info
        public string? IdNumber { get; set; }
        public string? VatNumber { get; set; }
        public string? Size { get; set; }
        public string? Industry { get; set; }
        public string? PublicNotes { get; set; }
        public string? PrivateNotes { get; set; }
    }
}
