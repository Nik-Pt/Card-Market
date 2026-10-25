using CardMarket.Core.Enums;

namespace CardMarket.Core.Entities;

public class CollectionItem
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public Guid UserId { get; set; }
    public ApplicationUser User { get; set; } = null!;
    public Guid CardPrintingId { get; set; }
    public CardPrinting CardPrinting { get; set; } = null!;
    public CardCondition Condition { get; set; }
    public int Quantity { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}