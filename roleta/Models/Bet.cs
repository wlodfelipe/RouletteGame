namespace roleta;

public class Bet(string betType, decimal amount, int? choosenNumber = null, string? oddOrEven = null, string? choosenColumn = null)
{
    public string BetType { get; set; } = betType; // se eh public pode ser sem get e set ?? E o init em vez de set?
    public decimal Amount { get; set; } = amount;
    public int? ChoosenNumber { get; set; } = choosenNumber;
    public string? OddOrEven { get; set; } = oddOrEven;
    public string? choosenColumn { get; set; } = choosenColumn;
}