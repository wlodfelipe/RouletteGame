namespace roleta;

public class BetResult(Bet bet, int roulettedNumber, decimal amountResult)
{
    public string BetType { get; set; } = bet.BetType;
    public decimal Amount { get; set; } = bet.Amount;
    public int RoulettedNumber { get; set; } = roulettedNumber;
    public decimal AmountResult { get; set; } = amountResult;
}