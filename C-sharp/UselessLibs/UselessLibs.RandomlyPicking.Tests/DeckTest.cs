namespace UselessLibs.RandomlyPicking.Tests;

public class DeckTest
{
    private ITestOutputHelper Output { get; }

    public DeckTest(ITestOutputHelper output)
    {
        Output = output;
    }

    [Fact]
    public void SearchCardRandomlyInDeck()
    {
        var card = new Card(Level._K , Suits.s);

        

        Output.WriteLine(card.ToString());

    }
}