using csharp_code_test;

namespace csharp_code_test_tests;

public class ProblemBTests
{
    [Test]
    public void FeeOfActiveSubscriptionsDuringOctober2021()
    {
        var totalFeeOctober =
            ProblemB.GetTotalFeeForActiveSubscriptionDuringYearAndMonth(Addresses.All, 2021, 10);
        Assert.That(totalFeeOctober, Is.EqualTo(975));
    }

    [Test]
    public void FeeOfActiveSubscriptionsDuringDecember2021()
    {
        var totalFeeDecember =
            ProblemB.GetTotalFeeForActiveSubscriptionDuringYearAndMonth(Addresses.All, 2021, 12);
        Assert.That(totalFeeDecember, Is.EqualTo(1325));
    }
}
