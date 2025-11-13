public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        const string MenuMsg = "Choose which exercise you want to see: \n1: Ex1\n2: Ex2\n3: Ex3\nOther number: Exit";
        const string InvalidNumber = "The number you entered is not valid, try again";
        const string ExitMsg = "Program exited";
        int menuNum = 0;
        bool validNumber = true;
        Console.WriteLine(MenuMsg);
        do
        {
            try
            {
                menuNum = int.Parse(Console.ReadLine());
                validNumber = true;
            }
            catch
            {
                validNumber = false;
                Console.WriteLine(InvalidNumber);
            }

        } while (!validNumber);
        switch (menuNum)
        {
            case 5:
                const string shopMenu = "===AVAILABLE SHOP ITEMS===\nName\tLevel\tPower\tWeight\tCost(€)\tRare?\tRarity"; 
                Random exFiveRandom = new Random();
                const int ItemNum = 4;
                string[] shopItems = { "Sword", "Shield", "Potion", "Bow" };
                string[] rarity = { "Common", "Rare", "Legendary", "Ordinary" };
                bool isRareItem = false;
                Console.WriteLine(shopMenu);
                for(int i = 0; i<ItemNum; i++)
                {
                    isRareItem = exFiveRandom.Next(1, 101) > 50 ? true : false;
                    
                    Console.Write(shopItems[exFiveRandom.Next(0, 4)] + "\t" + exFiveRandom.Next(1, 11) + "\t"  + exFiveRandom.Next(100, 501) + "\t" + Math.Round(exFiveRandom.NextDouble(), 1) + "\t" + Math.Round(exFiveRandom.NextDouble()*100, 2)+"\t"+isRareItem + "\t");
                    if (isRareItem)
                    {
                        Console.Write(rarity[exFiveRandom.Next(0, 3)]);
                    }
                    else
                    {
                        Console.Write(rarity[3]);
                    }
                    Console.WriteLine();
                }
                break;
            default:
                Console.WriteLine(ExitMsg);
                break;
        }
    }
}
