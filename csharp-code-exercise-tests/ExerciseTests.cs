using exercise;

namespace exercise_tests;

public class ExerciseTests
{
    [Test]
    public void ReturnsAllActiveSubscriptionsWhenYearIsMaxValue()
    {
        var futureYear = int.MaxValue;
        var subscriptionActive = Exercise.GetActiveSubscriptionsDuringYearAndMonth(
            Addresses.All, futureYear, 1);

        Assert.That(
            subscriptionActive.Count,
            Is.EqualTo(Addresses.All.SelectMany(adr => adr.Subscriptions).Count())
        );
    }

    [Test]
    public void ReturnsNoActiveSubscriptionsWhenYearIsMinValue()
    {
        var pastYear = int.MinValue;
        var subscriptionActive = Exercise.GetActiveSubscriptionsDuringYearAndMonth(
            Addresses.All, pastYear, 1);

        Assert.That(subscriptionActive.Count, Is.EqualTo(0));
    }

    [Test]
    public void ReturnsActiveSubscriptionsLimitedToTheGivenMonth()
    {
        var addresses = new List<Address>
        {
            new() {
                Subscriptions =
                [
                    new Subscription { ActivationYear = 2021, ActivationMonth = 1 },
                    new Subscription { ActivationYear = 2021, ActivationMonth = 2 },
                    new Subscription { ActivationYear = 2021, ActivationMonth = 3 },
                    new Subscription { ActivationYear = 2022, ActivationMonth = 1 },
                    new Subscription { ActivationYear = 2022, ActivationMonth = 2 },
                    new Subscription { ActivationYear = 2022, ActivationMonth = 3 },
                    new Subscription { ActivationYear = 2023, ActivationMonth = 1 },
                    new Subscription { ActivationYear = 2023, ActivationMonth = 2 },
                    new Subscription { ActivationYear = 2023, ActivationMonth = 3 },
                ]
            }
        };

        var subscriptionActive = Exercise.GetActiveSubscriptionsDuringYearAndMonth(addresses, 2022, 2);

        Assert.That(
            subscriptionActive.Count,
            Is.EqualTo(5)
        );
    }
}