namespace csharp_code_test;

public class ProblemB
{
    /// <summary>
    /// Given a year and month, and a collection of addresses, find the total fee of subscriptions that are active.
    /// A subscription is active when the subscription activation date (year and month) is either in the past relative to the given year and month, or when the subscription activation date is the exact given year and month.
    /// </summary>
    /// <param name="addresses">A enumerable of addresses</param>
    /// <param name="year">Any year</param>
    /// <param name="month">Any month of a year (numbered 1 through 12)</param>
    /// <returns>The total fee of a active subscriptions for the given year-month.</returns>
    public static decimal GetTotalFeeForActiveSubscriptionDuringYearAndMonth(IEnumerable<Address> addresses,
        int year, int month)
    {
        throw new NotImplementedException();
    }
}