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
}