public class DerivedClass : BaseClass
{
    public void SetValue(int value)
    {
        Value = value; // Accessible due to being a derived class
    }
}
