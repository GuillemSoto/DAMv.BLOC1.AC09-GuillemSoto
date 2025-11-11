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
            case 3:
                int[] numArray = new int[10];
                Random numberGen = new Random();
                for (int i = 0; i<numArray.Length; i++)
                {
                    numArray[i] = numberGen.Next(1, 10);
                }
                foreach(int num in numArray)
                {
                    Console.Write(num + " ");
                }
                Array.Reverse(numArray);
                Console.WriteLine();
                foreach (int num in numArray)
                {
                    Console.Write(num + " ");
                }
                break;
            default:
                Console.WriteLine(ExitMsg);
                break;
        }
    }

}
