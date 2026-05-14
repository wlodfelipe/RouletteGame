namespace roleta;

public class BetResult(Bet bet, decimal amountPayout)
{
    public string BetType { get; set; } = bet.BetType;
    public decimal AmountResult { get; set; } = amountPayout;
}