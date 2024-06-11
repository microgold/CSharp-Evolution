
//inline array

[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer
{
    private int _element0;

    public Buffer()
    {
        _element0 = 15;
        // compiler automatically fills in
        // the other 9 elements with default values
    }

    
}
