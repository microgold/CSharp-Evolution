public class Inventory
{
    private LargeStruct[] items = [];

    public Inventory()
    {
        // Initialize with some dummy data
        List<LargeStruct> list = new List<LargeStruct>();
        string myVeryLargeString = "MASSIVE_STRING";
        // Initialize with some dummy data
        list.Add(new LargeStruct(1, 10.0, 20.0, 30.0, 1000m, myVeryLargeString));
        string myOtherVeryLargeString = "OTHER_MASSIVE_STRING";
        list.Add(new LargeStruct(2, 15.0, 25.0, 35.0, 1500m, myOtherVeryLargeString));

        // refs can only point to items in arrays, so we need to convert the list to an array
        items = list.ToArray();
    }

    // Method to find an item and return a ref to it
    public ref LargeStruct FindItem(int id)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i].Id == id)
                return ref items[i];  // Return a reference to the struct in the list
        }
        throw new Exception("Item not found");
    }
}