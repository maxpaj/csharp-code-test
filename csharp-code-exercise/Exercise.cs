namespace exercise;

public class Exercise
{
    /// <summary>
    /// Given the input year, month and a collection of addresses with associated 
    /// subscriptions, find all the subscriptions that are active.
    /// 
    /// A subscription is considered active when the its activation 
    /// date (year and month) is either in the past relative to the input year 
    /// and month, or when the subscription activation date is the exact input 
    /// year and month.
    /// </summary>
    /// <param name="addresses">A enumerable of addresses</param>
    /// <param name="year">Any year</param>
    /// <param name="month">Any month of a year (numbered 1 through 12)</param>
    /// <returns>
    /// Subscriptions on the given addresses that are active for the 
    /// given year-month.
    /// </returns>
    public static IEnumerable<Subscription> GetActiveSubscriptionsDuringYearAndMonth(
        IEnumerable<Address> addresses,
        int year,
        int month
    )
    {
        throw new NotImplementedException();
    }
}
