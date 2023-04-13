# Phone Number Parser

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/TrevorPilley/PhoneNumbers/blob/main/LICENSE) ![GitHub last commit](https://img.shields.io/github/last-commit/TrevorPilley/PhoneNumbers/main) ![Build Status](https://github.com/TrevorPilley/PhoneNumbers/workflows/CI/badge.svg?branch=main) [![NuGet](https://img.shields.io/nuget/v/PhoneNumberParser.svg)](https://www.nuget.org/packages/PhoneNumberParser/) ![GitHub Release Date](https://img.shields.io/github/release-date/TrevorPilley/PhoneNumbers) [![NuGet](https://img.shields.io/nuget/dt/PhoneNumberParser.svg)](https://www.nuget.org/packages/PhoneNumberParser/)

A library for parsing phone numbers, with builds for:

- .NET 7.0
- .NET Standard 2.1 - _supports .NET Core 3.0 or later and .NET 5.0 or later_
- .NET Standard 2.0 - _supports .NET Framework 4.6.2 or later (.NET Framework projects will need to be built with C# 9.0 or later)_

This library provides a number of benefits over a regular expression, for example greater validity of phone numbers including national destination codes (area codes) and subscriber numbers based upon published numbering plans for each country. Additional attributes such as the kind of phone number (Mobile, Geographic or Non-Geographic) are also included. All parsing is performed locally within the library using embedded in-memory data files.

The library **does not**:

- Provide certainty that a phone number is assigned and in use
- Include the original carrier for mobile phone numbers due to number portability in most countries
- Support extension numbers

The library also uses [nullable reference type](https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references) annotations.

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

Parsing a phone number is achieved via the `PhoneNumber.Parse` method (or alternatively via `PhoneNumber.TryParse`). Any spaces, hyphens or other formatting in the input string is ignored.

There are 2 overloads for Parse:

```csharp
// If the phone number string is in international format (e.g. +XX):
var phoneNumber = PhoneNumber.Parse("+441142726444");

// If the phone number string is not in international format:
// Specify the ISO 3166 Alpha-2 code for the country as the second parameter.
var phoneNumber = PhoneNumber.Parse("01142726444", "GB");
```

There are 3 overloads for TryParse:

```csharp
// If the phone number string is in international format (e.g. +XX):
PhoneNumber.TryParse("+442079813000", out PhoneNumber phoneNumber);

// If the phone number string is not in international format:
// Specify the ISO 3166 Alpha-2 code for the country as the second parameter.
PhoneNumber.TryParse("01142726444", "GB", out PhoneNumber phoneNumber);

// The phone number string is not in international format and the country code is not known:
PhoneNumber.TryParse("02079813000", out IEnumerable<PhoneNumber> phoneNumbers);
```

The resulting `PhoneNumber` has the following properties:

```csharp
// PhoneNumber properties:
phoneNumber.Country.CallingCode;                // 44
phoneNumber.Country.Continent;                  // Europe
phoneNumber.Country.HasNationalDestinationCodes // true
phoneNumber.Country.Iso3166Code;                // GB
phoneNumber.Country.Name;                       // United Kingdom
phoneNumber.Country.NumberingPlanType;          // NumberingPlanType.Open
phoneNumber.Country.SharesCallingCode           // true
phoneNumber.Country.TrunkPrefix;                // 0
phoneNumber.Kind;                               // PhoneNumberKind.GeographicPhoneNumber
phoneNumber.NationalDestinationCode;            // 114
phoneNumber.NationalSignificantNumber           // 1142726444
phoneNumber.SubscriberNumber;                   // 2726444

// There are 3 subclasses of PhoneNumber, the correct type to cast to
// can be determined by inspecting the phoneNumber.Kind property.

// if (phoneNumber.Kind == PhoneNumberKind.GeographicPhoneNumber)
var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
geographicPhoneNumber.GeographicArea;           // Sheffield

// if (phoneNumber.Kind == PhoneNumberKind.MobilePhoneNumber)
var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
mobilePhoneNumber.IsPager;                      // true/false
mobilePhoneNumber.IsVirtual;                    // true/false

// if (phoneNumber.Kind == PhoneNumberKind.NonGeographicPhoneNumber)
var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
nonGeographicPhoneNumber.IsFreephone;           // true/false
nonGeographicPhoneNumber.IsMachineToMachine;    // true/false
nonGeographicPhoneNumber.IsPremiumRate;         // true/false
nonGeographicPhoneNumber.IsSharedCost;          // true/false
```

The phone number can be formatted in the following ways, the default format output can be round tripped via `PhoneNumber.Parse()` to make serialization or database persistence straightforward.

```csharp
phoneNumber.ToString();                         // +441142726444       (defaults to E.164 format)
phoneNumber.ToString("E.164");                  // +441142726444       (E.164 format)
phoneNumber.ToString("E.123");                  // +44 114 272 6444    (E.123 international format)
phoneNumber.ToString("N");                      // (0114) 272 6444     (E.123 national notation format)
phoneNumber.ToString("RFC3966");                // tel:+44-114-272-644 (RFC3966 format)
```

### ParseOptions

The `ParseOptions` class can be used to control parsing, the defaults can be configured via:

```csharp
ParseOptions.Default
```

At present, the only options available are which countries are parsed.

By default all countries supported by the library can be parsed and any future supported ones will be automatically included.

#### Opt-in

To support parsing specific countries only, and ignore by default any new ones added in future versions of the library:

```csharp
ParseOptions.Default.Countries.Clear():
ParseOptions.Default.Countries.Add(CountryInfo.X);
```

To opt in to all countries supported by the library within a continent:

```csharp
ParseOptions.Default.Countries.Clear():

// One or more continent can be added.
ParseOptions.Default.AllowAfricanCountries();
ParseOptions.Default.AllowAsianCountries();
ParseOptions.Default.AllowEuropeanCountries();
ParseOptions.Default.AllowNorthAmericanCountries();
ParseOptions.Default.AllowOceanianCountries();
ParseOptions.Default.AllowSouthAmericanCountries();

// Alternatively all countries who are members of the same union.
ParseOptions.Default.AllowEuropeanUnionCountries();

// Alternatively all countries using the same numbering plan.
ParseOptions.Default.AllowNorthAmericanNumberingPlanCountries();
```

#### Opt-out

To out out of specific countries but still use any new ones added in future versions of the library:

```csharp
ParseOptions.Default.Countries.Remove(CountryInfo.X);
```

## Country support

The library currently supports parsing phone numbers for the following countries and although best endeavours are made to adhere to published telephone numbering plans, depending on the accessibility of data there may be discrepancies. If you happen to find any, please raise an issue.

### Africa

Country        | ISO 3166 Code | Calling Code | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone) | Non-Geographic<br/>(Premium Rate) | Non-Geographic<br/>(Shared Cost) | Non-Geographic (M2M)
---            | ---           | ---          | ---          | :-:        | :-:    | :-:                | :-:                  | :-:            | :-:                            | :-:                               | :-:                              | :-:
Egypt          | EG            | +20          | 0            | Yes        | Yes    |                    |                      |                | Yes                            | Yes                               |                                  |
Nigeria        | NG            | +234         | 0            | Yes        | Yes    |                    |                      |                |                                |                                   |                                  |
South Africa   | Za            | +27          | 0            | Yes        | Yes    |                    |                      | Yes            | Yes                            | Yes                               | Yes                              | Yes

### Asia

Country        | ISO 3166 Code | Calling Code | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone) | Non-Geographic<br/>(Premium Rate) | Non-Geographic<br/>(Shared Cost) | Non-Geographic (M2M)
---            | ---           | ---          | ---          | :-:        | :-:    | :-:                | :-:                  | :-:            | :-:                            | :-:                               | :-:                              | :-:
Hong Kong      | HK            | +852         |              |            | Yes    |                    | Yes                  | Yes            | Yes                            |                                   |                                  | Yes
Macau          | MO            | +853         |              |            | Yes    |                    |                      | Yes            |                                |                                   |                                  |
Singapore      | SG            | +65          |              |            | Yes    |                    |                      | Yes            | Yes                            | Yes                               |                                  |

