using CardMarket.Core.Enums;

namespace CardMarket.Core.Entities;

public class Order
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public Guid ListingId { get; set; }
    public Listing Listing { get; set; } = null!;
    public Guid? OfferId { get; set; }
    public Offer? Offer { get; set; }
    public Guid BuyerId { get; set; }
    public ApplicationUser Buyer { get; set; } = null!;
    public Guid SellerId { get; set; }
    public ApplicationUser Seller { get; set; } = null!;
    public Guid CardPrintingId { get; set; }
    public CardPrinting CardPrinting { get; set; } = null!;
    public CardCondition Condition { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public string Currency { get; set; } = "EUR";
    public OrderStatus Status { get; set; } = OrderStatus.PendingPayment;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? PaidAt { get; set; }
    public DateTime? ShippedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public DateTime? CancelledAt { get; set; }
}