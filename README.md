# PhoneNumbers

A library for parsing phone numbers targetting .NET 5.0, .NET Standard 2.1 and .NET Standard 2.0 with [nullable reference type](https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references) annotations.

![GitHub last commit](https://img.shields.io/github/last-commit/TrevorPilley/PhoneNumbers/main) ![Build Status](https://github.com/TrevorPilley/PhoneNumbers/workflows/CI/badge.svg?branch=main) ![CodeQL](https://github.com/TrevorPilley/PhoneNumbers/workflows/CodeQL/badge.svg) ![GitHub Release Date](https://img.shields.io/github/release-date/TrevorPilley/PhoneNumbers) ![Nuget](https://img.shields.io/nuget/dt/PhoneNumberParser) ![Nuget](https://img.shields.io/nuget/v/PhoneNumberParser)

Install via nuget

```bash
dotnet add package PhoneNumberParser
```

Add the namespace:

```csharp
using PhoneNumbers;
```

Parsing a phone number is achieved via the `PhoneNumber.Parse` method (or alternatively or `PhoneNumber.TryParse`). Any spaces, hyphens or other formatting in the input string is ignored.

There are 2 overloads:

```csharp
// If the phone number string is in international format (e.g. +XX):
PhoneNumber phoneNumber = PhoneNumber.Parse("+441142726444");

// If the phone number string is not in international format:
// Specify the ISO 3166 Aplha-2 code for the country as the second parameter.
PhoneNumber phoneNumber = PhoneNumber.Parse("01142726444", "GB");
```

The resulting `PhoneNumber` has the following properties:

```csharp
// PhoneNumber properties:
phoneNumber.AreaCode;                           // 114
phoneNumber.Country.CallingCode;                // +44
phoneNumber.Country.InternationalCallPrefix;    // 00
phoneNumber.Country.Iso3166Code;                // GB
phoneNumber.Country.TrunkPrefix;                // 0
phoneNumber.LocalNumber                         // 2726444
phoneNumber.PhoneNumberKind;                    // PhoneNumberKind.GeographicPhoneNumber

// PhoneNumberKind - can be used to determine the type of PhoneNumber to cast to
GeographicPhoneNumber,
MobilePhoneNumber,
NonGeographicPhoneNumber,

// If PhoneNumberKind.GeographicPhoneNumber
var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
geographicPhoneNumber.GeographicArea;           // Sheffield

// If PhoneNumberKind.MobilePhoneNumber
var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
mobilePhoneNumber.IsDataOnly;                   // true/false
mobilePhoneNumber.IsPager;                      // true/false
mobilePhoneNumber.IsVirtual;                    // true/false

// If PhoneNumberKind.NonGeographicPhoneNumber
var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
nonGeographicPhoneNumber.IsFreephone;           // true/false
```

The phone number can be formatted in 3 ways, the default format output can be round tripped via `PhoneNumber.Parse()` to make serialization or database persistence straightforward.

```csharp
phoneNumber.ToString();                         // +441142726444 (defaults to I format)
phoneNumber.ToString("D");                      // 0114 272 6444 (format for display)
phoneNumber.ToString("I");                      // +441142726444 (format for international caller)
phoneNumber.ToString("N");                      // 01142726444   (format for national caller)
```

## Country support

The library currently supports parsing phone numbers for the following countries and although best endeavours are made to adhere to published telephone numbering plans, depending on the accessibility of data there may be descepencies. If you happen to find any, please raise a bug.

Country | Calling Code | ISO 3166 Code | Geographic | Mobile | Non-Geographic
--- | --- | --- | --- | --- | ---
France | +33 | FR | Yes | Yes * | Yes
Ireland | +353 | IE | Yes | Yes * | Yes
Italy | +39 | IT | Yes | Yes * | Yes
United Kingdom | +44 | GB | Yes | Yes | Yes

### France

- 01, 02, 03, 04, 05, 06, 07, 08 and 09 numbers are supported.
- 01, 02, 03, 04 are 05 numbers are geographically assigned so the geographic area is included.
- The `IsDataOnly`, `IsPager` and `IsVirtual` properties are not currently set for France mobile numbers.
- Sets the `IsFreephone` property for non-geographical phone numbers which are freephone numbers (e.g. 0800-0805 numbers).

### Ireland

- 01, 02, 04, 05, 06, 07, 08 and 09 numbers are supported.
- 01, 02, 04, 05, 06, 07 (except 0700) and 09 numbers are geographically assigned so the geographic area is included.
- Sets the `IsPager` and `IsVirtual` properties as appropriate for mobile phone numbers.
- The `IsDataOnly` property is not currently set for Ireland mobile numbers.
- Sets the `IsFreephone` property for non-geographical phone numbers which are freephone numbers (e.g. 0800).

### Italy

- 0, 3 and 8 numbers are supported
- 0 numbers are geographically assigned so the geographic area is included.
- The `IsDataOnly`, `IsPager` and `IsVirtual` properties are not currently set for Italy mobile numbers.
- Sets the `IsFreephone` property for non-geographical phone numbers which are freephone numbers (e.g. 800 and 803).

### United Kingdom

_note the ISO code for the United Kingdom is 'GB' rather than 'UK'._

- 01, 02, 03, 07 and 08 numbers are supported.
- 01 and 02 numbers are geographically assigned so the geographic area is included.
- Sets the `IsDataOnly`, `IsPager` or `IsVirtual` properties as appropriate for mobile phone numbers.
- Sets the `IsFreephone` property for non-geographical phone numbers which are freephone numbers (e.g. 0800 and 0808).
- The UK parsing also includes Guernsey, Jersey and the Isle of Man, which although separate countries, all use the +44 calling code and share UK phone number ranges and area codes.

## References for number data

These were used as the references for the phone number data for each country.

### France

- https://www.itu.int/dms_pub/itu-t/oth/02/02/T020200004A0002PDFE.pdf
- https://fr.wikipedia.org/wiki/Liste_des_indicatifs_téléphoniques_en_France
- https://en.wikipedia.org/wiki/Telephone_numbers_in_France

### Ireland

- https://www.comreg.ie/industry/licensing/numbering/area-code-maps-2/
- https://www.comreg.ie/csv/downloads/ComReg0804.pdf
- https://www.itu.int/dms_pub/itu-t/oth/02/02/T02020000680001PDFE.pdf
- https://en.wikipedia.org/wiki/Telephone_numbers_in_the_Republic_of_Ireland

### Italy

- https://www.itu.int/dms_pub/itu-t/oth/02/02/T020200006B0001PDFE.pdf
- https://en.wikipedia.org/wiki/Telephone_numbers_in_Italy

### United Kingdom

- https://www.area-codes.org.uk/
- https://www.itu.int/dms_pub/itu-t/oth/02/02/T02020000DD0001PDFE.pdf
- http://static.ofcom.org.uk/static/numbering/index.htm
- https://www.ofcom.org.uk/__data/assets/pdf_file/0013/102613/national-numbering-plan.pdf
- https://en.wikipedia.org/wiki/Telephone_numbers_in_the_United_Kingdom
