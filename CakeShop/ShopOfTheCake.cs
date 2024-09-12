namespace CakeShop;

public class ShopOfTheCake
{
    public List<IOven> Ovens { get; } = [new PancakeOven(), new ChimneyCakeOven()];
    public List<BakedGood> BakedGoods { get; } = [];
    public double Income { get; set; }

    public void CalculateIncome()
    {
        Income = BakedGoods.Sum(cake => cake.Price);
    }

    private static void AddOil(PancakeOven oven)
    {
        oven.IsOilAvailable = true;
    }

    public void CakeDay()
    {
        
        for (int i = 0; i < 5; i++)
        {
            int index = 0;
            foreach (var oven in Ovens)
            {
                var random = new Random();
                var randomFlavor = (Flavors)random.Next(3);
                oven.Fry(randomFlavor, BakedGoods);
                Console.WriteLine(BakedGoods[index].Price);
                index++;
                /*if (oven is PancakeOven pancakeOven)
                {
                    AddOil(pancakeOven);
                }*/
            }
        }
        
        
    }
}