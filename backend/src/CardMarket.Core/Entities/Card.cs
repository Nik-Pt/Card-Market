namespace CardMarket.Core.Entities;

public class Card
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public int ExternalId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CardType { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? Attribute { get; set; }
    public string? Type { get; set; }
    public int? Level { get; set; }
    public int? Atk { get; set; }
    public int? Def { get; set; }
    public string? Archetype { get; set; }
    public string? ImageUrl { get; set; }
    public string? ImageSmallUrl { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public ICollection<CardPrinting> Printings { get; set; } = new List<CardPrinting>();
}