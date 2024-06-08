
    public class TestNullableOverload
    {
        public void Test(int? number)
        {
            Console.WriteLine("Nullable int");
        }

        public void Test(int number)
        {
            Console.WriteLine("Int");
        }
    }

