namespace CakeShop;

public class BakedGood
{
    public double Price { get; set; }
    public Flavors Flavor { get; set; }
    
    public BakedGood(Flavors flavor)
    {
        if (flavor == Flavors.Chocolate)
        {
            Price = 0.3;
        }

        if (flavor == Flavors.Strawberry)
        {
            Price = 0.5;
        }

        if (flavor == Flavors.Vanilla)
        {
            Price = 0.75;
        }
        Flavor = flavor;
    }
}