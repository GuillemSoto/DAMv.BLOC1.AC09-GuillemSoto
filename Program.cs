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
            case 4:
                const string SearchMsg = "Which number do you want to search?";
                const string DoesExist = "The number exists!";
                const string DoesntExist = "The number you entered does not exist";
                int userSearch = 0;
                int[] arr = new int[10];
                int temp = 0;
                bool exists = false;
                Random ran = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = ran.Next(1, 10);
                }
                for (int write = 0; write < arr.Length; write++)
                {
                    for (int sort = 0; sort < arr.Length - 1; sort++)
                    {
                        if (arr[sort] > arr[sort + 1])
                        {
                            temp = arr[sort + 1];
                            arr[sort + 1] = arr[sort];
                            arr[sort] = temp;
                        }
                    }
                }

                

                Console.WriteLine();
                Console.WriteLine(SearchMsg);
                do
                {
                    try
                    {
                        userSearch = int.Parse(Console.ReadLine());
                        validNumber = true;
                    }
                    catch
                    {
                        validNumber = false;
                        Console.WriteLine(InvalidNumber);
                    }

                } while (!validNumber);
                foreach (int num in arr)
                {
                    if(num == userSearch)
                    {
                        exists = true;
                    }
                }
                if (exists)
                {
                    Console.WriteLine(DoesExist);
                }
                else
                {
                    Console.WriteLine(DoesntExist);
                }
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");
                break;
            default:
                Console.WriteLine(ExitMsg);
                break;
        }
    }
}
