# PhoneNumbers

A library for parsing phone numbers.

Install via nuget `dotnet add package PhoneNumbers` _(not yet published)_

Add the namespace:

```csharp
using PhoneNumbers;
```

Parsing a phone number is achieved via the `PhoneNumber.Parse` method (or alternatively or `PhoneNumber.TryParse`), there are 2 overloads:

```csharp
// If the phone number string is in international format (e.g. +XX):
PhoneNumber phoneNumber = PhoneNumber.Parse("+441142726444");

// If the phone number string is not in international format:
// Specify the ISO 3166 Aplha-2 code for the country as the second parameter.
PhoneNumber phoneNumber = PhoneNumber.Parse("01142726444", "GB");
```

```csharp
// PhoneNumber properties:
phoneNumber.AreaCode;                           // 114
phoneNumber.Country;                            // the CountryInfo (see below)
phoneNumber.LocalNumber                         // 2726444
phoneNumber.PhoneNumberKind;                    // PhoneNumberKind.GeographicPhoneNumber

// CountryInfo properties
phoneNumber.Country.CallingCode;                // +44
phoneNumber.Country.CountryCode;                // GB
phoneNumber.Country.InternationalCallPrefix;    // 00
phoneNumber.Country.TrunkPrefix;                // 0

// PhoneNumberKind - can be used to determine the type of PhoneNumber to cast to
GeographicPhoneNumber,
MobilePhoneNumber,
NonGeographicPhoneNumber,

// GeographicPhoneNumber : PhoneNumber
var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
geographicPhoneNumber.GeographicArea;           // Sheffield
```

```csharp
phoneNumber.ToString();                         // +441142726444 (defaults to I format)
phoneNumber.ToString("D");                      // 0114 272 6444 (format for display)
phoneNumber.ToString("I");                      // +441142726444 (format for international caller)
phoneNumber.ToString("N");                      // 01142726444   (format for national caller)
```

## Country support

Currently supports parsing the following:

### United Kingdom

- Phone numbers in the UK are administered by Ofcom, this library uses the rules within the published telephone numbering plan.
- 01, 02, 03, 07 and 08 numbers are supported.
- 01 and 02 numbers are geographically assigned so the geographic area is included.
- Includes Guernsey, Jersey and Isle of Man which although separate countries share UK phone numbers and also use the +44 calling code.

_note the ISO code for the United Kingdom is 'GB' rather than 'UK'._
