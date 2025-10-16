namespace csharp_code_test;

public class ProblemB
{
    /// <summary>
    /// Finds the total fee of subscriptions that are active during any given year-month combination.
    /// 
    /// Active means that the activation date (year and month) of the subscription is the given year and month, or that the subscription activation date has passed the given year and month.
    /// </summary>
    /// <param name="addresses">A enumerable of addresses</param>
    /// <param name="year">Any year</param>
    /// <param name="month">Any month of a year (numbered 1 through 12)</param>
    /// <returns>The total fee of the active subscriptions</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static decimal GetTotalFeeForActiveSubscriptionDuringYearAndMonth(IEnumerable<Address> addresses,
        int year, int month)
    {
        throw new NotImplementedException();
    }
}