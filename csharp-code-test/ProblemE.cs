namespace csharp_code_test;

public class ProblemE
{
    /// <summary>
    /// Calculates the number of subscriptions per city, and returns an enumerable of city/number-of-subscriptions pairs ordered so that the city with highest number of subscriptions appear first, and the city with least appears last. 
    /// 
    /// For example, given two cities A and B where there are two subscriptions in city A and zero subscriptions in city B, the calculated enumerable of pairs would contain 
    /// 
    /// [
    ///     { City A, Subscription 2 }, 
    ///     { City B, Subscriptions 0 }
    /// ]
    /// </summary>
    /// <param name="addresses">A enumerable of addresses</param>
    /// <returns>A list of city/number-of-subscriptions pairs</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static IEnumerable<(string City, int Subscriptions)> GetCitiesOrderedByNumberOfSubscriptions(
        IEnumerable<Address> addresses)
    {
        throw new NotImplementedException();
    }
}