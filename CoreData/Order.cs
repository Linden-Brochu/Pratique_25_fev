namespace CoreData;

public class Order
{
    internal HashSet<Item> Items = new();

    internal Discount? Discount = null;

    public double Price
    {
        get
        {
            var sum = Items.Sum(i => i.Price);
            if (Discount is { } d)
            {
                sum += d.NewPrice;
                sum -= d.Items.Sum(i => i.Key.Price * i.Value);
            }

            return sum;
        }
    }

    
    public static Order operator +(Order o, Item i)
    {
        return new Order()
        {
            Items = new HashSet<Item>(o.Items)
            {
                i,
            }
        };
    }

    public static Order operator +(Item i, Order o)
    {
        return o + i;
    }

    public static Order operator -(Order o, Discount d)
    {
        if (o.Discount is not null)
        {
            throw new ArgumentException("This order cannot have more than one discount");
        }
        
        if (d.IsDiscountApplicable(o))
        {
            o.Discount = d;
        }

        throw new ArgumentException("Discount is not applicable");
    }
}