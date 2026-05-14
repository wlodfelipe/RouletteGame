using roleta;

var roulette = new RouletteService();
var bets = new List<Bet>();

Console.WriteLine("How many bets do you wish to do?");

int numberOfBets = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= numberOfBets; i++)
{
    Console.WriteLine($"\n--- Bet number #{i} ---");
    Console.WriteLine("Expected bet types: 'Odd/even', 'Column' or 'Number'");
    
    Console.Write("Bet type: ");
    string type = Console.ReadLine()!;

    Console.Write("Amount (R$): ");
    decimal amount = decimal.Parse(Console.ReadLine()!);
    
    if (type == "Odd/even")
    {
        Console.WriteLine("Write 'odd' or 'even' to select one.");
        string oddOrEven = Console.ReadLine()!;
        bets.Add(new Bet(type, amount, oddOrEven:oddOrEven));
    }
    else if (type == "Column")
    {
        Console.WriteLine("Write '1-12', '13-24' or '25-36' to select your bet.");
        string column = Console.ReadLine()!;
        bets.Add(new Bet(type, amount, choosenColumn:column));
    }
    else if (type == "Number")
    {
        Console.WriteLine("Select your number to bet. Between 0 - 36");
        int number = int.Parse(Console.ReadLine()!);
        bets.Add(new Bet(type, amount, choosenNumber:number));    
    }
    else
    {
        Console.WriteLine("Error! Skiping this bet");
    }
}

Console.WriteLine("Spinning the Wheel...");
Thread.Sleep(3000);

GameResult gameResult = roulette.ProcessGame(bets);
Console.WriteLine($"And the roulette stopped at: {gameResult.RoulettedNumber}");
Console.WriteLine("Results are:");

foreach (var result in gameResult.Results)
{
    Console.WriteLine($"Bet on {result.BetType} resulted in R${result.AmountResult}");
}