### Europe

Country        | ISO 3166 Code | Calling Code | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Data Only) | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone) | Non-Geographic<br/>(Premium Rate) | Non-Geographic<br/>(Shared Cost) | Non-Geographic (M2M)
---            | ---           | ---          | ---          | :-:        | :-:    | :-:                    | :-:                | :-:                  | :-:            | :-:                            | :-:                               | :-:                              | :-:
Austria        | AT            | +43          | 0            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               |                                  |
Belarus        | BY            | +375         | 8            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               |                                  |
Belgium        | BE            | +32          | 0            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Bulgaria       | BG            | +359         | 0            | Yes        | Yes    |                        |                    | Yes                  | Yes            | Yes                            | Yes                               |                                  | Yes
Croatia        | HR            | +385         | 0            | Yes        | Yes    |                        |                    | Yes                  | Yes            | Yes                            | Yes                               |                                  | Yes
Czech Republic | CZ            | +420         |              | Yes        | Yes    |                        |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              |
Denmark        | DK            | +45          |              |            | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Estonia        | EE            | +372         |              |            | Yes    |                        |                    | Yes                  | Yes            | Yes                            | Yes                               |                                  | Yes
France         | FR            | +33          | 0            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Finland        | FI            | +358         | 0            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            |                                   |                                  | Yes
Germany        | DE            | +49          | 0            | Yes        | Yes    |                        | Yes                | Yes                  | Yes            | Yes                            | Yes                               |                                  | Yes
Gibraltar      | GI            | +350         |              | Yes        | Yes    |                        |                    |                      |                | Yes                            | Yes                               |                                  |
Greece         | GR            | +30          |              | Yes        | Yes    |                        |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              | Yes
Guernsey       | GG            | +44          | 0            | Yes        | Yes    |                        |                    |                      |                |                                |                                   |                                  |
Hungary        | HU            | +36          | 06           | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Ireland        | IE            | +353         | 0            | Yes        | Yes    |                        | Yes                | Yes                  | Yes            | Yes                            | Yes                               | Yes                              | Yes
Isle of Man    | IM            | +44          | 0            | Yes        | Yes    |                        |                    |                      |                |                                |                                   |                                  |
Italy          | IT            | +39          |              | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               | Yes                              |
Jersey         | JE            | +44          | 0            | Yes        | Yes    |                        |                    |                      |                |                                |                                   |                                  |
Kosovo         | XK            | +383         | 0            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               | Yes                              |
Moldova        | MD            | +373         | 0            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               | Yes                              |
Monaco         | MC            | +377         |              |            | Yes    |                        |                    |                      | Yes            |                                |                                   |                                  |
Netherlands    | NL            | +31          | 0            | Yes        | Yes    |                        | Yes                |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Norway         | NO            | +47          |              |            | Yes    |                        |                    |                      | Yes            |                                |                                   |                                  | Yes
Poland         | PL            | +48          |              | Yes        | Yes    |                        | Yes                |                      | Yes            |                                |                                   |                                  |
Portugal       | PT            | +351         |              | Yes        | Yes    |                        |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              |
Romania        | RO            | +40          | 0            | Yes        | Yes    |                        |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              |
San Marino     | SM            | +378         |              |            | Yes    |                        |                    |                      | Yes            |                                | Yes                               |                                  |
Serbia         | RS            | +381         | 0            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               |                                  | Yes
Spain          | ES            | +34          |              | Yes        | Yes    |                        |                    | Yes                  | Yes            | Yes                            | Yes                               | Yes                              | Yes
Slovakia       | SK            | +421         | 0            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               | Yes                              |
Sweden         | SE            | +46          | 0            | Yes        | Yes    | Yes                    | Yes                | Yes                  | Yes            | Yes                            | Yes                               | Yes                              | Yes
Switzerland    | CH            | +41          | 0            | Yes        | Yes    |                        |                    |                      | Yes            |                                | Yes                               |                                  |
Ukraine        | UA            | +380         | 0            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               |                                  |
United Kingdom | GB            | +44          | 0            | Yes        | Yes    | Yes                    | Yes                | Yes                  | Yes            | Yes                            | Yes                               |                                  |

