// See https://aka.ms/new-console-template for more information

string player;
string computer;
string response;
Random random = new Random();
bool playAgain = true;


while (playAgain)
{
    player = "";
    computer = "";
    while(player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.Write("ROCK,PAPER,SCISSORS? CHOOSE :");
        player = Console.ReadLine();
        player = player.ToUpper();
    }
    
    Console.WriteLine("Player " + player);

    int randomNum = random.Next(1,4);
    switch(randomNum)
    {
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;
        case 3:
            computer = "SCISSORS";
            break;

    } 

    Console.WriteLine("Computer :" + computer);

    switch (player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                Console.WriteLine("It is a draw");
            }
            else if(computer == "PAPER")
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("You Win!");
            }
            break;
        case "PAPER":

            if(computer == "ROCK")
            {
                Console.WriteLine("You Win!");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("It is a draw");
            }
            else
            {
                Console.WriteLine("You Lose!");
            }
            break;

        case "SCISSORS":
            if (computer == "ROCK")
            {
                Console.WriteLine("You lose!");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.WriteLine("It is a draw");
            }

            break;
    }
    Console.WriteLine("Do you want to play again : (Y/N)");
    response = Console.ReadLine();
    response = response.ToUpper();

    if(response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}
Console.WriteLine("Thank you for playing my game");
Console.ReadKey();