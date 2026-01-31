# Phone Number Parser

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/TrevorPilley/phone-number-parser/blob/main/LICENSE) [![NuGet](https://img.shields.io/nuget/v/PhoneNumberParser.svg)](https://www.nuget.org/packages/PhoneNumberParser/) [![Semantic Versioning](https://img.shields.io/badge/semver-2.0.0-3D9FE0.svg)](https://semver.org/) ![GitHub Release Date](https://img.shields.io/github/release-date/TrevorPilley/phone-number-parser) [![NuGet](https://img.shields.io/nuget/dt/PhoneNumberParser.svg)](https://www.nuget.org/packages/PhoneNumberParser/)

![Build Status](https://github.com/TrevorPilley/phone-number-parser/actions/workflows/CI.yml/badge.svg?branch=main) ![GitHub last commit](https://img.shields.io/github/last-commit/TrevorPilley/phone-number-parser/main) [![codecov](https://codecov.io/gh/TrevorPilley/phone-number-parser/branch/main/graph/badge.svg?token=653YHSMOQL)](https://codecov.io/gh/TrevorPilley/phone-number-parser)

A library for parsing phone numbers, providing validity of phone numbers including national destination codes (aka area codes) and subscriber numbers (aka line numbers) based upon published numbering plans for each country. Additional attributes such as the kind of phone number (Mobile, Geographic or Non-Geographic) are also included, and all parsing is performed locally within the library using embedded in-memory data files.

## Limitations

The library **does not**:

- Yet support all countries (additional countries are added incrementally through future releases).
- Provide certainty that a phone number is assigned and in use.
- Include the original carrier for mobile phone numbers due to number portability in most countries.
- Support extension numbers, although they are ignored if specified when parsing a value in RFC3966 format `tel:+44-114-272-644;ext=1234` or the older German style `0234/123456-10` format.
- Support alphabetic mnemonic system/alphabetic phone-words (e.g. 123-PHONEME).

## Install

Install via nuget:

```bash
dotnet add package PhoneNumberParser
```

Add the namespace:

```csharp
using PhoneNumbers;
```

## Parsing

Parsing a phone number is achieved via the `PhoneNumber.Parse` method (or alternatively via `PhoneNumber.TryParse`). Any formatting (e.g. spaces or hyphens) in the input string is ignored.

There are 3 overloads for Parse:

```csharp
// If the phone number string is in international format (e.g. +XXXXXXXXXXXX):
var phoneNumber = PhoneNumber.Parse("+441142726444");

// If the phone number string is not in international format,
// specify the typed CountryInfo instance as the second parameter:
var phoneNumber = PhoneNumber.Parse("01142726444", CountryInfo.UnitedKingdom);

// Alternatively the ISO 3166 Alpha-2 code for the country:
var phoneNumber = PhoneNumber.Parse("01142726444", "GB");
```

There are 4 overloads for TryParse:

```csharp
// If the phone number string is in international format (e.g. +XXXXXXXXXXXX):
PhoneNumber.TryParse("+442079813000", out PhoneNumber phoneNumber);

// If the phone number string is not in international format,
// specify the typed CountryInfo instance for the country as the second parameter:
PhoneNumber.TryParse("01142726444", CountryInfo.UnitedKingdom, out PhoneNumber phoneNumber);

// Alternatively the ISO 3166 Alpha-2 code:
PhoneNumber.TryParse("01142726444", "GB", out PhoneNumber phoneNumber);

// If the phone number string is not in international format and the country code is not known,
// any possible matches can be determined via:
PhoneNumber.TryParse("02079813000", out IEnumerable<PhoneNumber> phoneNumbers);
```

The resulting `PhoneNumber` has the following properties:

```csharp
// PhoneNumber properties:
phoneNumber.Country.AllowsLocalGeographicDialling; // true
phoneNumber.Country.CallingCode;                   // 44
phoneNumber.Country.Continent;                     // Europe
phoneNumber.Country.FullName;                      // United Kingdom of Great Britain and Northern Ireland
phoneNumber.Country.HasNationalDestinationCodes;   // true
phoneNumber.Country.HasTrunkPrefix;                // true
phoneNumber.Country.InternationalCallPrefix;       // 00
phoneNumber.Country.IsArabLeagueMember;            // false
phoneNumber.Country.IsEuropeanUnionMember;         // false
phoneNumber.Country.IsNatoMember;                  // true
phoneNumber.Country.IsOecdMember;                  // true
phoneNumber.Country.Iso3166Code;                   // GB
phoneNumber.Country.Name;                          // United Kingdom
phoneNumber.Country.SharesCallingCode;             // true
phoneNumber.Country.TrunkPrefix;                   // 0
phoneNumber.Kind;                                  // PhoneNumberKind.GeographicPhoneNumber
phoneNumber.NationalDestinationCode;               // 114
phoneNumber.NationalSignificantNumber;             // 1142726444
phoneNumber.SubscriberNumber;                      // 2726444

// There are 3 subclasses of PhoneNumber, the correct type to cast to
// can be determined by inspecting the phoneNumber.Kind property.

// if (phoneNumber.Kind == PhoneNumberKind.GeographicPhoneNumber)
var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
geographicPhoneNumber.GeographicArea;              // Sheffield

// if (phoneNumber.Kind == PhoneNumberKind.MobilePhoneNumber)
var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
mobilePhoneNumber.IsPager;                         // true/false
mobilePhoneNumber.IsVirtual;                       // true/false

// if (phoneNumber.Kind == PhoneNumberKind.NonGeographicPhoneNumber)
var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
nonGeographicPhoneNumber.IsFreephone;              // true/false
nonGeographicPhoneNumber.IsMachineToMachine;       // true/false
nonGeographicPhoneNumber.IsPremiumRate;            // true/false
nonGeographicPhoneNumber.IsSharedCost;             // true/false
```

The phone number can be formatted in the following ways, the default format output can be round tripped via `PhoneNumber.Parse()` to easily support persistence and serialization use cases.

```csharp
phoneNumber.ToString();          // +441142726444       (defaults to E.164 format)
phoneNumber.ToString("E.164");   // +441142726444       (E.164 format)
phoneNumber.ToString("E.123");   // +44 114 272 6444    (E.123 international format)
phoneNumber.ToString("N");       // (0114) 272 6444     (E.123 national notation format)
phoneNumber.ToString("RFC3966"); // tel:+44-114-272-644 (RFC3966 format)
phoneNumber.ToString("U");       // 01142726444         (the unformatted national notation)
```

### ParseOptions

The `ParseOptions` class can be used to control parsing, the defaults can be configured via:

```csharp
ParseOptions.Default
```

At present, the only options available are which countries are parsed.

By default all countries supported by the library can be parsed and any future supported countries will be automatically included.

A `ParseOptions` instance may also be passed as a parameter to the `Parse` and `TryParse` methods, however this is only necessary to supply alternative options to the default ones.

#### Opt-in

To support parsing specific countries only, and ignore by default any new ones added in future versions of the library:

```csharp
ParseOptions.Default.Countries.Clear():
ParseOptions.Default.Countries.Add(CountryInfo.X); // repeat per country
```

Alternatively there are additional country sets which can be allowed (any combination may be used):

```csharp
// Add all countries supported by the library by continent:
ParseOptions.Default.AllowAfricanCountries();
ParseOptions.Default.AllowAsianCountries();
ParseOptions.Default.AllowEuropeanCountries();
ParseOptions.Default.AllowNorthAmericanCountries();
ParseOptions.Default.AllowOceanianCountries();
ParseOptions.Default.AllowSouthAmericanCountries();

// Add all countries supported by the library who are members of the same union/alliance:
ParseOptions.Default.AllowArabLeagueCountries();    // 7 of 22 members
ParseOptions.Default.AllowEuropeanUnionCountries(); // all 27 member states + 6 territories with special status
ParseOptions.Default.AllowNatoCountries();          // 31 of 32 members (Albania not supported yet)
ParseOptions.Default.AllowOecdCountries();          // 32 of 38 members

// Add all countries supported by the library using the same numbering plan:
ParseOptions.Default.AllowFinlandNumberingPlanCountries(); // Finland and Åland Islands
ParseOptions.Default.AllowNorthAmericanNumberingPlanCountries(); // all 25 countries
ParseOptions.Default.AllowUnitedKingdomNumberingPlanCountries(); // Countries.Add(CountryInfo.UnitedKingdom) doesn't include Guernsey, Isle of Man and Jersey which also use the same numbering plan.
```

#### Opt-out

To opt out of specific countries but still use any new ones added in future versions of the library:

```csharp
ParseOptions.Default.Countries.Remove(CountryInfo.X);
```

## Dial helper

The library contains helper methods to determine the number that needs to be dialled for a call between two phone numbers.

```csharp
var callerNumber = PhoneNumber.Parse("+441142726444");

PhoneNumber.Parse("+441146548866").NumberToDialFrom(callerNumber); // 6548866 UK local dialling within same NDC
PhoneNumber.Parse("+447106865391").NumberToDialFrom(callerNumber); // 07106865391 UK mobile from UK landline
PhoneNumber.Parse("+33140477283").NumberToDialFrom(callerNumber);  // 0033140477283 French mobile from UK landline

// Alternatively a destination number from a specific country
PhoneNumber.Parse("+441146548866").NumberToDialFrom(CountryInfo.UnitedKingdom); // 01146548866 UK landline from UK
PhoneNumber.Parse("+447106865391").NumberToDialFrom(CountryInfo.UnitedKingdom); // 07106865391 UK mobile from UK
PhoneNumber.Parse("+33140477283").NumberToDialFrom(CountryInfo.UnitedKingdom);  // 0033140477283 French mobile from UK
```

## Versioning

The library adheres to [Semantic Versioning](https://semver.org) and [release notes](https://github.com/TrevorPilley/phone-number-parser/releases) are provided for every published version.

Specific builds are included in the nuget package for:

- .NET 10.0, 9.0 and 8.0
- .NET Standard 2.1 - _supports .NET Core 3.0 or newer, .NET 5.0 or newer and Mono 6.4 or newer_
- .NET Standard 2.0 - _supports .NET Core 2.0 or newer, Mono 5.4 or newer and .NET Framework 4.6.2 or newer (however consuming projects will need to be built with a minimum C# language version of 9.0 due to use of init only properties within the phone number parser library)_

All versions of .NET which are still within their Microsoft support lifecycle will be supported by this library (excluding public betas), other versions of .NET, .NET Framework and .NET compatible runtimes (Mono, Xamarin, Unity etc.) will retain support via the .NET Standard builds.

## Country support

The library currently supports parsing phone numbers for the following countries and although best endeavours are made to adhere to published telephone numbering plans, depending on the accessibility of data there may be discrepancies. If you happen to find any, please raise an issue.

### Africa

Country        | ISO 3166 Code | Calling Code | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone) | Non-Geographic<br/>(Premium Rate) | Non-Geographic<br/>(Shared Cost) | Non-Geographic (M2M)
---            | ---           | ---          | ---          | :-:        | :-:    | :-:                | :-:                  | :-:            | :-:                            | :-:                               | :-:                              | :-:
Egypt          | EG            | 20           | 0            | Yes        | Yes    |                    |                      |                | Yes                            | Yes                               |                                  |
Kenya          | KE            | 254          | 0            | Yes        | Yes    |                    |                      |                |                                |                                   |                                  | Yes
Mayotte        | YT            | 262 _(Réunion)_         | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Nigeria        | NG            | 234          | 0            | Yes        | Yes    |                    | Yes                  |                | Yes                            |                                   |                                  |
Réunion        | RE            | 262          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
South Africa   | ZA            | 27           | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               | Yes                              | Yes
Tanzania       | TZ            | 255          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               | Yes                              | Yes
Uganda         | UG            | 256          | 0            |            | Yes    |                    |                      | Yes            | Yes                            |                                   |                                  |

### Asia

Country              | ISO 3166 Code | Calling Code | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone) | Non-Geographic<br/>(Premium Rate) | Non-Geographic<br/>(Shared Cost) | Non-Geographic (M2M)
---                  | ---           | ---          | ---          | :-:        | :-:    | :-:                | :-:                  | :-:            | :-:                            | :-:                               | :-:                              | :-:
Hong Kong            | HK            | 852          |              |            | Yes    |                    | Yes                  | Yes            | Yes                            |                                   |                                  | Yes
Jordan               | JO            | 962          | 0            | Yes        | Yes    | Yes                | Yes                  | Yes            |                                | Yes                               | Yes                              |
Macao                | MO            | 853          |              |            | Yes    |                    |                      | Yes            |                                |                                   |                                  |
Oman                 | OM            | 968          |              | Yes        | Yes    |                    |                      | Yes            |                                |                                   |                                  |
Qatar                | QA            | 974          |              |            | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Saudi Arabia         | SA            | 966          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               | Yes                              | Yes
Singapore            | SG            | 65           |              |            | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  |
Türkiye              | TR            | 90           | 0            | Yes        | Yes    |                    | Yes                  | Yes            | Yes                            | Yes                               |                                  |
United Arab Emirates | AE            | 971          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               | Yes                              |
Yemen                | YE            | 967          | 0            | Yes        | Yes    |                    |                      |                |                                |                                   |                                  |

### Europe

Country        | ISO 3166 Code | Calling Code | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone) | Non-Geographic<br/>(Premium Rate) | Non-Geographic<br/>(Shared Cost) | Non-Geographic (M2M)
---            | ---           | ---          | ---          | :-:        | :-:    | :-:                | :-:                  | :-:            | :-:                            | :-:                               | :-:                              | :-:
Åland Islands  | AX            | 358 _(Finland)_        | 0            | Yes        | Yes    |                    |                      |                |                                |                                   |                                  |
Andorra        | AD            | 376          |              |            | Yes    |                    |                      | Yes            | Yes                            |                                   |                                  |
Austria        | AT            | 43           | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  |
Belarus        | BY            | 375          | 8            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  |
Belgium        | BE            | 32           | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Bosnia and Herzegovina | BA            | 387          | 0            | Yes        | Yes    |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              | Yes
Bulgaria       | BG            | 359          | 0            | Yes        | Yes    |                    | Yes                  | Yes            | Yes                            | Yes                               |                                  | Yes
Croatia        | HR            | 385          | 0            | Yes        | Yes    |                    | Yes                  | Yes            | Yes                            | Yes                               |                                  | Yes
Cyprus         | CY            | 387          |              | Yes        | Yes    |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              | Yes
Czechia        | CZ            | 420          |              | Yes        | Yes    |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              |
Denmark        | DK            | 45           |              |            | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Estonia        | EE            | 372          |              |            | Yes    |                    | Yes                  | Yes            | Yes                            | Yes                               |                                  | Yes
Faroe Islands  | FO            | 298          |              |            | Yes    |                    |                      | Yes            | Yes                            | Yes                               | Yes                              |
Finland        | FI            | 358          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            |                                   |                                  | Yes
France         | FR            | 33           | 0            |            | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Germany        | DE            | 49           | 0            | Yes        | Yes    | Yes                | Yes                  | Yes            | Yes                            | Yes                               |                                  | Yes
Gibraltar      | GI            | 350          |              | Yes        | Yes    |                    |                      |                | Yes                            | Yes                               | Yes                              |
Greece         | GR            | 30           |              | Yes        | Yes    |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              | Yes
Guernsey       | GG            | 44 _(UK)_    | 0            | Yes        | Yes    |                    |                      |                |                                |                                   |                                  |
Hungary        | HU            | 36           | 06           | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Iceland        | IS            | 354          |              | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Ireland        | IE            | 353          | 0            | Yes        | Yes    |                    |                      | Yes            |                                | Yes                               |                                  | Yes
Isle of Man    | IM            | 44 _(UK)_    | 0            | Yes        | Yes    |                    |                      |                |                                |                                   |                                  |
Italy          | IT            | 39           |              | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               | Yes                              |
Jersey         | JE            | 44 _(UK)_    | 0            | Yes        | Yes    |                    |                      |                |                                |                                   |                                  |
Kosovo         | XK            | 383          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               | Yes                              |
Latvia         | LV            | 371          |              | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  |
Liechtenstein  | LI            | 423          |              |            | Yes    |                    |                      | Yes            | Yes                            |                                   | Yes                              |
Lithuania      | LT            | 370          | 8            | Yes        | Yes    |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              | Yes
Luxembourg     | LU            | 352          |              |            | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Malta          | MT            | 356          |              | Yes        | Yes    | Yes                |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Moldova        | MD            | 373          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               | Yes                              |
Monaco         | MC            | 377          |              |            | Yes    |                    |                      | Yes            |                                |                                   |                                  | Yes
Montenegro     | ME            | 382          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               | Yes                              | Yes
Netherlands    | NL            | 31           | 0            | Yes        | Yes    | Yes                |                      | Yes            | Yes                            | Yes                               |                                  | Yes
North Macedonia    | MK            | 389           | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               | Yes                              |
Norway         | NO            | 47           |              |            | Yes    |                    |                      | Yes            |                                |                                   |                                  | Yes
Poland         | PL            | 48           |              | Yes        | Yes    | Yes                |                      | Yes            |                                |                                   |                                  |
Portugal       | PT            | 351          |              | Yes        | Yes    |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              |
Romania        | RO            | 40           | 0            | Yes        | Yes    |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              |
San Marino     | SM            | 378          |              |            | Yes    |                    |                      | Yes            |                                | Yes                               |                                  |
Serbia         | RS            | 381          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Slovakia       | SK            | 421          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               | Yes                              |
Slovenia       | SI            | 386          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Spain          | ES            | 34           |              | Yes        | Yes    |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              | Yes
Sweden         | SE            | 46           | 0            | Yes        | Yes    | Yes                | Yes                  | Yes            | Yes                            | Yes                               | Yes                              | Yes
Switzerland    | CH            | 41           | 0            | Yes        | Yes    |                    |                      | Yes            |                                | Yes                               | Yes                              |
Ukraine        | UA            | 380          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  |
United Kingdom | GB            | 44           | 0            | Yes        | Yes    | Yes                | Yes                  | Yes            | Yes                            | Yes                               |                                  |

### North America

Country                          | ISO 3166 Code | Calling Code           | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone) | Non-Geographic<br/>(Premium Rate) | Non-Geographic<br/>(Shared Cost) | Non-Geographic (M2M)
---                              | ---           | ---                    | ---          | :-:        | :-:    | :-:                | :-:                  | :-:            | :-:                            | :-:                               | :-:                              | :-:
Anguilla                         | AI            | 1 264 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Antigua and Barbuda              | AG            | 1 268 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Barbados                         | BB            | 1 246 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Bermuda                          | BM            | 1 441 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Bahamas                          | BS            | 1 242 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
British Virgin Islands           | VG            | 1 284 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Canada                           | CA            | 1 (NANP)_              |              | Yes        |        |                    |                      | Yes            | Yes                            | Yes                               |                                  |
Cayman Islands                   | KY            | 1 345 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Dominica                         | DM            | 1 767 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Dominican Republic               | DM            | 1 809 / 829 / 849 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Guadeloupe                       | GP            | 590                    | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Greenland                        | GL            | 299                    |              | Yes        | Yes    |                    |                      | Yes            |                                |                                   |                                  |
Grenada                          | GD            | 1 473 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Jamaica                          | JM            | 1 658 / 876 _(NANP)_   |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Martinique                       | MQ            | 596                    | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Mexico                           | MX            | 52                     |              | Yes *      |        |                    |                      | Yes            | Yes                            | Yes                               |                                  |
Montserrat                       | MS            | 1 664 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Northern Mariana Islands         | MP            | 1 670 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Puerto Rico                      | PR            | 1 787 / 939 _(NANP)_   |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Saint Kitts and Nevis            | KN            | 1 869 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Saint Lucia                      | LC            | 1 758 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Saint Vincent and the Grenadines | VC            | 1 784 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Sint Maarten                     | SX            | 1 721 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Trinidad and Tobago              | TT            | 1 868 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Turks and Caicos Islands         | TC            | 1 649 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
United States                    | US            | 1 _(NANP)_             |              | Yes *      |        |                    | Yes *                | Yes            | Yes *                          | Yes                               |                                  |
United States Virgin Islands     | VI            | 1 340 _(NANP)_         |              |            |        |                    |                      | Yes            |                                |                                   |                                  |

### Oceania

Country          | ISO 3166 Code | Calling Code   | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone) | Non-Geographic<br/>(Premium Rate) | Non-Geographic<br/>(Shared Cost) | Non-Geographic (M2M)
---              | ---           | ---            | ---          | :-:        | :-:    | :-:                | :-:                  | :-:            | :-:                            | :-:                               | :-:                              | :-:
American Samoa   | AS            | 1 684 _(NANP)_ |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Australia        | AU            | 61             | 0            | Yes        | Yes    | Yes                | Yes                  | Yes            | Yes                            | Yes                               |                                  |
Guam             | GU            | 1 671 _(NANP)_ |              |            |        |                    |                      | Yes            |                                |                                   |                                  |
Papua New Guinea | PG            | 675            |              | Yes        | Yes    | Yes                |                      | Yes            | Yes                            |                                   |                                  |

