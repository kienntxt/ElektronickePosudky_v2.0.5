using System.Globalization;
using AutoMapper;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Extensions;
using ElektronickePosudky.Application.Localization;
using ElektronickePosudky.Domain.Entities;

namespace ElektronickePosudky.Application.Mapping
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Ciselnik, CiselnikDto>()
                .ForMember(
                    dest => dest.Preklady,
                    opt =>
                        opt.MapFrom(src =>
                            src.Translations.ConvertTranslations(
                                CultureInfo.CurrentCulture.Name,
                                DefaultLocalizationOptions.DefaultCultureName,
                                DefaultLocalizationOptions.FallbackToAny
                            )
                        )
                );

            CreateMap<CiselnikPolozka, CiselnikPolozkaDto>()
                .ForMember(
                    dest => dest.Preklady,
                    opt =>
                        opt.MapFrom(src =>
                            src.Translations.ConvertTranslations(
                                CultureInfo.CurrentCulture.Name,
                                DefaultLocalizationOptions.DefaultCultureName,
                                DefaultLocalizationOptions.FallbackToAny
                            )
                        )
                );

            CreateMap<CiselnikPolozka, CiselnikPolozkaWithTranslationsDto>()
                .ForMember(dest => dest.CiselnikKod, opt => opt.MapFrom(src => src.CiselnikKod))
                .ForMember(dest => dest.CiselnikVerze, opt => opt.MapFrom(src => src.CiselnikVerze))
                .ForMember(dest => dest.PolozkaKod, opt => opt.MapFrom(src => src.Kod))
                .ForMember(
                    dest => dest.Preklady,
                    opt =>
                        opt.MapFrom(src =>
                            src.Translations.ConvertTranslations(
                                CultureInfo.CurrentCulture.Name,
                                DefaultLocalizationOptions.DefaultCultureName,
                                DefaultLocalizationOptions.FallbackToAny
                            )
                        )
                );

            CreateMap<PosudekRo, PosudekRoDetailDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Pacient, opt => opt.MapFrom(src => src.Pacient))
                .ForMember(dest => dest.ZdravotnickyPracovnik, opt => opt.MapFrom(src => src.Lekar))
                .ForMember(
                    dest => dest.PoskytovatelZdravotnickychSluzeb,
                    opt => opt.MapFrom(src => src.Lekar.Poskytovatel)
                )
                .ForMember(
                    dest => dest.OdbornostLekare,
                    opt => opt.MapFrom(src => src.Lekar.Odbornost)
                )
                .ForMember(dest => dest.StavPosudku, opt => opt.MapFrom(src => src.StavPosudku))
                .ForMember(dest => dest.DruhProhlidky, opt => opt.MapFrom(src => src.DruhProhlidky))
                .ForMember(dest => dest.DruhPosudku, opt => opt.MapFrom(src => src.DruhPosudku))
                .ForMember(
                    dest => dest.Vysledek,
                    opt =>
                        opt.MapFrom(src =>
                            src.Zpusobilosti.OrderBy(z => z.Id)
                                .Select(z => z.Vysledek)
                                .FirstOrDefault()
                        )
                )
                .ForMember(
                    dest => dest.SkupinaZadatelRidic,
                    opt =>
                        opt.MapFrom(src =>
                            src.Zpusobilosti.OrderBy(z => z.Id)
                                .Select(z => z.SkupinaZadateleRidic)
                                .FirstOrDefault()
                        )
                )
                .ForMember(
                    dest => dest.SkupinyRidicskehoOpravneni,
                    opt =>
                        opt.MapFrom(s =>
                            ConvertSkupinyRo(
                                s.Zpusobilosti.SelectMany(z => z.SkupinyRidicskehoOpravneni)
                            )
                        )
                )
                .ForMember(
                    dest => dest.HarmonizovaneKody,
                    opt =>
                        opt.MapFrom(s =>
                            ConvertHarmonizovaneKody(
                                s.Zpusobilosti.SelectMany(z => z.HarmonizovaneKody)
                            )
                        )
                )
                .ForMember(
                    dest => dest.NarodniKody,
                    opt =>
                        opt.MapFrom(s =>
                            ConvertNarodniKody(s.Zpusobilosti.SelectMany(z => z.NarodniKody))
                        )
                )
                .ForMember(
                    dest => dest.VerzeZaznamu,
                    opt =>
                        opt.MapFrom(src =>
                            Convert.ToBase64String(src.RowVersion ?? Array.Empty<byte>())
                        )
                )
                .ForMember(
                    dest => dest.DatumVytvoreni,
                    opt => opt.MapFrom(src => src.DatumVytvoreni)
                );

            CreateMap<PosudekRo, PosudekRoHlavickaDetailDto>()
                .ForMember(dest => dest.Pacient, opt => opt.MapFrom(src => src.Pacient))
                .ForMember(dest => dest.ZdravotnickyPracovnik, opt => opt.MapFrom(src => src.Lekar))
                .ForMember(
                    dest => dest.PoskytovatelZdravotnickychSluzeb,
                    opt => opt.MapFrom(src => src.Lekar.Poskytovatel)
                )
                .ForMember(
                    dest => dest.OdbornostLekare,
                    opt => opt.MapFrom(src => src.Lekar.Odbornost)
                )
                .ForMember(dest => dest.StavPosudku, opt => opt.MapFrom(src => src.StavPosudku))
                .ForMember(dest => dest.DruhProhlidky, opt => opt.MapFrom(src => src.DruhProhlidky))
                .ForMember(dest => dest.DruhPosudku, opt => opt.MapFrom(src => src.DruhPosudku))
                .ForMember(
                    dest => dest.DatumVystaveni,
                    opt => opt.MapFrom(src => src.DatumVystaveni)
                )
                .ForMember(dest => dest.PlatnostDo, opt => opt.MapFrom(src => src.PlatnostDo))
                .ForMember(
                    dest => dest.DatumVytvoreni,
                    opt => opt.MapFrom(src => src.DatumVytvoreni)
                );

            CreateMap<Pacient, PacientDto>();

            CreateMap<ZdravotnickyPracovnik, ZdravotnickyPracovnikDetailDto>()
                .ForMember(dest => dest.KrzpId, opt => opt.MapFrom(src => src.KrzpId))
                .ForMember(dest => dest.Jmeno, opt => opt.MapFrom(src => src.Jmeno))
                .ForMember(dest => dest.Prijmeni, opt => opt.MapFrom(src => src.Prijmeni))
                .ForMember(
                    dest => dest.OdbornostLekare,
                    opt => opt.MapFrom(src => GetOdbornostLekare(src.Odbornost))
                );

            CreateMap<
                PoskytovatelZdravotnickychSluzeb,
                PoskytovatelZdravotnickychSluzebDetailDto
            >();

            CreateMap<PosudekRo, ZdravotnickyPracovnikDetailDto>()
                .ForMember(dest => dest.KrzpId, opt => opt.MapFrom(src => src.KrzpId))
                .ForMember(dest => dest.Jmeno, opt => opt.MapFrom(src => src.Lekar.Jmeno))
                .ForMember(dest => dest.Prijmeni, opt => opt.MapFrom(src => src.Lekar.Prijmeni))
                .ForMember(
                    dest => dest.OdbornostLekare,
                    opt => opt.MapFrom(src => GetOdbornostLekare(src.Lekar.Odbornost))
                );

            CreateMap<PosudekRoHistory, PosudekRoHistorieDetailDto>()
                .ForMember(dest => dest.TypOperace, opt => opt.MapFrom(src => src.TypOperace))
                .ForMember(dest => dest.DatumOperace, opt => opt.MapFrom(src => src.DatumOperace))
                .ForMember(dest => dest.Lekar, opt => opt.MapFrom(src => src.Lekar))
                .ForMember(
                    dest => dest.Poskytovatel,
                    opt => opt.MapFrom(src => src.Lekar.Poskytovatel)
                );

            CreateMap<PosudekRo, PosudekRoCreateResultDto>()
                .ForMember(dest => dest.Hlavicka, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.Zpusobilosti, opt => opt.MapFrom(src => src.Zpusobilosti));

            CreateMap<PosudekRoZpusobilost, PosudekRoSkupinaZpusobilostDto>()
                .ForMember(dest => dest.PosudekId, opt => opt.MapFrom(src => src.PosudekRoId))
                .ForMember(
                    dest => dest.SkupinaZadateleRidic,
                    opt => opt.MapFrom(src => src.SkupinaZadateleRidic)
                )
                .ForMember(
                    dest => dest.SkupinyRidicskehoOpravneni,
                    opt => opt.MapFrom(src => ConvertSkupinyRo(src.SkupinyRidicskehoOpravneni))
                )
                .ForMember(dest => dest.Vysledek, opt => opt.MapFrom(src => src.Vysledek))
                .ForMember(
                    dest => dest.HarmonizovaneKody,
                    opt => opt.MapFrom(src => src.HarmonizovaneKody)
                )
                .ForMember(dest => dest.NarodniKody, opt => opt.MapFrom(src => src.NarodniKody))
                .ForMember(
                    dest => dest.VerzeZaznamu,
                    opt =>
                        opt.MapFrom(src =>
                            Convert.ToBase64String(src.RowVersion ?? Array.Empty<byte>())
                        )
                );
        }

        private IList<PosudekRoSkupinaDetailDto>? ConvertSkupinyRo(
            IEnumerable<PosudekRoSkupina> enumerable
        )
        {
            return enumerable
                ?.Select(s => new PosudekRoSkupinaDetailDto
                {
                    SkupinaRo =
                        s.SkupinaRo == null
                            ? null
                            : new CiselnikPolozkaWithTranslationsDto
                            {
                                CiselnikKod = s.SkupinaRo.CiselnikKod,
                                CiselnikVerze = s.SkupinaRo.CiselnikVerze,
                                PolozkaKod = s.SkupinaRo.Kod,
                                Preklady = s.SkupinaRo.Translations.ConvertTranslations(
                                    CultureInfo.CurrentCulture.Name,
                                    DefaultLocalizationOptions.DefaultCultureName,
                                    DefaultLocalizationOptions.FallbackToAny
                                ),
                            },
                })
                .ToList();
        }

        private IList<PosudekRoHarmonizovanyKodDetailDto>? ConvertHarmonizovaneKody(
            IEnumerable<PosudekRoHarmonizovanyKod> enumerable
        )
        {
            return enumerable
                ?.Select(s => new PosudekRoHarmonizovanyKodDetailDto
                {
                    UpresneniText = s.UpresneniText,
                    HarmonizovanyKod =
                        s.HarmonizovanyKod == null
                            ? null
                            : new CiselnikPolozkaWithTranslationsDto
                            {
                                CiselnikKod = s.HarmonizovanyKod.CiselnikKod,
                                CiselnikVerze = s.HarmonizovanyKod.CiselnikVerze,
                                PolozkaKod = s.HarmonizovanyKod.Kod,
                                Preklady = s.HarmonizovanyKod.Translations.ConvertTranslations(
                                    CultureInfo.CurrentCulture.Name,
                                    DefaultLocalizationOptions.DefaultCultureName,
                                    DefaultLocalizationOptions.FallbackToAny
                                ),
                            },
                })
                .ToList();
        }

        private IList<PosudekRoNarodniKodDetailDto>? ConvertNarodniKody(
            IEnumerable<PosudekRoNarodniKod> enumerable
        )
        {
            return enumerable
                ?.Select(s => new PosudekRoNarodniKodDetailDto
                {
                    UpresneniText = s.UpresneniText,
                    NarodniKod =
                        s.NarodniKod == null
                            ? null
                            : new CiselnikPolozkaWithTranslationsDto
                            {
                                CiselnikKod = s.NarodniKod.CiselnikKod,
                                CiselnikVerze = s.NarodniKod.CiselnikVerze,
                                PolozkaKod = s.NarodniKod.Kod,
                                Preklady = s.NarodniKod.Translations.ConvertTranslations(
                                    CultureInfo.CurrentCulture.Name,
                                    DefaultLocalizationOptions.DefaultCultureName,
                                    DefaultLocalizationOptions.FallbackToAny
                                ),
                            },
                    SkupinaRo =
                        s.SkupinaRo == null
                            ? null
                            : new CiselnikPolozkaWithTranslationsDto
                            {
                                CiselnikKod = s.SkupinaRo.CiselnikKod,
                                CiselnikVerze = s.SkupinaRo.CiselnikVerze,
                                PolozkaKod = s.SkupinaRo.Kod,
                                Preklady = s.SkupinaRo.Translations.ConvertTranslations(
                                    CultureInfo.CurrentCulture.Name,
                                    DefaultLocalizationOptions.DefaultCultureName,
                                    DefaultLocalizationOptions.FallbackToAny
                                ),
                            },
                })
                .ToList();
        }

        private string? GetOdbornostLekare(CiselnikPolozka? odbornost)
        {
            if (odbornost == null)
            {
                return null;
            }

            return odbornost.Translations.GetLocalizedValue(
                    "Nazev",
                    CultureInfo.CurrentCulture.Name,
                    DefaultLocalizationOptions.DefaultCultureName,
                    DefaultLocalizationOptions.FallbackToAny
                ) ?? odbornost.Kod;
        }
    }
}
