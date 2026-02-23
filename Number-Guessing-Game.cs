int price = 9;
int userChoice =0;


while (userChoice != price)
{
    Console.WriteLine("Enter price:");
    userChoice = Convert.ToInt32(Console.ReadLine());
    if (price == userChoice)
        {
            Console.WriteLine("Well done, the price is correct!!");
        }
    else if (userChoice < price)
        {
            Console.WriteLine("The prize is bigger!");
        }
    else
        {
            Console.WriteLine("The price is lower!");
        }
}