namespace UselessLibs.RandomlyPicking;
public class Card{

    private Level _level;
    private Suits _suits;

    public Card (Level level, Suits suits)
    {
        _level = level;
        _suits = suits;
    }
    
    public override string ToString()
    {
        return $"{_level}{_suits}";
    }
}



