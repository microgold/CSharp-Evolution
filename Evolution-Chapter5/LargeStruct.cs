public struct LargeStruct
{
    public int Id;
    public double Width, Height, Depth;
    public decimal Cost;
    public DateTime LastUpdated;
    public string TonsOfData;

    // Constructor to initialize the struct conveniently
    public LargeStruct(int id, double width, double height, double depth, decimal cost, string tonsOfData)
    {
        Id = id;
        Width = width;
        Height = height;
        Depth = depth;
        Cost = cost;
        LastUpdated = DateTime.Now;
        TonsOfData = tonsOfData;
    }

    public void UpdateDimensions(double width, double height, double depth, string tonsOfData)
    {
        Width = width;
        Height = height;
        Depth = depth;
        LastUpdated = DateTime.Now;
        TonsOfData = tonsOfData;
    }
}