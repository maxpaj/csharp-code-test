namespace csharp_code_test;

/// <summary>
/// Represents a service subscription, with activation date and fee.
/// </summary>
public class Subscription
{
    public decimal Fee { get; set; }
    public string Service { get; set; }
    public int ActivationYear { get; set; }
    public int ActivationMonth { get; set; }
}

/// <summary>
/// Represents an area of a city, with any subscriptions attached to that area
/// </summary>
public class Address
{
    public string PostalArea { get; set; }
    public string City { get; set; }
    public List<Subscription> Subscriptions { get; set; }
}

public class Program
{
    public static void Main()
    {
        var activeSubscriptionsDuringYearAndMonth = GetActiveSubscriptionsDuringYearAndMonth(AllAddresses, 2024, 10);

        var totalFeeForOctober = GetTotalFeeForActiveSubscriptionDuringYearAndMonth(AllAddresses, 2024, 10);

        var addressesObjectsWithFutureActivations =
            GetAddressesWithFutureSubscriptionActivations(AllAddresses, 2024, 10);

        var totalFeeForIPTV = GetTotalFeeForSubscriptionsService(AllAddresses, "IPTV");

        var citiesOrderedByNumberOfSubscriptions = GetCitiesOrderedByNumberOfSubscriptions(AllAddresses);
    }

    /// <summary>
    /// Finds subscriptions that are active during any time of a given year-month combination.
    /// 
    /// Active meaning, the ActivationYear and ActivationMonth of the subscription is the current year-month, or the date combination is in the past.
    /// </summary>
    /// <param name="addresses"></param>
    /// <param name="year"></param>
    /// <param name="month"></param>
    /// <returns>The total fee of the active subscriptions</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static IEnumerable<Subscription> GetActiveSubscriptionsDuringYearAndMonth(List<Address> addresses, int year,
        int month)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Finds the total fee of subscriptions that are active during any given year-month combination.
    /// 
    /// Active meaning, the ActivationYear and ActivationMonth of the subscription is the current year-month, or the date combination is in the past.
    /// </summary>
    /// <param name="addresses"></param>
    /// <param name="year"></param>
    /// <param name="month"></param>
    /// <returns>The total fee of the active subscriptions</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static decimal GetTotalFeeForActiveSubscriptionDuringYearAndMonth(List<Address> addresses,
        int year, int month)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Finds the total fee of a specific subscription service across all addresses.
    /// </summary>
    /// <param name="addresses"></param>
    /// <param name="service"></param>
    /// <returns>Fee of subscription service across all addresses.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static decimal GetTotalFeeForSubscriptionsService(List<Address> addresses, string service)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Finds all addresses with yet-to-be activated subscriptions, given the current date as a year-month combination.
    /// </summary>
    /// <param name="addresses"></param>
    /// <param name="currentYear"></param>
    /// <param name="currentMonth"></param>
    /// <returns>All addresses with yet-to-be subscription activations.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static IEnumerable<Address> GetAddressesWithFutureSubscriptionActivations(
        List<Address> addresses, int currentYear, int currentMonth)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Calculates the number of subscriptions per city, and returns a list of city/number-of-subscriptions pairs ordered so that the city with highest number of subscriptions appear first, and the city with least appears last.
    /// </summary>
    /// <param name="address"></param>
    /// <returns>A list of city/number-of-subscriptions pairs</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static IEnumerable<(string City, int Subscriptions)> GetCitiesOrderedByNumberOfSubscriptions(
        List<Address> address)
    {
        throw new NotImplementedException();
    }

    public static readonly List<Address> AllAddresses =
    [
        new Address
        {
            City = "Stockholm",
            PostalArea = "Odenplan",
            Subscriptions =
            [
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 10,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 10,
                    Fee = 75,
                    Service = "IPTV",
                }
            ]
        },
        new Address
        {
            City = "Stockholm",
            PostalArea = "Odenplan",
            Subscriptions =
            [
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 12,
                    Fee = 100,
                    Service = "100/100 Mbit",
                }
            ]
        },
        new Address
        {
            City = "Umeå",
            PostalArea = "Kungsgatan",
            Subscriptions =
            [
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 12,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 10,
                    Fee = 75,
                    Service = "IPTV",
                }
            ]
        },
        new Address
        {
            City = "Stockholm",
            PostalArea = "Bromma",
            Subscriptions =
            [
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 10,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 10,
                    Fee = 75,
                    Service = "VPN",
                }
            ]
        },
        new Address
        {
            City = "Stockholm",
            PostalArea = "Bromma",
            Subscriptions =
            [
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 10,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2025,
                    ActivationMonth = 11,
                    Fee = 75,
                    Service = "IPTV",
                }
            ]
        },
        new Address
        {
            City = "Stockholm",
            PostalArea = "Bromma",
            Subscriptions =
            [
                new Subscription()
                {
                    ActivationYear = 2025,
                    ActivationMonth = 11,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 10,
                    Fee = 75,
                    Service = "IPTV",
                }
            ]
        },
        new Address
        {
            City = "Malmö",
            PostalArea = "Centrum",
            Subscriptions =
            [
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 9,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 9,
                    Fee = 75,
                    Service = "IPTV",
                }
            ]
        },
        new Address
        {
            City = "Malmö",
            PostalArea = "Centrum",
            Subscriptions =
            [
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 10,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 12,
                    Fee = 75,
                    Service = "IPTV",
                }
            ]
        },
        new Address
        {
            City = "Stockholm",
            PostalArea = "Odenplan",
            Subscriptions =
            [
                new Subscription()
                {
                    ActivationYear = 2023,
                    ActivationMonth = 12,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2024,
                    ActivationMonth = 12,
                    Fee = 75,
                    Service = "IPTV",
                }
            ]
        }
    ];
}