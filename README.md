# PhoneNumbers

A library for parsing phone numbers.

Install via nuget `dotnet add package PhoneNumberParser`

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
phoneNumber.Country.CallingCode;                // +44
phoneNumber.Country.InternationalCallPrefix;    // 00
phoneNumber.Country.Iso3116Code;                // GB
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

The library currently supports parsing the following countries:

### United Kingdom

- 01, 02, 03, 07 and 08 numbers are supported.
- 01 and 02 numbers are geographically assigned so the geographic area is included.
- Sets the `IsDataOnly`, `IsPager` or `IsVirtual` properties as appropriate for mobile phone numbers.
- Sets the `IsFreephone` property for non-geographical phone numbers which are freephone numbers (e.g. 0800 and 0808).
- Best endeavours are made to adhere to allocated number ranges within geographic areas or mobile ranges however the range permitted within the library may exceed those allocated within the published Ofcom telephone numbering plan.
- The UK parsing also includes Guernsey, Jersey and Isle of Man which although separate countries share UK phone numbers and also use the +44 calling code.

_note the ISO code for the United Kingdom is 'GB' rather than 'UK'._
