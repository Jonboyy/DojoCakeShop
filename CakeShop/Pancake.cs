namespace CakeShop;

public class Pancake : BakedGood
{
    public Pancake(Flavors flavor) : base(flavor)
    {
        Price += 1.00;
    }
}