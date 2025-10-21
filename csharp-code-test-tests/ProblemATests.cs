using csharp_code_test;

namespace csharp_code_test_tests;

public class ProblemATests
{
    [Test]
    public void ActiveSubscriptionsJanuary2021()
    {
        var subscriptionActive = ProblemA.GetActiveSubscriptionsDuringYearAndMonth(TestAddresses.All, 2021, 1);
        Assert.That(subscriptionActive.Count, Is.EqualTo(1));
    }

    [Test]
    public void ActiveSubscriptionsOctober2021()
    {
        var subscriptionActive = ProblemA.GetActiveSubscriptionsDuringYearAndMonth(TestAddresses.All, 2021, 10);
        Assert.That(subscriptionActive.Count, Is.EqualTo(11));
    }

    [Test]
    public void ActiveSubscriptionDecember2021()
    {
        var subscriptionActive = ProblemA.GetActiveSubscriptionsDuringYearAndMonth(TestAddresses.All, 2021, 12);
        Assert.That(subscriptionActive.Count, Is.EqualTo(15));
    }
}