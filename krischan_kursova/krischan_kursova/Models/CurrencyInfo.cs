namespace krischan_kursova.Models
{
    enum Currency
    {
        AUD,
        BRL,
        CAD,
        CHF,
        CNY,
        CZK,
        DKK,
        GBP,
        HKD,
        HRK,
        HUF,
        IDR,
        ILS,
        INR,
        JPY,
        KRW,
        MXN,
        MYR,
        NOK,
        NZD,
        PHP,
        PLN,
        RON,
        RUB,
        SEK,
        SGD,
        THB,
        TRY,
        USD,
        ZAR
    }

    class CurrencyInfo
    {
        public double BGN { get; set; }

        public double BGN_Reverse { get; set; }
    }
}
