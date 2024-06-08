namespace Evolution.Chapter2
{
   public class Matrix
    {
    private int[,] data;

    public Matrix(int size)
    {
        data = new int[size, size];
        // Initialize with some values, for demonstration
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
                data[i, j] = i + j;
    }

    // Method to find an element that matches a certain condition
    public ref int FindElement(int target)
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                if (data[i, j] == target)
                    return ref data[i, j]; // Return a reference to the matrix element
            }
        }
        throw new IndexOutOfRangeException("Element not found");
    }
}
}
