using csharp_code_test;

namespace csharp_code_test_tests;

public static class TestAddresses
{
    public static readonly List<Address> All =
    [
        new Address
        {
            City = "Stockholm",
            PostalArea = "Odenplan",
            Subscriptions =
            [
                new Subscription()
                {
                    ActivationYear = 2021,
                    ActivationMonth = 10,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2021,
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
                    ActivationYear = 2021,
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
                    ActivationYear = 2021,
                    ActivationMonth = 12,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2021,
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
                    ActivationYear = 2021,
                    ActivationMonth = 10,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2021,
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
                    ActivationYear = 2021,
                    ActivationMonth = 10,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2035,
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
                    ActivationYear = 2035,
                    ActivationMonth = 11,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2021,
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
                    ActivationYear = 2021,
                    ActivationMonth = 5,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2021,
                    ActivationMonth = 5,
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
                    ActivationYear = 2021,
                    ActivationMonth = 10,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2021,
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
                    ActivationYear = 2020,
                    ActivationMonth = 12,
                    Fee = 100,
                    Service = "100/100 Mbit",
                },
                new Subscription()
                {
                    ActivationYear = 2021,
                    ActivationMonth = 12,
                    Fee = 75,
                    Service = "IPTV",
                }
            ]
        }
    ];
}
