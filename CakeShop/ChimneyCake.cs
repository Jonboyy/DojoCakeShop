namespace CakeShop;

public class ChimneyCake : BakedGood
{
    public ChimneyCake(Flavors flavor) : base(flavor)
    {
        Price += 2.00;
    }
}