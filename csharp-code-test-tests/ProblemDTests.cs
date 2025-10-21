using csharp_code_test;

namespace csharp_code_test_tests;

public class ProblemDTests
{
    [Test]
    public void FutureActivedSubscriptionsInOctober2021()
    {
        var subscriptionsActiveInOctober = ProblemD.GetAddressesWithFutureSubscriptionActivations(TestAddresses.All, 2021, 10);
        Assert.That(subscriptionsActiveInOctober.Count, Is.EqualTo(6));
    }

    [Test]
    public void FutureActivedSubscriptionsInDecember2021()
    {
        var subscriptionsActiveInDecember = ProblemD.GetAddressesWithFutureSubscriptionActivations(TestAddresses.All, 2021, 12);
        Assert.That(subscriptionsActiveInDecember.Count, Is.EqualTo(2));
    }
}
