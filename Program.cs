public class Program
{
    public static void Main()
    {
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
            case 1:
                int[] numbers = new int[20];
                string even = "";
                string odd = "";
                Random RNG = new Random();
                for (int i = 0; i<numbers.Length; i++)
                {
                    numbers[i] = RNG.Next(1, 100);
                }
                foreach (int i in numbers)
                {
                    Console.Write(i + " ");
                    if (i % 2 == 0)
                    {
                        even += i + " ";
                    }
                    else
                    {
                        odd += i + " ";
                    }
                }
                Console.WriteLine("\n"+even);
                Console.WriteLine(odd);
                break;
            default:
                Console.WriteLine(ExitMsg);
                break;
        }
    }
}
