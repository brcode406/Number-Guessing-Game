int prix = 9;
int userChoice =0;


while (userChoice != prix)
{
    Console.WriteLine("Enter price:");
    userChoice = Convert.ToInt32(Console.ReadLine());
    if (prix == userChoice)
        {
            Console.WriteLine("Bravo le prix est exacte !!");
        }
    else if (userChoice < prix)
        {
            Console.WriteLine("Le prix est plus grand!");
        }
    else
        {
            Console.WriteLine("Le prix est plus petit!");
        }
}