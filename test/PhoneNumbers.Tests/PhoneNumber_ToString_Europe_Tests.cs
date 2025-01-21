namespace PhoneNumbers.Tests;

public class PhoneNumber_ToString_Europe_Tests
{
    [Theory]
    [InlineData("+376301115", "E.123", "+376 301115")]
    [InlineData("+376301115", "N", "301115")]
    [InlineData("+376301115", "RFC3966", "tel:+376-301115")]
    [InlineData("+376301115", "U", "301115")]
    public void Andorra_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+375172171185", "E.123", "+375 17 2171185")]
    [InlineData("+375172171185", "N", "817 2171185")]
    [InlineData("+375172171185", "RFC3966", "tel:+375-17-2171185")]
    [InlineData("+375172171185", "U", "8172171185")]
    public void Belarus_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+3222268888", "E.123", "+32 2 226 88 88")]
    [InlineData("+3250444646", "E.123", "+32 50 44 46 46")]
    [InlineData("+32455678123", "E.123", "+32 455 67 81 23")]
    [InlineData("+3222268888", "N", "02 226 88 88")]
    [InlineData("+3250444646", "N", "050 44 46 46")]
    [InlineData("+32455678123", "N", "0455 67 81 23")]
    [InlineData("+3222268888", "RFC3966", "tel:+32-2-226-88-88")]
    [InlineData("+3250444646", "RFC3966", "tel:+32-50-44-46-46")]
    [InlineData("+32455678123", "RFC3966", "tel:+32-455-67-81-23")]
    [InlineData("+3222268888", "U", "022268888")]
    [InlineData("+3250444646", "U", "050444646")]
    [InlineData("+32455678123", "U", "0455678123")]
    public void Belgium_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+38733250600", "E.123", "+387 33 250 600")]
    [InlineData("+38733250600", "N", "033 250 600")]
    [InlineData("+38733250600", "RFC3966", "tel:+387-33-250-600")]
    [InlineData("+38733250600", "U", "033250600")]
    public void BosniaAndHerzegovina_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+35929492760", "E.123", "+359 2 949 2760")]
    [InlineData("+35929492760", "N", "(02) 949 2760")]
    [InlineData("+35929492760", "RFC3966", "tel:+359-2-949-2760")]
    [InlineData("+35929492760", "U", "029492760")]
    public void Bulgaria_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+38517007007", "E.123", "+385 1 700 7007")]
    [InlineData("+38517007007", "N", "(01) 700 7007")]
    [InlineData("+38517007007", "RFC3966", "tel:+385-1-700-7007")]
    [InlineData("+38517007007", "U", "017007007")]
    public void Croatia_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+35722693000", "E.123", "+357 2269 3000")]
    [InlineData("+35722693000", "N", "2269 3000")]
    [InlineData("+35722693000", "RFC3966", "tel:+357-2269-3000")]
    [InlineData("+35722693000", "U", "22693000")]
    public void Cyprus_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+4209831452", "E.123", "+420 983 1452")]
    [InlineData("+420224004111", "E.123", "+420 224 004 111")] // 1 digit NDC still formatted 3-3-3
    [InlineData("+420351786544", "E.123", "+420 351 786 544")] // 2 digit NDC still formatted 3-3-3
    [InlineData("+420910687654", "E.123", "+420 910 687 654")] // 3 digit NDC still formatted 3-3-3
    [InlineData("+4209831452", "N", "983 1452")]
    [InlineData("+420224004111", "N", "224 004 111")] // 1 digit NDC still formatted 3-3-3
    [InlineData("+420910687654", "N", "910 687 654")] // 2 digit NDC still formatted 3-3-3
    [InlineData("+420351786544", "N", "351 786 544")] // 3 digit NDC still formatted 3-3-3
    [InlineData("+4209831452", "RFC3966", "tel:+420-983-1452")]
    [InlineData("+420224004111", "RFC3966", "tel:+420-224-004-111")] // 1 digit NDC still formatted 3-3-3
    [InlineData("+420351786544", "RFC3966", "tel:+420-351-786-544")] // 2 digit NDC still formatted 3-3-3
    [InlineData("+420910687654", "RFC3966", "tel:+420-910-687-654")] // 3 digit NDC still formatted 3-3-3
    [InlineData("+4209831452", "U", "9831452")]
    [InlineData("+420224004111", "U", "224004111")]
    [InlineData("+420910687654", "U", "910687654")]
    [InlineData("+420351786544", "U", "351786544")]
    public void CzechRepublic_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+4533926700", "E.123", "+45 3392 6700")]
    [InlineData("+4533926700", "N", "3392 6700")]
    [InlineData("+4533926700", "RFC3966", "tel:+45-3392-6700")]
    [InlineData("+4533926700", "U", "33926700")]
    public void Denmark_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+3726672072", "E.123", "+372 6672072")]
    [InlineData("+3726672072", "N", "6672072")]
    [InlineData("+3726672072", "RFC3966", "tel:+372-6672072")]
    [InlineData("+3726672072", "U", "6672072")]
    public void Estonia_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+298356020", "E.123", "+298 35 60 20")]
    [InlineData("+298356020", "N", "35 60 20")]
    [InlineData("+298356020", "RFC3966", "tel:+298-35-60-20")]
    [InlineData("+298356020", "U", "356020")]
    public void FaroeIslands_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+358295390361", "E.123", "+358 29 539 0361")] // Non Geographic
    [InlineData("+358931013300", "E.123", "+358 9 3101 3300")] // Geographic
    [InlineData("+358295390361", "N", "029 539 0361")] // Non Geographic
    [InlineData("+358931013300", "N", "(09) 3101 3300")] // Geographic
    [InlineData("+358295390361", "RFC3966", "tel:+358-29-539-0361")] // Non Geographic
    [InlineData("+358931013300", "RFC3966", "tel:+358-9-3101-3300")] // Geographic
    [InlineData("+358295390361", "U", "0295390361")] // Non Geographic
    [InlineData("+358931013300", "U", "0931013300")] // Geographic
    public void Finland_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+33140477283", "E.123", "+33 1 40 47 72 83")]
    [InlineData("+337000000000000", "E.123", "+33 7 00 00 00 00 00 00")]
    [InlineData("+33140477283", "N", "01 40 47 72 83")]
    [InlineData("+337000000000000", "N", "07 00 00 00 00 00 00")]
    [InlineData("+33140477283", "RFC3966", "tel:+33-1-40-47-72-83")]
    [InlineData("+337000000000000", "RFC3966", "tel:+33-7-00-00-00-00-00-00")]
    [InlineData("+33140477283", "U", "0140477283")]
    [InlineData("+337000000000000", "U", "07000000000000")]
    public void France_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+49228141177", "E.123", "+49 228 141177")]
    [InlineData("+49228141177", "N", "(0228) 141177")]
    [InlineData("+49228141177", "RFC3966", "tel:+49-228-141177")]
    [InlineData("+49228141177", "U", "0228141177")]
    public void Germany_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+35020074636", "E.123", "+350 20074636")]
    [InlineData("+35020074636", "N", "20074636")]
    [InlineData("+35020074636", "RFC3966", "tel:+350-20074636")]
    [InlineData("+35020074636", "U", "20074636")]
    public void Gibraltar_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+302106151000", "E.123", "+30 210 6151000")]
    [InlineData("+302513500100", "E.123", "+30 2513 500100")]
    [InlineData("+302695361300", "E.123", "+30 26953 61300")]
    [InlineData("+302106151000", "N", "210 6151000")]
    [InlineData("+302513500100", "N", "2513 500100")]
    [InlineData("+302695361300", "N", "26953 61300")]
    [InlineData("+302106151000", "RFC3966", "tel:+30-210-6151000")]
    [InlineData("+302513500100", "RFC3966", "tel:+30-2513-500100")]
    [InlineData("+302695361300", "RFC3966", "tel:+30-26953-61300")]
    [InlineData("+302106151000", "U", "2106151000")]
    [InlineData("+302513500100", "U", "2513500100")]
    [InlineData("+302695361300", "U", "2695361300")]
    public void Greece_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+441481717000", "E.123", "+44 1481 717000")]
    [InlineData("+441481717000", "N", "(01481) 717000")]
    [InlineData("+441481717000", "RFC3966", "tel:+44-1481-717000")]
    [InlineData("+441481717000", "U", "01481717000")]
    public void Guernsey_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+3614680666", "E.123", "+36 1 468 0666")]
    [InlineData("+3625145310", "E.123", "+36 25 145 310")]
    [InlineData("+36207834240", "E.123", "+36 20 783 4240")]
    [InlineData("+3614680666", "N", "(061) 468 0666")]
    [InlineData("+3625145310", "N", "(0625) 145 310")]
    [InlineData("+36207834240", "N", "0620 783 4240")]
    [InlineData("+3614680666", "RFC3966", "tel:+36-1-468-0666")]
    [InlineData("+3625145310", "RFC3966", "tel:+36-25-145-310")]
    [InlineData("+36207834240", "RFC3966", "tel:+36-20-783-4240")]
    [InlineData("+3614680666", "U", "0614680666")]
    [InlineData("+3625145310", "U", "0625145310")]
    [InlineData("+36207834240", "U", "06207834240")]
    public void Hungary_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+3545101500", "E.123", "+354 510 1500")]
    [InlineData("+3545101500", "N", "510 1500")]
    [InlineData("+3545101500", "RFC3966", "tel:+354-510-1500")]
    [InlineData("+3545101500", "U", "5101500")]
    public void Iceland_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+35318049600", "E.123", "+353 1 804 9600")]
    [InlineData("+35361247656", "E.123", "+353 61 247 656")]
    [InlineData("+35340223488", "E.123", "+353 402 23488")]
    [InlineData("+35318049600", "N", "(01) 804 9600")]
    [InlineData("+35361247656", "N", "(061) 247 656")]
    [InlineData("+35340223488", "N", "(0402) 23488")]
    [InlineData("+35318049600", "RFC3966", "tel:+353-1-804-9600")]
    [InlineData("+35361247656", "RFC3966", "tel:+353-61-247-656")]
    [InlineData("+35340223488", "RFC3966", "tel:+353-402-23488")]
    [InlineData("+35318049600", "U", "018049600")]
    [InlineData("+35361247656", "U", "061247656")]
    [InlineData("+35340223488", "U", "040223488")]
    public void Ireland_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+441624696300", "E.123", "+44 1624 696300")]
    [InlineData("+441624696300", "N", "(01624) 696300")]
    [InlineData("+441624696300", "RFC3966", "tel:+44-1624-696300")]
    [InlineData("+441624696300", "U", "01624696300")]
    public void IsleOfMan_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    // Italy has no defined format convention so use the simple format
    [Theory]
    [InlineData("+390549882555", "E.123", "+39 0549 882555")]       // San Marino Landline via Italian NDC
    [InlineData("+390577292222", "E.123", "+39 0577 292222")]       // Geo
    [InlineData("+393492525255", "E.123", "+39 34 92525255")]       // Mobile
    [InlineData("+390549882555", "N", "0549 882555")]               // San Marino Landline via Italian NDC
    [InlineData("+390577292222", "N", "0577 292222")]               // Geo
    [InlineData("+393492525255", "N", "34 92525255")]               // Mobile
    [InlineData("+390549882555", "RFC3966", "tel:+39-0549-882555")] // San Marino Landline via Italian NDC
    [InlineData("+390577292222", "RFC3966", "tel:+39-0577-292222")] // Geo
    [InlineData("+393492525255", "RFC3966", "tel:+39-34-92525255")] // Mobile
    [InlineData("+390549882555", "U", "0549882555")]                // San Marino Landline via Italian NDC
    [InlineData("+390577292222", "U", "0577292222")]                // Geo
    [InlineData("+393492525255", "U", "3492525255")]                // Mobile
    public void Italy_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+441534716800", "E.123", "+44 1534 716800")]
    [InlineData("+441534716800", "N", "(01534) 716800")]
    [InlineData("+441534716800", "RFC3966", "tel:+44-1534-716800")]
    [InlineData("+441534716800", "U", "01534716800")]
    public void Jersey_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+38338212345", "E.123", "+383 38 212 345")]
    [InlineData("+38339020482", "E.123", "+383 390 20482")]
    [InlineData("+38343295870", "E.123", "+383 43 295 870")]
    [InlineData("+38338212345", "N", "(038) 212 345")]
    [InlineData("+38339020482", "N", "(0390) 20482")]
    [InlineData("+38343295870", "N", "043 295 870")]
    [InlineData("+38338212345", "RFC3966", "tel:+383-38-212-345")]
    [InlineData("+38339020482", "RFC3966", "tel:+383-390-20482")]
    [InlineData("+38343295870", "RFC3966", "tel:+383-43-295-870")]
    [InlineData("+38338212345", "U", "038212345")]
    [InlineData("+38339020482", "U", "039020482")]
    [InlineData("+38343295870", "U", "043295870")]
    public void Kosovo_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+37167028398", "E.123", "+371 67028398")]
    [InlineData("+37167028398", "N", "67028398")]
    [InlineData("+37167028398", "RFC3966", "tel:+371-67028398")]
    [InlineData("+37167028398", "U", "67028398")]
    public void Latvia_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+4232366488", "E.123", "+423 236 64 88")]
    [InlineData("+423607325480", "E.123", "+423 607 325 480")]
    [InlineData("+4232366488", "N", "236 64 88")]
    [InlineData("+423607325480", "N", "607 325 480")]
    [InlineData("+4232366488", "RFC3966", "tel:+423-236-64-88")]
    [InlineData("+423607325480", "RFC3966", "tel:+423-607-325-480")]
    [InlineData("+4232366488", "U", "2366488")]
    [InlineData("+423607325480", "U", "607325480")]
    public void Liechtenstein_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+37052105664", "E.123", "+370 5 210 5664")]
    [InlineData("+37052105664", "N", "(85) 210 5664")]
    [InlineData("+37052105664", "RFC3966", "tel:+370-5-210-5664")]
    [InlineData("+37052105664", "U", "852105664")]
    public void Lithuania_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+352493579", "E.123", "+352 49 35 79")]
    [InlineData("+35228228228", "E.123", "+352 28 228 228")]
    [InlineData("+35290500000", "E.123", "+352 9050 0000")]
    [InlineData("+352691000000", "E.123", "+352 691 000 000")]
    [InlineData("+352493579", "N", "49 35 79")]
    [InlineData("+35228228228", "N", "28 228 228")]
    [InlineData("+35290500000", "N", "9050 0000")]
    [InlineData("+352691000000", "N", "691 000 000")]
    [InlineData("+352493579", "RFC3966", "tel:+352-49-35-79")]
    [InlineData("+35228228228", "RFC3966", "tel:+352-28-228-228")]
    [InlineData("+35290500000", "RFC3966", "tel:+352-9050-0000")]
    [InlineData("+352691000000", "RFC3966", "tel:+352-691-000-000")]
    [InlineData("+352493579", "U", "493579")]
    [InlineData("+35228228228", "U", "28228228")]
    [InlineData("+35290500000", "U", "90500000")]
    [InlineData("+352691000000", "U", "691000000")]
    public void Luxembourg_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+35621336840", "E.123", "+356 2133 6840")]
    [InlineData("+35621336840", "N", "2133 6840")]
    [InlineData("+35621336840", "RFC3966", "tel:+356-2133-6840")]
    [InlineData("+35621336840", "U", "21336840")]
    public void Malta_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+37322251317", "E.123", "+373 22 251 317")]
    [InlineData("+37322251317", "N", "022 251 317")]
    [InlineData("+37322251317", "RFC3966", "tel:+373-22-251-317")]
    [InlineData("+37322251317", "U", "022251317")]
    public void Moldova_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+37798988800", "E.123", "+377 98 98 88 00")]
    [InlineData("+377298765235459", "E.123", "+377 298765235459")]
    [InlineData("+37798988800", "N", "98 98 88 00")]
    [InlineData("+377298765235459", "N", "298765235459")]
    [InlineData("+37798988800", "RFC3966", "tel:+377-98-98-88-00")]
    [InlineData("+377298765235459", "RFC3966", "tel:+377-298765235459")]
    [InlineData("+37798988800", "U", "98988800")]
    [InlineData("+377298765235459", "U", "298765235459")]
    public void Monaco_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+38220406700", "E.123", "+382 20 406 700")]
    [InlineData("+38220406700", "N", "020 406 700")]
    [InlineData("+38220406700", "RFC3966", "tel:+382-20-406-700")]
    [InlineData("+38220406700", "U", "020406700")]
    public void Montenegro_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+31702140214", "E.123", "+31 7 02 14 02 14")]
    [InlineData("+31702140214", "N", "07 02 14 02 14")]
    [InlineData("+31702140214", "RFC3966", "tel:+31-7-02-14-02-14")]
    [InlineData("+31702140214", "U", "0702140214")]
    public void Netherlands_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+38923289200", "E.123", "+389 2 328 9200")]
    [InlineData("+38970221213", "E.123", "+389 70 221 213")]
    [InlineData("+38923289200", "N", "(02) 328 9200")]
    [InlineData("+38970221213", "N", "070 221 213")]
    [InlineData("+38923289200", "RFC3966", "tel:+389-2-328-9200")]
    [InlineData("+38970221213", "RFC3966", "tel:+389-70-221-213")]
    [InlineData("+38923289200", "U", "023289200")]
    [InlineData("+38970221213", "U", "070221213")]
    public void NorthMacedonia_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+4722824600", "E.123", "+47 22 82 46 00")]
    [InlineData("+4780824600", "E.123", "+47 808 24 600")]
    [InlineData("+47581223344556", "E.123", "+47 58 12 23 34 45 56")]
    [InlineData("+4722824600", "N", "22 82 46 00")]
    [InlineData("+4780824600", "N", "808 24 600")]
    [InlineData("+47581223344556", "N", "58 12 23 34 45 56")]
    [InlineData("+4722824600", "RFC3966", "tel:+47-22-82-46-00")]
    [InlineData("+4780824600", "RFC3966", "tel:+47-808-24-600")]
    [InlineData("+47581223344556", "RFC3966", "tel:+47-58-12-23-34-45-56")]
    [InlineData("+4722824600", "U", "22824600")]
    [InlineData("+4780824600", "U", "80824600")]
    [InlineData("+47581223344556", "U", "581223344556")]
    public void Norway_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+48222455856", "E.123", "+48 22 245 58 56")]
    [InlineData("+48458787987", "E.123", "+48 458 787 987")]
    [InlineData("+48222455856", "N", "22-245-58-56")]
    [InlineData("+48458787987", "N", "458-787-987")]
    [InlineData("+48222455856", "RFC3966", "tel:+48-22-245-58-56")]
    [InlineData("+48458787987", "RFC3966", "tel:+48-458-787-987")]
    [InlineData("+48222455856", "U", "222455856")]
    [InlineData("+48458787987", "U", "458787987")]
    public void Poland_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+351217211000", "E.123", "+351 217 211 000")]
    [InlineData("+351217211000", "N", "217 211 000")]
    [InlineData("+351217211000", "RFC3966", "tel:+351-217-211-000")]
    [InlineData("+351217211000", "U", "217211000")]
    public void Portugal_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+40213320771", "E.123", "+40 21 332 07 71")]
    [InlineData("+40372845414", "E.123", "+40 372 845 414")]
    [InlineData("+40372845414", "N", "0372 845 414")]
    [InlineData("+40213320771", "N", "021 332 07 71")]
    [InlineData("+40213320771", "RFC3966", "tel:+40-21-332-07-71")]
    [InlineData("+40372845414", "RFC3966", "tel:+40-372-845-414")]
    [InlineData("+40372845414", "U", "0372845414")]
    [InlineData("+40213320771", "U", "0213320771")]
    public void Romania_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+74957718000", "E.123", "+7 495 771 8000")]
    [InlineData("+74957718000", "N", "8495 771 8000")]
    [InlineData("+74957718000", "RFC3966", "tel:+7-495-771-8000")]
    [InlineData("+74957718000", "U", "84957718000")]
    public void Russia_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    // Italy has no defined format convention so use the simple format
    [Theory]
    [InlineData("+37858001110", "E.123", "+378 58 001110")]           // IP Telephony
    [InlineData("+37866661212", "E.123", "+378 66 661212")]           // Mobile
    [InlineData("+378882555", "E.123", "+378 882555")]                // Landline without Italian NDC
    [InlineData("+378054988", "E.123", "+378 0549 88")]               // Landline with Italian NDC
    [InlineData("+3780549882", "E.123", "+378 0549 882")]             // Landline with Italian NDC
    [InlineData("+37805498825", "E.123", "+378 0549 8825")]           // Landline with Italian NDC
    [InlineData("+378054988255", "E.123", "+378 0549 88255")]         // Landline with Italian NDC
    [InlineData("+3780549882555", "E.123", "+378 0549 882555")]       // Landline with Italian NDC
    [InlineData("+37858001110", "N", "58 001110")]                    // IP Telephony
    [InlineData("+37866661212", "N", "66 661212")]                    // Mobile
    [InlineData("+378882555", "N", "882555")]                         // Landline without Italian NDC
    [InlineData("+378054988", "N", "(0549) 88")]                      // Landline with Italian NDC
    [InlineData("+3780549882", "N", "(0549) 882")]                    // Landline with Italian NDC
    [InlineData("+37805498825", "N", "(0549) 8825")]                  // Landline with Italian NDC
    [InlineData("+378054988255", "N", "(0549) 88255")]                // Landline with Italian NDC
    [InlineData("+3780549882555", "N", "(0549) 882555")]              // Landline with Italian NDC
    [InlineData("+37858001110", "RFC3966", "tel:+378-58-001110")]     // IP Telephony
    [InlineData("+37866661212", "RFC3966", "tel:+378-66-661212")]     // Mobile
    [InlineData("+378882555", "RFC3966", "tel:+378-882555")]          // Landline without Italian NDC
    [InlineData("+378054988", "RFC3966", "tel:+378-0549-88")]         // Landline with Italian NDC
    [InlineData("+3780549882", "RFC3966", "tel:+378-0549-882")]       // Landline with Italian NDC
    [InlineData("+37805498825", "RFC3966", "tel:+378-0549-8825")]     // Landline with Italian NDC
    [InlineData("+378054988255", "RFC3966", "tel:+378-0549-88255")]   // Landline with Italian NDC
    [InlineData("+3780549882555", "RFC3966", "tel:+378-0549-882555")] // Landline with Italian NDC
    [InlineData("+37858001110", "U", "58001110")]                     // IP Telephony
    [InlineData("+37866661212", "U", "66661212")]                     // Mobile
    [InlineData("+378882555", "U", "882555")]                         // Landline without Italian NDC
    [InlineData("+3780549882", "U", "0549882")]                       // Landline with Italian NDC
    [InlineData("+37805498825", "U", "05498825")]                     // Landline with Italian NDC
    [InlineData("+378054988255", "U", "054988255")]                   // Landline with Italian NDC
    [InlineData("+3780549882555", "U", "0549882555")]                 // Landline with Italian NDC
    public void SanMarino_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+381112026828", "E.123", "+381 11 202 6828")]
    [InlineData("+381112026828", "N", "(011) 202 6828")]
    [InlineData("+381112026828", "RFC3966", "tel:+381-11-202-6828")]
    [InlineData("+381112026828", "U", "0112026828")]
    public void Serbia_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+421257881101", "E.123", "+421 2 5788 1101")]
    [InlineData("+421415005178", "E.123", "+421 41 500 5178")]
    [InlineData("+421949554223", "E.123", "+421 949 554 223")]
    [InlineData("+421257881101", "N", "02 5788 1101")]
    [InlineData("+421415005178", "N", "041 500 5178")]
    [InlineData("+421949554223", "N", "0949 554 223")]
    [InlineData("+421257881101", "RFC3966", "tel:+421-2-5788-1101")]
    [InlineData("+421415005178", "RFC3966", "tel:+421-41-500-5178")]
    [InlineData("+421949554223", "RFC3966", "tel:+421-949-554-223")]
    [InlineData("+421257881101", "U", "0257881101")]
    [InlineData("+421415005178", "U", "0415005178")]
    [InlineData("+421949554223", "U", "0949554223")]
    public void Slovakia_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+38615836300", "E.123", "+386 1 583 63 00")]
    [InlineData("+38630123654", "E.123", "+386 30 123 654")]
    [InlineData("+38665012365", "E.123", "+386 650 12 365")]
    [InlineData("+38615836300", "N", "(01) 583 63 00")]
    [InlineData("+38630123654", "N", "030 123 654")]
    [InlineData("+38665012365", "N", "0650 12 365")]
    [InlineData("+38615836300", "RFC3966", "tel:+386-1-583-63-00")]
    [InlineData("+38630123654", "RFC3966", "tel:+386-30-123-654")]
    [InlineData("+38665012365", "RFC3966", "tel:+386-650-12-365")]
    [InlineData("+38615836300", "U", "015836300")]
    [InlineData("+38630123654", "U", "030123654")]
    [InlineData("+38665012365", "U", "065012365")]
    public void Slovenia_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+34912582852", "E.123", "+34 91 258 28 52")] // 2-3-2-2 where the NDC is 2 digits (applicable for Madrid & Barcelona)
    [InlineData("+34902189900", "E.123", "+34 902 189 900")] // 3-3-3 where the NDC is 3 digits
    [InlineData("+34912582852", "N", "91 258 28 52")] // 2-3-2-2 where the NDC is 2 digits (applicable for Madrid & Barcelona)
    [InlineData("+34902189900", "N", "902 189 900")] // 3-3-3 where the NDC is 3 digits
    [InlineData("+34912582852", "RFC3966", "tel:+34-91-258-28-52")] // 2-3-2-2 where the NDC is 2 digits (applicable for Madrid & Barcelona)
    [InlineData("+34902189900", "RFC3966", "tel:+34-902-189-900")] // 3-3-3 where the NDC is 3 digits
    [InlineData("+34912582852", "U", "912582852")]
    [InlineData("+34902189900", "U", "902189900")]
    public void Spain_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+46201234", "E.123", "+46 20 1234")]
    [InlineData("+462012345", "E.123", "+46 20 123 45")]
    [InlineData("+4620123456", "E.123", "+46 20 12 34 56")]
    [InlineData("+468678550", "E.123", "+46 8 67 85 50")]
    [InlineData("+4686785500", "E.123", "+46 8 678 55 00")]
    [InlineData("+46867855001", "E.123", "+46 8 678 550 01")]
    [InlineData("+46777855001", "E.123", "+46 77 785 50 01")]
    [InlineData("+469067855", "E.123", "+46 90 678 55")]
    [InlineData("+4690678550", "E.123", "+46 90 67 85 50")]
    [InlineData("+46906785500", "E.123", "+46 90 678 55 00")]
    [InlineData("+4664067855", "E.123", "+46 640 678 55")]
    [InlineData("+46640678550", "E.123", "+46 640 67 85 50")]
    [InlineData("+4690012345", "E.123", "+46 900 123 45")]
    [InlineData("+46900123456", "E.123", "+46 900 12 34 56")]
    [InlineData("+46201234", "N", "020 1234")]
    [InlineData("+462012345", "N", "020 123 45")]
    [InlineData("+4620123456", "N", "020 12 34 56")]
    [InlineData("+468678550", "N", "(08) 67 85 50")]
    [InlineData("+4686785500", "N", "(08) 678 55 00")]
    [InlineData("+46867855001", "N", "(08) 678 550 01")]
    [InlineData("+46777855001", "N", "077 785 50 01")] // mobile so NDC not optional
    [InlineData("+469067855", "N", "(090) 678 55")]
    [InlineData("+4690678550", "N", "(090) 67 85 50")]
    [InlineData("+46906785500", "N", "(090) 678 55 00")]
    [InlineData("+4664067855", "N", "(0640) 678 55")]
    [InlineData("+46640678550", "N", "(0640) 67 85 50")]
    [InlineData("+4690012345", "N", "0900 123 45")]
    [InlineData("+46900123456", "N", "0900 12 34 56")]
    [InlineData("+46201234", "RFC3966", "tel:+46-20-1234")]
    [InlineData("+462012345", "RFC3966", "tel:+46-20-123-45")]
    [InlineData("+4620123456", "RFC3966", "tel:+46-20-12-34-56")]
    [InlineData("+468678550", "RFC3966", "tel:+46-8-67-85-50")]
    [InlineData("+4686785500", "RFC3966", "tel:+46-8-678-55-00")]
    [InlineData("+46867855001", "RFC3966", "tel:+46-8-678-550-01")]
    [InlineData("+46777855001", "RFC3966", "tel:+46-77-785-50-01")]
    [InlineData("+469067855", "RFC3966", "tel:+46-90-678-55")]
    [InlineData("+4690678550", "RFC3966", "tel:+46-90-67-85-50")]
    [InlineData("+46906785500", "RFC3966", "tel:+46-90-678-55-00")]
    [InlineData("+4664067855", "RFC3966", "tel:+46-640-678-55")]
    [InlineData("+46640678550", "RFC3966", "tel:+46-640-67-85-50")]
    [InlineData("+4690012345", "RFC3966", "tel:+46-900-123-45")]
    [InlineData("+46900123456", "RFC3966", "tel:+46-900-12-34-56")]
    [InlineData("+46201234", "U", "0201234")]
    [InlineData("+462012345", "U", "02012345")]
    [InlineData("+4620123456", "U", "020123456")]
    [InlineData("+468678550", "U", "08678550")]
    [InlineData("+4686785500", "U", "086785500")]
    [InlineData("+46867855001", "U", "0867855001")]
    [InlineData("+46777855001", "U", "0777855001")]
    [InlineData("+469067855", "U", "09067855")]
    [InlineData("+4690678550", "U", "090678550")]
    [InlineData("+46906785500", "U", "0906785500")]
    [InlineData("+4664067855", "U", "064067855")]
    [InlineData("+46640678550", "U", "0640678550")]
    [InlineData("+4690012345", "U", "090012345")]
    [InlineData("+46900123456", "U", "0900123456")]
    public void Sweden_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+41584605511", "E.123", "+41 58 460 55 11")] // 2-3-2-2 where the NDC is 2 digits
    [InlineData("+41840545987", "E.123", "+41 840 545 987")] // 3-3-3 where the NDC is 3 digits
    [InlineData("+41584605511", "N", "058 460 55 11")] // 2-3-2-2 where the NDC is 2 digits
    [InlineData("+41840545987", "N", "0840 545 987")] // 3-3-3 where the NDC is 3 digits
    [InlineData("+41584605511", "RFC3966", "tel:+41-58-460-55-11")] // 2-3-2-2 where the NDC is 2 digits
    [InlineData("+41840545987", "RFC3966", "tel:+41-840-545-987")] // 3-3-3 where the NDC is 3 digits
    [InlineData("+41584605511", "U", "0584605511")]
    [InlineData("+41840545987", "U", "0840545987")]
    public void Switzerland_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+380442819196", "E.123", "+380 44 281 91 96")]
    [InlineData("+380891233456", "E.123", "+380 891 233 456")]
    [InlineData("+380442819196", "N", "(044) 281 91 96")]
    [InlineData("+380891233456", "N", "0891 233 456")]
    [InlineData("+380442819196", "RFC3966", "tel:+380-44-281-91-96")]
    [InlineData("+380891233456", "RFC3966", "tel:+380-891-233-456")]
    [InlineData("+380442819196", "U", "0442819196")]
    [InlineData("+380891233456", "U", "0891233456")]
    public void Ukraine_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+442079813000", "E.123", "+44 20 7981 3000")]
    [InlineData("+441142726444", "E.123", "+44 114 272 6444")]
    [InlineData("+443001100123", "E.123", "+44 300 110 0123")]
    [InlineData("+441642012234", "E.123", "+44 1642 012234")]
    [InlineData("+441733234567", "E.123", "+44 1733 234567")]
    [InlineData("+447106010234", "E.123", "+44 7106 010234")]
    [InlineData("+441946722130", "E.123", "+44 19467 22130")]
    [InlineData("+442079813000", "N", "(020) 7981 3000")]
    [InlineData("+448001111", "N", "0800 1111")] // no parenthesis for area code as it's not optional for non-geographic numbers
    [InlineData("+441142726444", "N", "(0114) 272 6444")]
    [InlineData("+443001100123", "N", "0300 110 0123")] // no parenthesis for area code as it's not optional for non-geographic numbers
    [InlineData("+441642012234", "N", "01642 012234")] // no parenthesis for area code as it's not optional for this area code due to number shortages
    [InlineData("+441733234567", "N", "(01733) 234567")]
    [InlineData("+447106010234", "N", "07106 010234")] // no parenthesis for area code as it's not optional for mobile numbers
    [InlineData("+441946722130", "N", "(019467) 22130")]
    [InlineData("+442079813000", "RFC3966", "tel:+44-20-7981-3000")]
    [InlineData("+441142726444", "RFC3966", "tel:+44-114-272-6444")]
    [InlineData("+443001100123", "RFC3966", "tel:+44-300-110-0123")]
    [InlineData("+441733234567", "RFC3966", "tel:+44-1733-234567")]
    [InlineData("+441642012234", "RFC3966", "tel:+44-1642-012234")]
    [InlineData("+447106010234", "RFC3966", "tel:+44-7106-010234")]
    [InlineData("+441946722130", "RFC3966", "tel:+44-19467-22130")]
    [InlineData("+442079813000", "U", "02079813000")]
    [InlineData("+448001111", "U", "08001111")]
    [InlineData("+441142726444", "U", "01142726444")]
    [InlineData("+443001100123", "U", "03001100123")]
    [InlineData("+441642012234", "U", "01642012234")]
    [InlineData("+441733234567", "U", "01733234567")]
    [InlineData("+447106010234", "U", "07106010234")]
    [InlineData("+441946722130", "U", "01946722130")]
    public void UnitedKingdom_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));
}
