using csharp_code_test;

namespace csharp_code_test_tests;

public class ProblemCTests
{
    [Test]
    public void TotalFeeOfIPTV()
    {
        var totalFeeOfService = ProblemC.GetTotalFeeForSubscriptionsService(Addresses.All, "IPTV");
        Assert.That(totalFeeOfService, Is.EqualTo(525));
    }
}