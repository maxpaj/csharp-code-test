using csharp_code_test;

namespace csharp_code_test_tests;

public class ProblemATests
{
    [Test]
    public void ReturnsAllActiveSubscriptions()
    {
        var futureYear = int.MaxValue;
        var subscriptionActive = ProblemA.GetActiveSubscriptionsDuringYearAndMonth(TestAddresses.All, futureYear, 1);
        Assert.That(subscriptionActive.Count, Is.EqualTo(TestAddresses.All.SelectMany(adr => adr.Subscriptions).Count()));
    }

    [Test]
    public void ReturnsNoActiveSubscriptions()
    {
        var pastYear = int.MinValue;
        var subscriptionActive = ProblemA.GetActiveSubscriptionsDuringYearAndMonth(TestAddresses.All, pastYear, 1);
        Assert.That(subscriptionActive.Count, Is.EqualTo(0));
    }

    [Test]
    public void ReturnsActiveSubscriptionsWhenGivenMonthIsLessThanSubscriptionActivationMonth()
    {
        var givenYear = 2021;
        var givenMonth = 10;

        var previousYear = 2020;
        var previousYearMonth = 12;

        var addresses = new List<Address>
        {
            new() {
                Subscriptions =
                [
                    new Subscription()
                    {
                        ActivationYear = givenYear,
                        ActivationMonth = givenMonth,
                        Fee = 100,
                        Service = "100/100 Mbit",
                    },
                    new Subscription()
                    {
                        ActivationYear = givenYear,
                        ActivationMonth = givenMonth,
                        Fee = 75,
                        Service = "IPTV",
                    },
                    new Subscription()
                    {
                        ActivationYear = previousYear,
                        ActivationMonth = previousYearMonth,
                        Fee = 100,
                        Service = "100/100 Mbit",
                    }
                ]
            }
        };


        var subscriptionActive = ProblemA.GetActiveSubscriptionsDuringYearAndMonth(addresses, givenYear, givenMonth);
        Assert.That(subscriptionActive.Count, Is.EqualTo(3));
    }
}