namespace csharp_code_test;

public class ProblemD
{
    /// <summary>
    /// Finds all addresses with yet-to-be activated subscriptions, given the current date as a year-month combination.
    /// A subscription is active when the subscription activation date (year and month) is either in the past relative to the given year and month, or when the subscription activation date is the exact given year and month.
    /// </summary>
    /// <param name="addresses">A enumerable of addresses</param>
    /// <param name="year">Any year</param>
    /// <param name="month">Any month of a year (numbered 1 through 12)</param>
    /// <returns>All addresses with yet-to-be subscription activations.</returns>
    public static IEnumerable<Address> GetAddressesWithFutureSubscriptionActivations(
        IEnumerable<Address> addresses, int year, int month)
    {
        throw new NotImplementedException();
    }
}
