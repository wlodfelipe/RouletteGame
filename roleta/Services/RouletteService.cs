namespace roleta;

public class RouletteService()
{
    private int SpinTheWheel()
    {
       Random roulette = new Random();
       int roulettedNumber = roulette.Next(37);

       return roulettedNumber;
    }

    public GameResult ProcessGame(List<Bet>bets)
    {
        int roulettedNumber = SpinTheWheel();
        List<BetResult> betResults = new List<BetResult>();
        foreach (Bet bet in bets)
        {
            decimal payout = CalculateBetPayout(roulettedNumber, bet);
            betResults.Add(new BetResult(bet, payout));
        } 
        
        return new GameResult(betResults, roulettedNumber);
    }

    private decimal CalculateBetPayout(int RoulettedNumber, Bet bet)
    {
        switch (bet.BetType)
        {
            case "Odd/even":
                if(RoulettedNumber == 0) return 0;
                if(bet.OddOrEven == "odd" && RoulettedNumber % 2 != 0) return bet.Amount * 2;
                if(bet.OddOrEven == "even" && RoulettedNumber % 2 == 0) return bet.Amount * 2;
            break;
            
            case "Column":
                if(RoulettedNumber == 0) return 0;
                if(RoulettedNumber > 0 && RoulettedNumber <= 12 && bet.choosenColumn == "1-12") return bet.Amount * 3;
                if(RoulettedNumber > 12 && RoulettedNumber <= 24 && bet.choosenColumn == "13-24") return bet.Amount * 3;
                if(RoulettedNumber > 24 && RoulettedNumber <= 36 && bet.choosenColumn == "25-36") return bet.Amount * 3;
            break;
            
            case "Number":
                if(RoulettedNumber == bet.ChoosenNumber) return bet.Amount * 36;
                else return 0;

            default:
                Console.WriteLine("Nenhum Tipo de Aposta válido foi fornecido");
                return 0;
        }
        return 0;
        
    }
}
