using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Germany <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_DE_GeographicNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Germany);

        [Theory]
        [InlineData("0201000", "201", "000", "Essen")]
        [InlineData("020199999999", "201", "99999999", "Essen")]
        [InlineData("0202000", "202", "000", "Wuppertal")]
        [InlineData("020299999999", "202", "99999999", "Wuppertal")]
        [InlineData("0203000", "203", "000", "Duisburg")]
        [InlineData("020399999999", "203", "99999999", "Duisburg")]
        [InlineData("0208000", "208", "000", "Oberhausen")]
        [InlineData("020899999999", "208", "99999999", "Oberhausen")]
        [InlineData("0209000", "209", "000", "Gelsenkirchen")]
        [InlineData("020999999999", "209", "99999999", "Gelsenkirchen")]
        [InlineData("0211000", "211", "000", "Düsseldorf")]
        [InlineData("021199999999", "211", "99999999", "Düsseldorf")]
        [InlineData("0212000", "212", "000", "Solingen")]
        [InlineData("021289999999", "212", "89999999", "Solingen")]
        [InlineData("0214000", "214", "000", "Leverkusen")]
        [InlineData("021499999999", "214", "99999999", "Leverkusen")]
        [InlineData("0221000", "221", "000", "Köln")]
        [InlineData("022199999999", "221", "99999999", "Köln")]
        [InlineData("0228000", "228", "000", "Bonn")]
        [InlineData("022899999999", "228", "99999999", "Bonn")]
        public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Germany, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0204100", "2041", "00", "Bottrop")]
        [InlineData("020419999999", "2041", "9999999", "Bottrop")]
        [InlineData("0204300", "2043", "00", "Gladbeck")]
        [InlineData("020439999999", "2043", "9999999", "Gladbeck")]
        [InlineData("0204500", "2045", "00", "Bottrop-Kirchhellen")]
        [InlineData("020459999999", "2045", "9999999", "Bottrop-Kirchhellen")]
        [InlineData("0205100", "2051", "00", "Velbert")]
        [InlineData("020519999999", "2051", "9999999", "Velbert")]
        [InlineData("0205200", "2052", "00", "Velbert-Langenberg")]
        [InlineData("020529999999", "2052", "9999999", "Velbert-Langenberg")]
        [InlineData("0205300", "2053", "00", "Velbert-Neviges")]
        [InlineData("020539999999", "2053", "9999999", "Velbert-Neviges")]
        [InlineData("0205400", "2054", "00", "Essen-Kettwig")]
        [InlineData("020549999999", "2054", "9999999", "Essen-Kettwig")]
        [InlineData("0205600", "2056", "00", "Heiligenhaus")]
        [InlineData("020569999999", "2056", "9999999", "Heiligenhaus")]
        [InlineData("0205800", "2058", "00", "Wülfrath")]
        [InlineData("020589999999", "2058", "9999999", "Wülfrath")]
        [InlineData("0206400", "2064", "00", "Dinslaken")]
        [InlineData("020649999999", "2064", "9999999", "Dinslaken")]
        [InlineData("0206500", "2065", "00", "Duisburg-Rheinhausen")]
        [InlineData("020659999999", "2065", "9999999", "Duisburg-Rheinhausen")]
        [InlineData("0206600", "2066", "00", "Duisburg-Homberg")]
        [InlineData("020669999999", "2066", "9999999", "Duisburg-Homberg")]
        [InlineData("0210200", "2102", "00", "Ratingen")]
        [InlineData("0210299999999", "2102", "99999999", "Ratingen")]
        [InlineData("0210300", "2103", "00", "Hilden")]
        [InlineData("0210399999999", "2103", "99999999", "Hilden")]
        [InlineData("0210400", "2104", "00", "Mettmann")]
        [InlineData("0210499999999", "2104", "99999999", "Mettmann")]
        [InlineData("0212900", "2129", "00", "Haan Rheinland")]
        [InlineData("0212999999999", "2129", "99999999", "Haan Rheinland")]
        [InlineData("0213100", "2131", "00", "Neuss")]
        [InlineData("0213199999999", "2131", "99999999", "Neuss")]
        [InlineData("0213200", "2132", "00", "Meerbusch-Büderich")]
        [InlineData("0213299999999", "2132", "99999999", "Meerbusch-Büderich")]
        [InlineData("0213300", "2133", "00", "Dormagen")]
        [InlineData("0213399999999", "2133", "99999999", "Dormagen")]
        [InlineData("0213700", "2137", "00", "Neuss-Norf")]
        [InlineData("0213799999999", "2137", "99999999", "Neuss-Norf")]
        [InlineData("0215000", "2150", "00", "Meerbusch-Lank")]
        [InlineData("0215099999999", "2150", "99999999", "Meerbusch-Lank")]
        [InlineData("0215100", "2151", "00", "Krefeld")]
        [InlineData("0215199999999", "2151", "99999999", "Krefeld")]
        [InlineData("0215200", "2152", "00", "Kempen")]
        [InlineData("0215299999999", "2152", "99999999", "Kempen")]
        [InlineData("0215300", "2153", "00", "Nettetal-Lobberich")]
        [InlineData("0215399999999", "2153", "99999999", "Nettetal-Lobberich")]
        [InlineData("0215400", "2154", "00", "Willich")]
        [InlineData("0215499999999", "2154", "99999999", "Willich")]
        [InlineData("0215600", "2156", "00", "Willich-Anrath")]
        [InlineData("0215699999999", "2156", "99999999", "Willich-Anrath")]
        [InlineData("0215700", "2157", "00", "Nettetal-Kaldenkirchen")]
        [InlineData("0215799999999", "2157", "99999999", "Nettetal-Kaldenkirchen")]
        [InlineData("0215800", "2158", "00", "Grefrath bei Krefeld")]
        [InlineData("0215899999999", "2158", "99999999", "Grefrath bei Krefeld")]
        [InlineData("0215900", "2159", "00", "Meerbusch-Osterath")]
        [InlineData("0215999999999", "2159", "99999999", "Meerbusch-Osterath")]
        [InlineData("0216100", "2161", "00", "Mönchengladbach")]
        [InlineData("0216199999999", "2161", "99999999", "Mönchengladbach")]
        [InlineData("0216200", "2162", "00", "Viersen")]
        [InlineData("0216299999999", "2162", "99999999", "Viersen")]
        [InlineData("0216300", "2163", "00", "Schwalmtal Niederrhein")]
        [InlineData("0216399999999", "2163", "99999999", "Schwalmtal Niederrhein")]
        [InlineData("0216400", "2164", "00", "Jüchen-Otzenrath")]
        [InlineData("0216499999999", "2164", "99999999", "Jüchen-Otzenrath")]
        [InlineData("0216500", "2165", "00", "Jüchen")]
        [InlineData("0216599999999", "2165", "99999999", "Jüchen")]
        [InlineData("0216600", "2166", "00", "Mönchengladbach-Rheydt")]
        [InlineData("0216699999999", "2166", "99999999", "Mönchengladbach-Rheydt")]
        [InlineData("0217100", "2171", "00", "Leverkusen-Opladen")]
        [InlineData("0217199999999", "2171", "99999999", "Leverkusen-Opladen")]
        [InlineData("0217300", "2173", "00", "Langenfeld Rheinland")]
        [InlineData("0217399999999", "2173", "99999999", "Langenfeld Rheinland")]
        [InlineData("0217400", "2174", "00", "Langenfeld Rheinland")]
        [InlineData("0217499999999", "2174", "99999999", "Langenfeld Rheinland")]
        [InlineData("0217500", "2175", "00", "Leichlingen Rheinland")]
        [InlineData("0217599999999", "2175", "99999999", "Leichlingen Rheinland")]
        [InlineData("0218100", "2181", "00", "Grevenbroich")]
        [InlineData("0218199999999", "2181", "99999999", "Grevenbroich")]
        [InlineData("0218200", "2182", "00", "Grevenbroich-Kapellen")]
        [InlineData("0218299999999", "2182", "99999999", "Grevenbroich-Kapellen")]
        [InlineData("0218300", "2183", "00", "Rommerskirchen")]
        [InlineData("0218399999999", "2183", "99999999", "Rommerskirchen")]
        [InlineData("0219100", "2191", "00", "Remscheid")]
        [InlineData("0219199999999", "2191", "99999999", "Remscheid")]
        [InlineData("0219200", "2192", "00", "Hückeswagen")]
        [InlineData("0219299999999", "2192", "99999999", "Hückeswagen")]
        [InlineData("0219300", "2193", "00", "Dabringhausen")]
        [InlineData("0219399999999", "2193", "99999999", "Dabringhausen")]
        [InlineData("0219500", "2195", "00", "Radevormwald")]
        [InlineData("0219599999999", "2195", "99999999", "Radevormwald")]
        [InlineData("0219600", "2196", "00", "Wermelskirchen")]
        [InlineData("0219699999999", "2196", "99999999", "Wermelskirchen")]
        [InlineData("0220200", "2202", "00", "Bergisch Gladbach")]
        [InlineData("0220299999999", "2202", "99999999", "Bergisch Gladbach")]
        [InlineData("0220300", "2203", "00", "Köln-Porz")]
        [InlineData("0220399999999", "2203", "99999999", "Köln-Porz")]
        [InlineData("0220400", "2204", "00", "Bensberg")]
        [InlineData("0220499999999", "2204", "99999999", "Bensberg")]
        [InlineData("0220500", "2205", "00", "Rösrath")]
        [InlineData("0220599999999", "2205", "99999999", "Rösrath")]
        [InlineData("0220600", "2206", "00", "Overath")]
        [InlineData("022069999999", "2206", "9999999", "Overath")]
        [InlineData("0220700", "2207", "00", "Kürten-Dürscheid")]
        [InlineData("022079999999", "2207", "9999999", "Kürten-Dürscheid")]
        [InlineData("0220800", "2208", "00", "Niederkassel")]
        [InlineData("022089999999", "2208", "9999999", "Niederkassel")]
        [InlineData("0222200", "2222", "00", "Bornheim Rheinland")]
        [InlineData("022229999999", "2222", "9999999", "Bornheim Rheinland")]
        [InlineData("0222300", "2223", "00", "Königswinter")]
        [InlineData("022239999999", "2223", "9999999", "Königswinter")]
        [InlineData("0222400", "2224", "00", "Bad Honnef")]
        [InlineData("022249999999", "2224", "9999999", "Bad Honnef")]
        [InlineData("0222500", "2225", "00", "Meckenheim Rheinland")]
        [InlineData("022259999999", "2225", "9999999", "Meckenheim Rheinland")]
        [InlineData("0222600", "2226", "00", "Rheinbach")]
        [InlineData("022269999999", "2226", "9999999", "Rheinbach")]
        [InlineData("0222700", "2227", "00", "Bornheim-Merten")]
        [InlineData("022279999999", "2227", "9999999", "Bornheim-Merten")]
        [InlineData("0222800", "2228", "00", "Remagen-Rolandseck")]
        [InlineData("022289999999", "2228", "9999999", "Remagen-Rolandseck")]
        [InlineData("0223200", "2232", "00", "Brühl Rheinland")]
        [InlineData("022329999999", "2232", "9999999", "Brühl Rheinland")]
        [InlineData("0223300", "2233", "00", "Hrühl Rheinland")]
        [InlineData("022339999999", "2233", "9999999", "Hrühl Rheinland")]
        [InlineData("0223400", "2234", "00", "Frechen")]
        [InlineData("022349999999", "2234", "9999999", "Frechen")]
        [InlineData("0223500", "2235", "00", "Erftstadt")]
        [InlineData("022359999999", "2235", "9999999", "Erftstadt")]
        [InlineData("0223600", "2236", "00", "Wesseling Rheinland")]
        [InlineData("022369999999", "2236", "9999999", "Wesseling Rheinland")]
        [InlineData("0223700", "2237", "00", "Kerpen Rheinland-Türnich")]
        [InlineData("022379999999", "2237", "9999999", "Kerpen Rheinland-Türnich")]
        [InlineData("0223800", "2238", "00", "Pulheim")]
        [InlineData("022389999999", "2238", "9999999", "Pulheim")]
        [InlineData("0224100", "2241", "00", "Siegburg")]
        [InlineData("022419999999", "2241", "9999999", "Siegburg")]
        [InlineData("0224200", "2242", "00", "Hennef Sieg")]
        [InlineData("022429999999", "2242", "9999999", "Hennef Sieg")]
        [InlineData("0224300", "2243", "00", "Eitorf")]
        [InlineData("022439999999", "2243", "9999999", "Eitorf")]
        [InlineData("0224400", "2244", "00", "Königswinter-Oberpleis")]
        [InlineData("022449999999", "2244", "9999999", "Königswinter-Oberpleis")]
        [InlineData("0224500", "2245", "00", "Much")]
        [InlineData("022459999999", "2245", "9999999", "Much")]
        [InlineData("0224600", "2246", "00", "Lohmar Rheinland")]
        [InlineData("022469999999", "2246", "9999999", "Lohmar Rheinland")]
        [InlineData("0224700", "2247", "00", "Neunkirchen-Seelscheid")]
        [InlineData("022479999999", "2247", "9999999", "Neunkirchen-Seelscheid")]
        [InlineData("0224800", "2248", "00", "Hennef-Uckerath")]
        [InlineData("022489999999", "2248", "9999999", "Hennef-Uckerath")]
        [InlineData("0225100", "2251", "00", "Euskirchen")]
        [InlineData("022519999999", "2251", "9999999", "Euskirchen")]
        [InlineData("0225200", "2252", "00", "Zülpich")]
        [InlineData("022529999999", "2252", "9999999", "Zülpich")]
        [InlineData("0225300", "2253", "00", "Bad Münstereifel")]
        [InlineData("022539999999", "2253", "9999999", "Bad Münstereifel")]
        [InlineData("0225400", "2254", "00", "Weilerswist")]
        [InlineData("022549999999", "2254", "9999999", "Weilerswist")]
        [InlineData("0225500", "2255", "00", "Euskirchen-Flamersheim")]
        [InlineData("022559999999", "2255", "9999999", "Euskirchen-Flamersheim")]
        [InlineData("0225600", "2256", "00", "Mechernich-Satzvey")]
        [InlineData("022569999999", "2256", "9999999", "Mechernich-Satzvey")]
        [InlineData("0225700", "2257", "00", "Reckerscheid")]
        [InlineData("022579999999", "2257", "9999999", "Reckerscheid")]
        [InlineData("0226100", "2261", "00", "Gummersbach")]
        [InlineData("022619999999", "2261", "9999999", "Gummersbach")]
        [InlineData("0226200", "2262", "00", "Wiehl")]
        [InlineData("022629999999", "2262", "9999999", "Wiehl")]
        [InlineData("0226300", "2263", "00", "Engelskirchen")]
        [InlineData("022639999999", "2263", "9999999", "Engelskirchen")]
        [InlineData("0226400", "2264", "00", "Marienheide")]
        [InlineData("022649999999", "2264", "9999999", "Marienheide")]
        [InlineData("0226500", "2265", "00", "Reichshof-Eckenhagen")]
        [InlineData("022659999999", "2265", "9999999", "Reichshof-Eckenhagen")]
        [InlineData("0226600", "2266", "00", "Lindlar")]
        [InlineData("022669999999", "2266", "9999999", "Lindlar")]
        [InlineData("0226700", "2267", "00", "Wipperfürth")]
        [InlineData("022679999999", "2267", "9999999", "Wipperfürth")]
        [InlineData("0226800", "2268", "00", "Kürten")]
        [InlineData("022689999999", "2268", "9999999", "Kürten")]
        [InlineData("0226900", "2269", "00", "Kierspe-Rönsahl")]
        [InlineData("022699999999", "2269", "9999999", "Kierspe-Rönsahl")]
        [InlineData("0227100", "2271", "00", "Bergheim Erft")]
        [InlineData("022719999999", "2271", "9999999", "Bergheim Erft")]
        [InlineData("0227200", "2272", "00", "Bedburg Erft")]
        [InlineData("022729999999", "2272", "9999999", "Bedburg Erft")]
        [InlineData("0227300", "2273", "00", "Kerpen-Horrem")]
        [InlineData("022739999999", "2273", "9999999", "Kerpen-Horrem")]
        [InlineData("0227400", "2274", "00", "Elsdorf Rheinland")]
        [InlineData("022749999999", "2274", "9999999", "Elsdorf Rheinland")]
        [InlineData("0227500", "2275", "00", "Kerpen-Buir")]
        [InlineData("022759999999", "2275", "9999999", "Kerpen-Buir")]
        [InlineData("0229100", "2291", "00", "Waldbröl")]
        [InlineData("022919999999", "2291", "9999999", "Waldbröl")]
        [InlineData("0229200", "2292", "00", "Windeck Sieg")]
        [InlineData("022929999999", "2292", "9999999", "Windeck Sieg")]
        [InlineData("0229300", "2293", "00", "Nümbrecht")]
        [InlineData("022939999999", "2293", "9999999", "Nümbrecht")]
        [InlineData("0229400", "2294", "00", "Morsbach Sieg")]
        [InlineData("022949999999", "2294", "9999999", "Morsbach Sieg")]
        [InlineData("0229500", "2295", "00", "Ruppichteroth")]
        [InlineData("022959999999", "2295", "9999999", "Ruppichteroth")]
        [InlineData("0229600", "2296", "00", "Reichshof-Brüchermühle")]
        [InlineData("022969999999", "2296", "9999999", "Reichshof-Brüchermühle")]
        [InlineData("0229700", "2297", "00", "Wildbergerhütte")]
        [InlineData("022979999999", "2297", "9999999", "Wildbergerhütte")]
        public void Parse_Known_GeographicPhoneNumber_2XXX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Germany, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("030000000000", "30", "000000000", "Berlin")]
        [InlineData("030999999999", "30", "999999999", "Berlin")]
        public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Germany, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }
    }
}
