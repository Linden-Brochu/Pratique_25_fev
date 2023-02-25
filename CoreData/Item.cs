namespace CoreData;

public readonly struct Item
{
    public string Name { get; init; }
    public double Price { get; init; }
    
    public static bool operator ==(Item i1, Item i2)
    {
        return i1.Equals(i2);
    }
    
    public static bool operator !=(Item i1, Item i2)
    {
        return !i1.Equals(i2);
    }

    public bool Equals(Item other)
    {
        return Name == other.Name;
    }

    public override bool Equals(object? obj)
    {
        return obj is Item other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
};