namespace CakeShop;

public class PancakeOven : IOven
{
    public bool IsOilAvailable { get; set; } = true;
    public void Fry(Flavors flavor, List<BakedGood> pancakes)
    {
        if (IsOilAvailable)
        {
            IsOilAvailable = false;
            pancakes.Add(new Pancake(flavor));
        }

        Console.WriteLine("No Oil Available");

    }
}