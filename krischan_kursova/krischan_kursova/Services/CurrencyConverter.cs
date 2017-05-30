using krischan_kursova.Models;
using System.Collections.Generic;

namespace krischan_kursova.Services
{
    class CurrencyConverter
    {
        private Dictionary<Currency, CurrencyInfo> currencies;

        public CurrencyConverter()
        {
            InitializeCurrencies();
        }

        public double ConvertTo(Currency currency, double value)
        {
            var info = currencies[currency];
            return value * info.BGN_Reverse;
        }

        public double ConvertFrom(Currency currency, double value)
        {
            var info = currencies[currency];
            return value * info.BGN;
        }

        private void InitializeCurrencies()
        {
            currencies = new Dictionary<Currency, CurrencyInfo>();
            currencies.Add(Currency.AUD, new CurrencyInfo
            {
                BGN = 1.3277,
                BGN_Reverse = 0.753182
            });
            currencies.Add(Currency.BRL, new CurrencyInfo
            {
                BGN = 5.71429,
                BGN_Reverse = 1.75
            });
            currencies.Add(Currency.CAD, new CurrencyInfo
            {
                BGN = 1.30904,
                BGN_Reverse = 0.763919
            });
            currencies.Add(Currency.CHF, new CurrencyInfo
            {
                BGN = 1.78403,
                BGN_Reverse = 0.560529
            });
            currencies.Add(Currency.CNY, new CurrencyInfo
            {
                BGN = 2.60614,
                BGN_Reverse = 3.83709
            });
            currencies.Add(Currency.CZK, new CurrencyInfo
            {
                BGN = 7.35938,
                BGN_Reverse = 13.5881
            });
            currencies.Add(Currency.DKK, new CurrencyInfo
            {
                BGN = 2.62873,
                BGN_Reverse = 3.80412
            });
            currencies.Add(Currency.GBP, new CurrencyInfo
            {
                BGN = 2.31218,
                BGN_Reverse = 0.432492
            });
            currencies.Add(Currency.HKD, new CurrencyInfo
            {
                BGN = 2.30746,
                BGN_Reverse = 4.33377
            });
            currencies.Add(Currency.HRK, new CurrencyInfo
            {
                BGN = 2.635,
                BGN_Reverse = 3.79507
            });
            currencies.Add(Currency.HUF, new CurrencyInfo
            {
                BGN = 6.30425,
                BGN_Reverse = 158.623
            });
            currencies.Add(Currency.IDR, new CurrencyInfo
            {
                BGN = 1.34911,
                BGN_Reverse = 7412.29
            });
            currencies.Add(Currency.ILS, new CurrencyInfo
            {
                BGN = 4.98898,
                BGN_Reverse = 2.00442
            });
            currencies.Add(Currency.INR, new CurrencyInfo
            {
                BGN = 2.79646,
                BGN_Reverse = 35.7595
            });
            currencies.Add(Currency.JPY, new CurrencyInfo
            {
                BGN = 1.57958,
                BGN_Reverse = 63.308
            });
            currencies.Add(Currency.KRW, new CurrencyInfo
            {
                BGN = 1.59462,
                BGN_Reverse = 627.109
            });
            currencies.Add(Currency.MXN, new CurrencyInfo
            {
                BGN = 9.51645,
                BGN_Reverse = 10.5081
            });
            currencies.Add(Currency.MYR, new CurrencyInfo
            {
                BGN = 4.13994,
                BGN_Reverse = 2.41549
            });
            currencies.Add(Currency.NOK, new CurrencyInfo
            {
                BGN = 2.08811,
                BGN_Reverse = 4.78902
            });
            currencies.Add(Currency.NZD, new CurrencyInfo
            {
                BGN = 1.2307,
                BGN_Reverse = 0.812546
            });
            currencies.Add(Currency.PHP, new CurrencyInfo
            {
                BGN = 3.61608,
                BGN_Reverse = 27.6543
            });
            currencies.Add(Currency.PLN, new CurrencyInfo
            {
                BGN = 4.63797,
                BGN_Reverse = 2.15612
            });
            currencies.Add(Currency.RON, new CurrencyInfo
            {
                BGN = 4.30326,
                BGN_Reverse = 2.32382
            });
            currencies.Add(Currency.RUB, new CurrencyInfo
            {
                BGN = 3.13863,
                BGN_Reverse = 31.861
            });
            currencies.Add(Currency.SEK, new CurrencyInfo
            {
                BGN = 2.02314,
                BGN_Reverse = 4.94281
            });
            currencies.Add(Currency.SGD, new CurrencyInfo
            {
                BGN = 1.27715,
                BGN_Reverse = 0.782993
            });
            currencies.Add(Currency.THB, new CurrencyInfo
            {
                BGN = 5.17717,
                BGN_Reverse = 19.3156
            });
            currencies.Add(Currency.TRY, new CurrencyInfo
            {
                BGN = 5.01007,
                BGN_Reverse = 1.99598
            });
            currencies.Add(Currency.USD, new CurrencyInfo
            {
                BGN = 1.7983,
                BGN_Reverse = 0.556081
            });
            currencies.Add(Currency.ZAR, new CurrencyInfo
            {
                BGN = 1.33653,
                BGN_Reverse = 7.48206
            });
        }
    }
}
