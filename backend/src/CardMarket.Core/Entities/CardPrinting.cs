namespace CardMarket.Core.Entities;

public class CardPrinting
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public Guid CardId { get; set; }
    public Card Card { get; set; } = null!;
    public string SetCode { get; set; } = string.Empty;
    public string SetName { get; set; } = string.Empty;
    public string Rarity { get; set; } = string.Empty;
}