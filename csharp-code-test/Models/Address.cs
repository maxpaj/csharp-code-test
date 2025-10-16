namespace csharp_code_test;

/// <summary>
/// Represents an area of a city, with any subscriptions attached to that area
/// </summary>
public class Address
{
    public string PostalArea { get; set; }
    public string City { get; set; }
    public List<Subscription> Subscriptions { get; set; }
}
