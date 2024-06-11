// See https://aka.ms/new-console-template for more information
public class ParamsCollectionsExample
{
    public void AddItems(params List<int> items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}