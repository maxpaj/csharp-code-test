namespace exercise;

/// <summary>
/// Represents a service subscription, with activation date and fee.
/// </summary>
public class Subscription
{
    public decimal Fee { get; set; }
    public string Service { get; set; }
    public int ActivationYear { get; set; }
    public int ActivationMonth { get; set; }
}