### South America

Country          | ISO 3166 Code | Calling Code | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone) | Non-Geographic<br/>(Premium Rate) | Non-Geographic<br/>(Shared Cost) | Non-Geographic (M2M)
---              | ---           | ---          | ---          | :-:        | :-:    | :-:                | :-:                  | :-:            | :-:                            | :-:                               | :-:                              | :-:
Brazil           | BR            | 55           | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  |
Colombia         | CO            | 57           |              | Yes        | Yes    |                    |                      |                |                                |                                   |                                  |
Falkland Islands | FK            | 500          |              |            | Yes    |                    |                      | Yes            |                                |                                   |                                  |
French Guiana    | GF            | 594          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Peru             | PE            | 51           | 0            | Yes        | Yes    |                    |                      |                |                                |                                   |                                  |

### Notes

- Where possible, the geographic area name is in the language/locality of the country for the phone number (e.g. for an Italian phone number assigned to Florence, the geographic area will be set to `Firenze`).
- For the United Kingdom:
  - The ISO code is 'GB' rather than 'UK'.
  - Covers England, Scotland, Wales and Northern Ireland.
  - The Crown Dependencies Guernsey, Isle of Man and Jersey also use the same numbering plan but are separate countries.
  - To avoid a legitimate UK phone number from being rejected by the library, consider using `ParseOptions.Default.AllowUnitedKingdomNumberingPlanCountries()` if you are customising the countries used instead of `ParseOptions.Countries.Add(CountryInfo.UnitedKingdom)`.
- Within the North American Numbering Plan (NANP), which covers all countries with the calling code `1`:
  - Geographically assigned numbers are only resolved within the country or state/region level.
  - Mobile numbers are geographically assigned and cannot be determined separately from landlines.
  - Freephone numbers (with a few exceptions) are issued from a shared pool. This could mean a Canadian freephone number look up shows as belonging to a different country if parsed from the E.164 format (parsing from the national number format and country code will work as expected).
  - Virtual (aka personal numbers) are issued from a shared pool and always show as belonging to the United States.
- Landline numbers can be ported in some countries and therefore although originally geographically assigned, they may no longer match the specified geographic area (Countries affected - Iceland)
- Within Mexico:
  - Geographically assigned numbers are only resolved within the eight principal regions of the country.
  - Mobile numbers are geographically assigned and cannot be determined separately from landlines.
