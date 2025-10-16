namespace csharp_code_test;

public class ProblemA
{
    /// <summary>
    /// Finds subscriptions that are active or has been activated during a given month of a year.
    /// 
    /// Active means that the activation date (year and month) of the subscription is the given year and month, or that the subscription activation date has passed the given year and month.
    /// </summary>
    /// <param name="addresses">A enumerable of addresses</param>
    /// <param name="year">Any year</param>
    /// <param name="month">Any month of a year (numbered 1 through 12)</param>
    /// <returns>All subscriptions that are active for the given year, month and addresses</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static IEnumerable<Subscription> GetActiveSubscriptionsDuringYearAndMonth(IEnumerable<Address> addresses, int year,
        int month)
    {
        throw new NotImplementedException();
    }
}