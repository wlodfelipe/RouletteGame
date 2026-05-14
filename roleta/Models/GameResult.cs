namespace roleta;

public class GameResult(List<BetResult> results, int roulettedNumber)
{
    public List<BetResult> Results { get; set; } = results;
    public int RoulettedNumber { get; init; } = roulettedNumber;
}
