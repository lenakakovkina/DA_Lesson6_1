int goodsQuantity = 100;
int goodsLoadedInCar = 0;

while (goodsQuantity > 0)
{
    Console.WriteLine("Please enter the quantity of good loaded into a car");
    goodsLoadedInCar = int.Parse(Console.ReadLine());

    if (goodsLoadedInCar > goodsQuantity || goodsLoadedInCar <= 0)
    {
        Console.WriteLine("Be more careful. You enterence is incorrect!");
        continue;
    }
    goodsQuantity -= goodsLoadedInCar;
}
Console.WriteLine("There is no more goods");