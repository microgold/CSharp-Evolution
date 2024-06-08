
// demo the new pattern matching features

// demo the generic preference
public class TestInOverload
{
    public void Test(in int number)
    {
        Console.WriteLine("In int number");
    }

    public void Test(int number)
    {
        Console.WriteLine("Int number");
    }
}

