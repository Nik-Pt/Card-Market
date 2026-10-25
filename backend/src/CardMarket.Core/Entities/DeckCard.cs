using CardMarket.Core.Enums;

namespace CardMarket.Core.Entities;

public class DeckCard
{
    public Guid DeckId { get; set; }
    public Deck Deck { get; set; } = null!;
    public Guid CardId { get; set; }
    public Card Card { get; set; } = null!;
    public DeckZone Zone { get; set; }
    public int Quantity { get; set; }
}