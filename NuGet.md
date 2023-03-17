# Phone Number Parser

A library for parsing phone numbers, providing a number of benefits over a regular expression. For example greater validity of phone numbers including national destination codes (aka area codes) and subscriber numbers (aka line numbers) based upon published numbering plans for each country. Additional attributes such as the kind of phone number (Mobile, Geographic or Non-Geographic) are also included, and all parsing is performed locally within the library using embedded in-memory data files.

Builds for:

- .NET 7.0
- .NET Standard 2.1 - _supports .NET Core 3.0 or later and .NET 5.0 or later_
- .NET Standard 2.0 - _supports .NET Framework 4.6.2 or later (.NET Framework projects will need to be built with C# 9.0 or later)_

```csharp
using PhoneNumbers;

// Parsing a phone number is achieved via the `PhoneNumber.Parse` method (or alternatively via `PhoneNumber.TryParse`). Any spaces, hyphens or other formatting in the input string is ignored.
var phoneNumber = PhoneNumber.Parse("+441142726444"); // or Parse("01142726444", "GB")

phoneNumber.NationalDestinationCode;     // 114 (aka area code)
phoneNumber.SubscriberNumber;            // 2726444 (aka line number)

// Country specific information is accessible via the Country property, for example:
phoneNumber.Country.CallingCode;         // +44
phoneNumber.Country.Iso3166Code;         // GB
phoneNumber.Country.Name;                // United Kingdom
phoneNumber.Country.TrunkPrefix;         // 0

// There are 3 subclasses of PhoneNumber, the correct type to cast to can be determined by inspecting the PhoneNumberKind property. Cast as appropriate to access additional properties.
var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
geographicPhoneNumber.GeographicArea;    // Sheffield

// The phone number can be formatted in the following ways, the default format output can be round tripped via `PhoneNumber.Parse()` to make database persistence straightforward.
phoneNumber.ToString();                  // +441142726444      (defaults to E.164 format)
phoneNumber.ToString("E.164");           // +441142726444      (E.164 format)
phoneNumber.ToString("E.123");           // +44 114 2726444    (E.123 international format)
phoneNumber.ToString("N");               // (0114) 2726444     (E.123 national notation format)
phoneNumber.ToString("RFC3966");         // tel:+44-114-272644 (RFC3966 format)
```
