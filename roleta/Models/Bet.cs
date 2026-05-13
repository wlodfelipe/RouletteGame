namespace roleta;

public class Bet(string betType, decimal amount, int? choosenNumber = null, string? oddOrEven = null, string? choosenColumn = null)
{
    public string BetType { get; set; } = betType;
    public decimal Amount { get; set; } = amount;
    public int? ChoosenNumber { get; set; } = choosenNumber;
    public string? OddOrEven { get; set; } = oddOrEven;
    public string? choosenColumn { get; set; } = choosenColumn;

}
