// See https://aka.ms/new-console-template for more information
#nullable enable
public class Person
{
    public string Name { get; set; } // Non-nullable reference type
    public string? MiddleName { get; set; } // Nullable reference type

    public Person(string name, string? middleName = null)
    {
        Name = name ?? throw new ArgumentNullException(
                                        nameof(name));
        MiddleName = middleName; // Allowed to be null
    }
}