### North America

Country                       | ISO 3166 Code | Calling Code | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Data Only) | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone) | Non-Geographic<br/>(Premium Rate) | Non-Geographic<br/>(Shared Cost) | Non-Geographic (M2M)
---                           | ---           | ---          | ---          | :-:        | :-:    | :-:                    | :-:                | :-:                  | :-:            | :-:                            | :-:                               | :-:                              | :-:
Canada                        | CA            | +1 _(NANP)_  |              | Yes        |        |                        |                    |                      | Yes            | Yes *                          | Yes                               |                                  |
Puerto Rico                   | PR            | +1 _(NANP)_  |              | Yes        |        |                        |                    |                      |                |                                |                                   |                                  |
United States                 | US            | +1 _(NANP)_  |              | Yes        |        |                        |                    | Yes *                | Yes            | Yes *                          | Yes                               |                                  |
United States Virgin Islands  | VI            | +1 _(NANP)_  |              | Yes        |        |                        |                    |                      |                |                                |                                   |                                  |

### Oceania

Country          | ISO 3166 Code | Calling Code | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Data Only) | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone) | Non-Geographic<br/>(Premium Rate) | Non-Geographic<br/>(Shared Cost) | Non-Geographic (M2M)
---              | ---           | ---          | ---          | :-:        | :-:    | :-:                    | :-:                | :-:                  | :-:            | :-:                            | :-:                               | :-:                              | :-:
American Samoa   | AS            | +1 _(NANP)_  |              | Yes        | Yes    |                        |                    |                      | Yes            |                                |                                   |                                  |
Australia        | AU            | +61          | 0            | Yes        | Yes    |                        | Yes                | Yes                  | Yes            | Yes                            | Yes                               |                                  |
Guam             | GU            | +1 _(NANP)_  |              | Yes        |        |                        |                    |                      |                |                                |                                   |                                  |
Papua New Guinea | PG            | +675         |              | Yes        | Yes    |                        | Yes                |                      | Yes            | Yes                            |                                   |                                  |

