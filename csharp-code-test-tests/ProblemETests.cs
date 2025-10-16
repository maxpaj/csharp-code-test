using csharp_code_test;

namespace csharp_code_test_tests;

public class ProblemETests
{
    [Test]
    public void CitiesOrderedByNumberOfSubscriptions()
    {
        var citiesSubscriptionNumbers = ProblemE.GetCitiesOrderedByNumberOfSubscriptions(Addresses.All);
        var first = citiesSubscriptionNumbers.First();

        Assert.Multiple(() =>
        {
            Assert.That(first.Subscriptions, Is.EqualTo(11));
            Assert.That(first.City, Is.EqualTo("Stockholm"));
        });
    }
}
