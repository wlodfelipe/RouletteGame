namespace roleta;

public class RouletteService(Bet bet)
{

    public decimal CalculateBetResult(int RoulettedNumber)
    {
        switch (bet.BetType)
        {
            case "Pair/even":
                if(RoulettedNumber == 0) return 0;
                if(bet.OddOrEven == "odd" && RoulettedNumber % 2 != 0) return bet.Amount * 2;
                if(bet.OddOrEven == "even" && RoulettedNumber % 2 == 0) return bet.Amount * 2;
                
                return 0;
            
            case "Column":
                if(RoulettedNumber == 0) return 0;
                if(RoulettedNumber <= 12 && bet.choosenColumn == "1-12") return bet.Amount * 3;
                if(RoulettedNumber <= 24 && bet.choosenColumn == "13-24") return bet.Amount * 3;
                if(RoulettedNumber <= 36 && bet.choosenColumn == "25-36") return bet.Amount * 3;

                return 0;
            
            case "Number":
                if(RoulettedNumber == bet.ChoosenNumber) return bet.Amount * (int) bet.ChoosenNumber;
                return 0;

            default:
                Console.WriteLine("Nenhum Tipo de Aposta válido foi fornecido");
                return bet.Amount;
        }
    }
}
