# Phone Number Parser

A library for parsing phone numbers, providing validity of phone numbers including national destination codes (aka area codes) and subscriber numbers (aka line numbers) based upon published numbering plans for each country. Additional attributes such as the kind of phone number (Mobile, Geographic or Non-Geographic) are also included, and all parsing is performed locally within the library using embedded in-memory data files.

```csharp
using PhoneNumbers;

// Parsing a phone number is achieved via the `PhoneNumber.Parse` method (or alternatively via `PhoneNumber.TryParse`). Any formatting (e.g. spaces or hyphens) in the input string is ignored.
var phoneNumber = PhoneNumber.Parse("+441142726444"); // or Parse("01142726444", CountryInfo.UnitedKingdom) or Parse("01142726444", "GB")

phoneNumber.NationalDestinationCode;     // 114     (aka area code)
phoneNumber.SubscriberNumber;            // 2726444 (aka line number)

// Country specific information is accessible via the Country property, for example:
phoneNumber.Country.CallingCode;         // 44
phoneNumber.Country.Iso3166Code;         // GB
phoneNumber.Country.Name;                // United Kingdom
phoneNumber.Country.TrunkPrefix;         // 0

// There are 3 subclasses of PhoneNumber, the correct type to cast to can be determined by inspecting the phoneNumber.Kind property. Cast as appropriate to access additional properties.
var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
geographicPhoneNumber.GeographicArea;    // Sheffield

// The phone number can be formatted in the following ways, the default format output can be round tripped via `PhoneNumber.Parse()` to easily support persistence and serialization use cases.
phoneNumber.ToString();                  // +441142726444       (defaults to E.164 format)
phoneNumber.ToString("E.164");           // +441142726444       (E.164 format)
phoneNumber.ToString("E.123");           // +44 114 272 6444    (E.123 international format)
phoneNumber.ToString("N");               // (0114) 272 6444     (E.123 national notation format)
phoneNumber.ToString("RFC3966");         // tel:+44-114-272-644 (RFC3966 format)
phoneNumber.ToString("U");               // 01142726444         (the unformatted national notation)

// The dial helper extension provides the appropriate number for a caller to dial, either based upon their country:
phoneNumber.NumberToDialFrom(CountryInfo.France);   // 00441142726444
phoneNumber.NumberToDialFrom(CountryInfo.HongKong); // 001441142726444
phoneNumber.NumberToDialFrom(CountryInfo.Nigeria);  // 009441142726444

// or their own phone number:
phoneNumber.NumberToDialFrom(PhoneNumber.Parse("+33140477283")); // 00441142726444
```

Builds for:

- .NET 10.0, 9.0 and 8.0
- .NET Standard 2.1 - _supports .NET Core 3.0 or newer and .NET 5.0 or newer_
- .NET Standard 2.0 - _supports .NET Core 2.0 or newer and .NET Framework 4.6.2 or newer (however consuming projects will need to be built with a minimum C# language version of 9.0 due to use of init only properties within the phone number parser library)_

All versions of .NET which are still within their Microsoft support lifecycle will be supported by this library (excluding public betas), other versions of .NET and .NET Framework will retain support via the .NET Standard builds.

## Limitations

The library **does not**:

- Yet support all countries (additional countries are added incrementally through future releases).
- Provide certainty that a phone number is assigned and in use.
- Include the original carrier for mobile phone numbers due to number portability in most countries.
- Support extension numbers, although they are ignored if specified when parsing a value in RFC3966 format `tel:+44-114-272-644;ext=1234` or the older German style `0234/123456-10` format.
- Support alphabetic mnemonic system/alphabetic phone-words (e.g. 123-PHONEME).
