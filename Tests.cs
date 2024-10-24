﻿using NUnit.Framework;

namespace csharp_code_test;

[TestFixture]
public class Tests
{
    [Test]
    public void GetActiveSubscriptionsDuringYearAndMonthTest()
    {
        var subscriptionsActiveInOctober = Program.GetActiveSubscriptionsDuringYearAndMonth(Program.AllAddresses, 2024, 10);
        Assert.That(subscriptionsActiveInOctober.Count, Is.EqualTo(11));
        
        var subscriptionsActiveInDecember = Program.GetActiveSubscriptionsDuringYearAndMonth(Program.AllAddresses, 2024, 12);
        Assert.That(subscriptionsActiveInDecember.Count, Is.EqualTo(15));
    }

    [Test]
    public void GetTotalFeeForActiveSubscriptionDuringYearAndMonthTest()
    {
        var totalFeeOctober =
            Program.GetTotalFeeForActiveSubscriptionDuringYearAndMonth(Program.AllAddresses, 2024, 10);
        Assert.That(totalFeeOctober, Is.EqualTo(1325));

        var totalFeeNovember =
            Program.GetTotalFeeForActiveSubscriptionDuringYearAndMonth(Program.AllAddresses, 2024, 11);
        Assert.That(totalFeeNovember, Is.EqualTo(525));
    }

    [Test]
    public void GetCitiesOrderedByNumberOfSubscriptions()
    {
        var citiesSubscriptionNumbers = Program.GetCitiesOrderedByNumberOfSubscriptions(Program.AllAddresses);
        var first = citiesSubscriptionNumbers.First();

        Assert.That(first.Subscriptions, Is.EqualTo(11));
        Assert.That(first.City, Is.EqualTo("Stockholm"));
    }
}