namespace CakeShop;

public class ChimneyCakeOven : IOven
{
    public void Fry(Flavors flavor, List<BakedGood> bakedGoods)
    {
        bakedGoods.Add(new ChimneyCake(flavor));
    }
}