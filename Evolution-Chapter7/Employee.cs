public record Employee(string FirstName, string LastName)
{
    // Instance method
    public string FullName() => $"{FirstName} {LastName}";

    // Static method
    public static Employee CreateAnonymous()
    {
        return new Employee("John", "Doe");
    }

    // Override ToString method for custom string representation
    public override string ToString()
    {
        return $"Person: {FullName()}";
    }

    // Method to greet another person
    public string Greet(Employee other)
    {
        return $"Hello {other.FirstName}, I am {FullName()}";
    }
}