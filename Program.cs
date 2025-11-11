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
                break;
            case 2:
                const string PokeMenu = "What do you want to do?\n1-View pokedex\n0-Exit";
                const string ReleaseString = "Which pokemon do you want to release? Enter the index.";
                const string PokemonReleased = "You released {0}!";
                const string ReleaseMiss = "The index {0} is empty. There's no Pokémon in that slot to release.";
                int pokeMenuChoice = 1;
                int releasedPokemon = 0;
                string[] pokedex = { "Victini", "Pikachu", "Charmander", "Squirtle", "Bulbasaur", "Eevee", "Jigglypuff", "Psyduck", "Snorlax", "Gengar", "Machop", "Magikarp", "Vulpix", "Onix", "Abra" };
                while (pokeMenuChoice == 1)
                {
                    Console.WriteLine(PokeMenu);
                    do
                    {
                        try
                        {
                            pokeMenuChoice = int.Parse(Console.ReadLine());
                            if(pokeMenuChoice < 0 || pokeMenuChoice > 1)
                            {
                                Console.WriteLine(InvalidNumber);
                                validNumber = false;
                            }
                            else
                            {

                                validNumber = true;
                            }
                        
                        }
                        catch
                        {
                            validNumber = false;
                            Console.WriteLine(InvalidNumber);
                        }

                    } while (!validNumber);
                    if(pokeMenuChoice == 1)
                    {
                        for(int i = 0; i < pokedex.Length; i++)
                        {
                            Console.WriteLine(i + "-" + pokedex[i]);
                        }
                        Console.WriteLine(ReleaseString);
                        try
                        {
                            releasedPokemon = int.Parse(Console.ReadLine());
                            if (releasedPokemon < 0 || releasedPokemon > pokedex.Length)
                            {
                                Console.WriteLine(InvalidNumber);
                                validNumber = false;
                            }
                            else
                            {
                                validNumber = true;
                            }

                        }
                        catch
                        {
                            validNumber = false;
                            Console.WriteLine(InvalidNumber);
                        }
                        if (pokedex[releasedPokemon] == "Empty")
                        {
                            Console.WriteLine(ReleaseMiss, releasedPokemon);
                        }
                        else
                        {
                            Console.WriteLine(PokemonReleased, pokedex[releasedPokemon]);
                            pokedex[releasedPokemon] = "Empty";
                        }
                    }
                }
                break;
            default:
                Console.WriteLine(ExitMsg);
                break;
        }
    }
}
