namespace ElektronickePosudky.Infrastructure.Utils
{
    public enum CiselnikType
    {
        None = 0,

        //from jsons
        Akce = 1,
        DruhPosudku,
        DruhProhlidky,
        HarmonizovaneKody,
        NarodniKody,
        SeznamSkupin,
        StavPosudku,
        Vysledek,
        ZadatelSkupina,

        //non-json
        Odbnornost,
    }
}
