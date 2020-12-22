# PhoneNumbers

A library for parsing phone numbers.

Install via nuget `dotnet add package PhoneNumbers`

Parsing a phone number is achieved via the `PhoneNumber.Parse` method, there are 2 overloads:

```csharp
// If the phone number string is in international format (e.g. +XX):
PhoneNumber phoneNumber = PhoneNumber.Parse("+441141234567");

// If the phone number string is not in international format:
// Specify the ISO 3166 Aplha-2 code for the country as the second parameter.
PhoneNumber phoneNumber = PhoneNumber.Parse("01141234567", "GB");
```

```csharp
// PhoneNumber properties:
phoneNumber.AreaCode;                           // 114
phoneNumber.Country;                            // the CountryInfo (see below)
phoneNumber.LocalNumber                         // 1234567
phoneNumber.PhoneNumberKind;                    // the PhoneNumberKind

// CountryInfo properties
phoneNumber.Country.CallingCode;                // +44
phoneNumber.Country.CountryCode;                // GB
phoneNumber.Country.InternationalCallPrefix;    // 00
phoneNumber.Country.TrunkPrefix;                // 0

// PhoneNumberKind - can be used to determine the type of PhoneNumber
GeographicPhoneNumber,
MobilePhoneNumber,
NonGeographicPhoneNumber,

// GeographicPhoneNumber : PhoneNumber
(GeographicPhoneNumber)phoneNumber;
geographicPhoneNumber.GeographicArea;           // Sheffield
```

```csharp
phoneNumber.ToString();                         // +441141234567 (defaults to I format)
phoneNumber.ToString("D");                      // 0114 123 4567 (format for display)
phoneNumber.ToString("I");                      // +441141234567 (format for international caller)
phoneNumber.ToString("N");                      // 01141234567   (format for national caller)
```

## Country support

Currently supports parsing the following:

### United Kingdom

- 01, 02, 03, 07 and 08 numbers are supported.
- 01 and 02 numbers are geographically assigned so the geographic area is included.
- Phone numbers in the UK are administered by Ofcom, this library uses the rules within the published telephone numbering plan.

_The UK support includes Guernsey, Jersey and Isle of Man which although separate countries share UK phone numbers and also use the +44 calling code._
