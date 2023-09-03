namespace UselessLibs.RandomlyPicking;
public class Deck<T> where T : class
{
    private List<T> HiddenList;

    public Deck()
    {
        HiddenList = new List<T>();
    }

    public Deck(List<T> list)
    {
        HiddenList = new List<T>();
        AddRange(list);
    }

    public void AddRange(List<T> list)
    {
        HiddenList.AddRange (list);
    }

    public void Add(T item)
    {
        HiddenList.Add(item);
    }

    public List<T> Draw(int numberTimes)
    {
        var random = new Random();
        var randomIndex = random.Next(HiddenList.Count);
        var teste = (T)HiddenList[randomIndex];  

        return new List<T>();

    }

    public T Draw()
    {
        var random = new Random();
        var randomIndex = random.Next(HiddenList.Count);
        return (T)HiddenList[randomIndex]; 
    }
}
