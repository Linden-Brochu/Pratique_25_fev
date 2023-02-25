namespace CoreData;

public readonly struct Discount
{
    public Discount()
    {
        
    }
    
    public readonly Dictionary<Item, int> Items = new();

    public double NewPrice { get; init; } = 0;

    public bool IsDiscountApplicable(Order o)
    {
        return !Items.Any(c => o.Items.Count(item => item == c.Key) < c.Value);
    }
}