### South America

Country        | ISO 3166 Code | Calling Code | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Data Only) | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone) | Non-Geographic<br/>(Premium Rate) | Non-Geographic<br/>(Shared Cost) | Non-Geographic (M2M)
---            | ---           | ---          | ---          | :-:        | :-:    | :-:                    | :-:                | :-:                  | :-:            | :-:                            | :-:                               | :-:                              | :-:
Brazil         | BR            | +55          | 0            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                            | Yes                               |                                  |

### Notes

- The ISO code for the United Kingdom is 'GB' rather than 'UK'.
- Geographically assigned numbers in France are currently only resolved within the top level geographic zones (01 Île-de-France, 02 Nord-Ouest, 03 Nord-Est, 04 Sud-Est and 05 Sud-Ouest).
- Where possible, the geographic area name is in the language/locality of the country for the phone number (e.g. for an Italian phone number assigned to Florence, the geographic area will be set to `Firenze`.
- Within the North American Numbering Plan (covering all countries with the calling code +1):
  - Geographically assigned numbers are currently only resolved within the country or state/region level, not at city level.
  - Mobile numbers are geographically assigned and cannot be determined separately from landlines.
  - Freephone numbers (with a few exceptions) are issued from a shared pool. This could mean a Canadian freephone number look up shows as belonging to a different country if parsed from the E.164 format (parsing from the national number format and country code will work as expected).
  - Virtual (aka personal numbers) are issued from a shared pool and always show as belonging to the United States.
  - Phone numbers using the alphabetic mnemonic system/alphabetic phone-words (e.g. 123-PHONEME) are not supported.
