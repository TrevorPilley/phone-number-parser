namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Australia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AU_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Australia);

    [Theory]
    [InlineData("0220000000", "2", "20000000", "Central East Region (New South Wales, the Australian Capital Territory and parts of northern Victoria)")]
    [InlineData("0299999999", "2", "99999999", "Central East Region (New South Wales, the Australian Capital Territory and parts of northern Victoria)")]
    public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0272000000", "27", "2000000", "Sydney")]
    [InlineData("0279999999", "27", "9999999", "Sydney")]
    [InlineData("0292000000", "29", "2000000", "Sydney")]
    [InlineData("0299999999", "29", "9999999", "Sydney")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0233200000", "233", "200000", "Gosford")]
    [InlineData("0233999999", "233", "999999", "Gosford")]
    [InlineData("0238200000", "238", "200000", "Bowral, Crookwell, Goulburn, Marulan")]
    [InlineData("0238999999", "238", "999999", "Bowral, Crookwell, Goulburn, Marulan")]
    [InlineData("0240200000", "240", "200000", "Newcastle")]
    [InlineData("0240999999", "240", "999999", "Newcastle")]
    [InlineData("0241200000", "241", "200000", "Newcastle")]
    [InlineData("0241999999", "241", "999999", "Newcastle")]
    [InlineData("0242200000", "242", "200000", "Wollongong")]
    [InlineData("0242999999", "242", "999999", "Wollongong")]
    [InlineData("0243200000", "243", "200000", "Gosford")]
    [InlineData("0243999999", "243", "999999", "Gosford")]
    [InlineData("0244200000", "244", "200000", "Moruya, Nowra")]
    [InlineData("0244999999", "244", "999999", "Moruya, Nowra")]
    [InlineData("0245200000", "245", "200000", "Windsor")]
    [InlineData("0245999999", "245", "999999", "Windsor")]
    [InlineData("0246200000", "246", "200000", "Campbelltown")]
    [InlineData("0246999999", "246", "999999", "Campbelltown")]
    [InlineData("0247200000", "247", "200000", "Penrith")]
    [InlineData("0247999999", "247", "999999", "Penrith")]
    [InlineData("0248200000", "248", "200000", "Bowral, Crookwell, Goulburn, Marulan")]
    [InlineData("0248999999", "248", "999999", "Bowral, Crookwell, Goulburn, Marulan")]
    [InlineData("0249200000", "249", "200000", "Newcastle")]
    [InlineData("0249999999", "249", "999999", "Newcastle")]
    [InlineData("0250200000", "250", "200000", "Albury, Corryong")]
    [InlineData("0250999999", "250", "999999", "Albury, Corryong")]
    [InlineData("0251200000", "251", "200000", "Canberra")]
    [InlineData("0251999999", "251", "999999", "Canberra")]
    [InlineData("0252200000", "252", "200000", "Canberra")]
    [InlineData("0252999999", "252", "999999", "Canberra")]
    [InlineData("0253200000", "253", "200000", "Bathurst, Cowra, Lithgow, Mudgee, Orange, Rylstone, Young")]
    [InlineData("0253999999", "253", "999999", "Bathurst, Cowra, Lithgow, Mudgee, Orange, Rylstone, Young")]
    [InlineData("0255200000", "255", "200000", "Kempsey, Lord Howe Island, Muswellbrook, Singleton, Taree, Wauchope")]
    [InlineData("0255999999", "255", "999999", "Kempsey, Lord Howe Island, Muswellbrook, Singleton, Taree, Wauchope")]
    [InlineData("0256200000", "256", "200000", "Casino, Coffs Harbour, Graton, Kyogle, Lismore, Murwillumbah")]
    [InlineData("0256999999", "256", "999999", "Casino, Coffs Harbour, Graton, Kyogle, Lismore, Murwillumbah")]
    [InlineData("0257200000", "257", "200000", "Armidale, Barraba, Gunnedah, Inverell, Moree, Narrabri, Glen Innes, Tamworth")]
    [InlineData("0257999999", "257", "999999", "Armidale, Barraba, Gunnedah, Inverell, Moree, Narrabri, Glen Innes, Tamworth")]
    [InlineData("0258200000", "258", "200000", "Bourke, Condoblin, Coonamble, Dubbo, Forbes, Moree, Nyngan, Parkes, Wellington")]
    [InlineData("0258999999", "258", "999999", "Bourke, Condoblin, Coonamble, Dubbo, Forbes, Moree, Nyngan, Parkes, Wellington")]
    [InlineData("0259200000", "259", "200000", "Adelong, Griffith, Hay, Narrandera, Temora, Wagga Wagga, West Wyalong")]
    [InlineData("0259999999", "259", "999999", "Adelong, Griffith, Hay, Narrandera, Temora, Wagga Wagga, West Wyalong")]
    [InlineData("0260200000", "260", "200000", "Albury, Corryong")]
    [InlineData("0260999999", "260", "999999", "Albury, Corryong")]
    [InlineData("0261200000", "261", "200000", "Canberra")]
    [InlineData("0261999999", "261", "999999", "Canberra")]
    [InlineData("0262200000", "262", "200000", "Canberra")]
    [InlineData("0262999999", "262", "999999", "Canberra")]
    [InlineData("0263200000", "263", "200000", "Bathurst, Cowra, Lithgow, Mudgee, Orange, Rylstone, Young")]
    [InlineData("0263999999", "263", "999999", "Bathurst, Cowra, Lithgow, Mudgee, Orange, Rylstone, Young")]
    [InlineData("0264200000", "264", "200000", "Bega, Cooma")]
    [InlineData("0264999999", "264", "999999", "Bega, Cooma")]
    [InlineData("0265200000", "265", "200000", "Kempsey, Lord Howe Island, Muswellbrook, Singleton, Taree, Wauchope")]
    [InlineData("0265999999", "265", "999999", "Kempsey, Lord Howe Island, Muswellbrook, Singleton, Taree, Wauchope")]
    [InlineData("0266200000", "266", "200000", "Casino, Coffs Harbour, Graton, Kyogle, Lismore, Murwillumbah")]
    [InlineData("0266999999", "266", "999999", "Casino, Coffs Harbour, Graton, Kyogle, Lismore, Murwillumbah")]
    [InlineData("0267200000", "267", "200000", "Armidale, Barraba, Gunnedah, Inverell, Moree, Narrabri, Glen Innes, Tamworth")]
    [InlineData("0267999999", "267", "999999", "Armidale, Barraba, Gunnedah, Inverell, Moree, Narrabri, Glen Innes, Tamworth")]
    [InlineData("0268200000", "268", "200000", "Bourke, Condoblin, Coonamble, Dubbo, Forbes, Moree, Nyngan, Parkes, Wellington")]
    [InlineData("0268999999", "268", "999999", "Bourke, Condoblin, Coonamble, Dubbo, Forbes, Moree, Nyngan, Parkes, Wellington")]
    [InlineData("0269200000", "269", "200000", "Adelong, Griffith, Hay, Narrandera, Temora, Wagga Wagga, West Wyalong")]
    [InlineData("0269999999", "269", "999999", "Adelong, Griffith, Hay, Narrandera, Temora, Wagga Wagga, West Wyalong")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0320000000", "3", "20000000", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0399999999", "3", "99999999", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    public void Parse_Known_GeographicPhoneNumber_3_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0372000000", "37", "2000000", "Melbourne")]
    [InlineData("0379999999", "37", "9999999", "Melbourne")]
    [InlineData("0392000000", "39", "2000000", "Melbourne")]
    [InlineData("0399999999", "39", "9999999", "Melbourne")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0340200000", "340", "200000", "Balranald, Hopetoun, Mildura, Ouyen, Swan Hill")]
    [InlineData("0340999999", "340", "999999", "Balranald, Hopetoun, Mildura, Ouyen, Swan Hill")]
    [InlineData("0341200000", "341", "200000", "Bairnsdale, Morwell, Sale")]
    [InlineData("0341999999", "341", "999999", "Bairnsdale, Morwell, Sale")]
    [InlineData("0342200000", "342", "200000", "Geelong, Colac")]
    [InlineData("0342999999", "342", "999999", "Geelong, Colac")]
    [InlineData("0343200000", "343", "200000", "Ararat, Ballarat, Horsham, Kyneton, Nhill")]
    [InlineData("0343999999", "343", "999999", "Ararat, Ballarat, Horsham, Kyneton, Nhill")]
    [InlineData("0344200000", "344", "200000", "Bendigo, Charlton, Echuca, Kerang, Kyneton, Maryborough")]
    [InlineData("0344999999", "344", "999999", "Bendigo, Charlton, Echuca, Kerang, Kyneton, Maryborough")]
    [InlineData("0345200000", "345", "200000", "Camperdown, Casterton, Edenhope, Hamilton, Portland, Warrnambool")]
    [InlineData("0345999999", "345", "999999", "Camperdown, Casterton, Edenhope, Hamilton, Portland, Warrnambool")]
    [InlineData("0346200000", "346", "200000", "Foster, Korumburra, Warragul")]
    [InlineData("0346999999", "346", "999999", "Foster, Korumburra, Warragul")]
    [InlineData("0347200000", "347", "200000", "Alexandra, Myrtleford, Seymour, Wangaratta, Deniliquin, Numurkah, Shepparton")]
    [InlineData("0347999999", "347", "999999", "Alexandra, Myrtleford, Seymour, Wangaratta, Deniliquin, Numurkah, Shepparton")]
    [InlineData("0348200000", "348", "200000", "Deniliquin, Numurkah, Shepparton")]
    [InlineData("0348999999", "348", "999999", "Deniliquin, Numurkah, Shepparton")]
    [InlineData("0349200000", "349", "200000", "Mornington, Warragul")]
    [InlineData("0349999999", "349", "999999", "Mornington, Warragul")]
    [InlineData("0350200000", "350", "200000", "Balranald, Hopetoun, Mildura, Ouyen, Swan Hill")]
    [InlineData("0350999999", "350", "999999", "Balranald, Hopetoun, Mildura, Ouyen, Swan Hill")]
    [InlineData("0351200000", "351", "200000", "Bairnsdale, Morwell, Sale")]
    [InlineData("0351999999", "351", "999999", "Bairnsdale, Morwell, Sale")]
    [InlineData("0352200000", "352", "200000", "Geelong, Colac")]
    [InlineData("0352999999", "352", "999999", "Geelong, Colac")]
    [InlineData("0353200000", "353", "200000", "Ararat, Ballarat, Horsham, Kyneton, Nhill")]
    [InlineData("0353999999", "353", "999999", "Ararat, Ballarat, Horsham, Kyneton, Nhill")]
    [InlineData("0354200000", "354", "200000", "Bendigo, Charlton, Echuca, Kerang, Kyneton, Maryborough")]
    [InlineData("0354999999", "354", "999999", "Bendigo, Charlton, Echuca, Kerang, Kyneton, Maryborough")]
    [InlineData("0355200000", "355", "200000", "Camperdown, Casterton, Edenhope, Hamilton, Portland, Warrnambool")]
    [InlineData("0355999999", "355", "999999", "Camperdown, Casterton, Edenhope, Hamilton, Portland, Warrnambool")]
    [InlineData("0357200000", "357", "200000", "Alexandra, Myrtleford, Seymour, Wangaratta, Deniliquin, Numurkah, Shepparton")]
    [InlineData("0357999999", "357", "999999", "Alexandra, Myrtleford, Seymour, Wangaratta, Deniliquin, Numurkah, Shepparton")]
    [InlineData("0359200000", "359", "200000", "Mornington, Warragul")]
    [InlineData("0359999999", "359", "999999", "Mornington, Warragul")]
    [InlineData("0361200000", "361", "200000", "Hobart, Geeveston, Oatlands, Ouse")]
    [InlineData("0361999999", "361", "999999", "Hobart, Geeveston, Oatlands, Ouse")]
    [InlineData("0362200000", "362", "200000", "Hobart, Geeveston, Oatlands, Ouse")]
    [InlineData("0362999999", "362", "999999", "Hobart, Geeveston, Oatlands, Ouse")]
    [InlineData("0363200000", "363", "200000", "Deloraine, Flinders Island, Launceston, Scottsdale, St Mary’s")]
    [InlineData("0363999999", "363", "999999", "Deloraine, Flinders Island, Launceston, Scottsdale, St Mary’s")]
    [InlineData("0364200000", "364", "200000", "Burnie, Devonport, King Island, Queenstown, Smithton")]
    [InlineData("0364999999", "364", "999999", "Burnie, Devonport, King Island, Queenstown, Smithton")]
    [InlineData("0365200000", "365", "200000", "Burnie, Devonport, King Island, Queenstown, Smithton")]
    [InlineData("0365999999", "365", "999999", "Burnie, Devonport, King Island, Queenstown, Smithton")]
    [InlineData("0367200000", "367", "200000", "Deloraine, Flinders Island, Launceston, Scottsdale, St Mary’s")]
    [InlineData("0367999999", "367", "999999", "Deloraine, Flinders Island, Launceston, Scottsdale, St Mary’s")]
    public void Parse_Known_GeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0720000000", "7", "20000000", "North East Region (Queensland)")]
    [InlineData("0799999999", "7", "99999999", "North East Region (Queensland)")]
    public void Parse_Known_GeographicPhoneNumber_7_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0722000000", "72", "2000000", "Brisbane Non-metro: Bribie Island, Esk")]
    [InlineData("0729999999", "72", "9999999", "Brisbane Non-metro: Bribie Island, Esk")]
    [InlineData("0732000000", "73", "2000000", "Brisbane Non-metro: Bribie Island, Esk")]
    [InlineData("0739999999", "73", "9999999", "Brisbane Non-metro: Bribie Island, Esk")]
    public void Parse_Known_GeographicPhoneNumber_7X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0740200000", "740", "200000", "Cairns")]
    [InlineData("0740999999", "740", "999999", "Cairns")]
    [InlineData("0741200000", "741", "200000", "Bundaberg, Gayndah, Kingaroy, Maryborough, Murgon")]
    [InlineData("0741999999", "741", "999999", "Bundaberg, Gayndah, Kingaroy, Maryborough, Murgon")]
    [InlineData("0742200000", "742", "200000", "Cairns")]
    [InlineData("0742999999", "742", "999999", "Cairns")]
    [InlineData("0743200000", "743", "200000", "Bundaberg, Gayndah, Kingaroy, Maryborough, Murgon")]
    [InlineData("0743999999", "743", "999999", "Bundaberg, Gayndah, Kingaroy, Maryborough, Murgon")]
    [InlineData("0744200000", "744", "200000", "Cloncurry, Hughenden, Townsville")]
    [InlineData("0744999999", "744", "999999", "Cloncurry, Hughenden, Townsville")]
    [InlineData("0745200000", "745", "200000", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    [InlineData("0745999999", "745", "999999", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    [InlineData("0746200000", "746", "200000", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    [InlineData("0746999999", "746", "999999", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    [InlineData("0747200000", "747", "200000", "Cloncurry, Hughenden, Townsville")]
    [InlineData("0747999999", "747", "999999", "Cloncurry, Hughenden, Townsville")]
    [InlineData("0748200000", "748", "200000", "Biloela, Emerald, Gladstone, Mackay, Rockhampton")]
    [InlineData("0748999999", "748", "999999", "Biloela, Emerald, Gladstone, Mackay, Rockhampton")]
    [InlineData("0749200000", "749", "200000", "Biloela, Emerald, Gladstone, Mackay, Rockhampton")]
    [InlineData("0749999999", "749", "999999", "Biloela, Emerald, Gladstone, Mackay, Rockhampton")]
    [InlineData("0752200000", "752", "200000", "Caboolture, Esk, Gatton, Gympie, Nambour")]
    [InlineData("0752999999", "752", "999999", "Caboolture, Esk, Gatton, Gympie, Nambour")]
    [InlineData("0754200000", "754", "200000", "Caboolture, Esk, Gatton, Gympie, Nambour")]
    [InlineData("0754999999", "754", "999999", "Caboolture, Esk, Gatton, Gympie, Nambour")]
    [InlineData("0755200000", "755", "200000", "Beaudesert, Southport, Tweed Heads")]
    [InlineData("0755999999", "755", "999999", "Beaudesert, Southport, Tweed Heads")]
    [InlineData("0757200000", "757", "200000", "Beaudesert, Southport, Tweed Heads")]
    [InlineData("0757999999", "757", "999999", "Beaudesert, Southport, Tweed Heads")]
    [InlineData("0776200000", "776", "200000", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    [InlineData("0776999999", "776", "999999", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    public void Parse_Known_GeographicPhoneNumber_7XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0820000000", "8", "20000000", "Central and West Region (Western Australia, South Australia, the Northern Territory and parts of New South Wales)")]
    [InlineData("0899999999", "8", "99999999", "Central and West Region (Western Australia, South Australia, the Northern Territory and parts of New South Wales)")]
    public void Parse_Known_GeographicPhoneNumber_8_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0851200000", "851", "200000", "Christmas Island, Cocos (Keeling) Islands, Derby, Great Sandy, Port Hedland")]
    [InlineData("0851999999", "851", "999999", "Christmas Island, Cocos (Keeling) Islands, Derby, Great Sandy, Port Hedland")]
    [InlineData("0852200000", "852", "200000", "Perth")]
    [InlineData("0852999999", "852", "999999", "Perth")]
    [InlineData("0854200000", "854", "200000", "Perth")]
    [InlineData("0854999999", "854", "999999", "Perth")]
    [InlineData("0860200000", "860", "200000", "Bruce Rock, Great Victoria, Kalgoorlie, Merredin")]
    [InlineData("0860999999", "860", "999999", "Bruce Rock, Great Victoria, Kalgoorlie, Merredin")]
    [InlineData("0861200000", "861", "200000", "Perth")]
    [InlineData("0861999999", "861", "999999", "Perth")]
    [InlineData("0865200000", "865", "200000", "Perth")]
    [InlineData("0865999999", "865", "999999", "Perth")]
    [InlineData("0866200000", "866", "200000", "Moora, Northam, Wongan Hills, Wyalkatchem, York")]
    [InlineData("0866999999", "866", "999999", "Moora, Northam, Wongan Hills, Wyalkatchem, York")]
    [InlineData("0867200000", "867", "200000", "Bridgetown, Bunbury, Busselton, Pinjarra")]
    [InlineData("0867999999", "867", "999999", "Bridgetown, Bunbury, Busselton, Pinjarra")]
    [InlineData("0868200000", "868", "200000", "Albany, Katanning, Kondinin, Narrogin, Wagin")]
    [InlineData("0868999999", "868", "999999", "Albany, Katanning, Kondinin, Narrogin, Wagin")]
    [InlineData("0870200000", "870", "200000", "Adelaide")]
    [InlineData("0870999999", "870", "999999", "Adelaide")]
    [InlineData("0874200000", "874", "200000", "Adelaide")]
    [InlineData("0874999999", "874", "999999", "Adelaide")]
    [InlineData("0875200000", "875", "200000", "Berri, Gawler, Kangaroo Island, Malalla, Murray Bridge, Nurioopta, Tailem Bend, Victor Harbour, Waikerie")]
    [InlineData("0875999999", "875", "999999", "Berri, Gawler, Kangaroo Island, Malalla, Murray Bridge, Nurioopta, Tailem Bend, Victor Harbour, Waikerie")]
    [InlineData("0876200000", "876", "200000", "Ceduna, Port Augusta, Port Pirie, Port Lincoln, Gladstone, Peterborough, Cook, Woomera")]
    [InlineData("0876999999", "876", "999999", "Ceduna, Port Augusta, Port Pirie, Port Lincoln, Gladstone, Peterborough, Cook, Woomera")]
    [InlineData("0877200000", "877", "200000", "Bordertown, Mount Gambier, Naracoorte")]
    [InlineData("0877999999", "877", "999999", "Bordertown, Mount Gambier, Naracoorte")]
    [InlineData("0878200000", "878", "200000", "Clare, Kadina, Port Lincoln, Burra, Balaklava, Maitland, Gawler, Yorketown")]
    [InlineData("0878999999", "878", "999999", "Clare, Kadina, Port Lincoln, Burra, Balaklava, Maitland, Gawler, Yorketown")]
    [InlineData("0879200000", "879", "200000", "Alice Springs, Darwin")]
    [InlineData("0879999999", "879", "999999", "Alice Springs, Darwin")]
    [InlineData("0880200000", "880", "200000", "Broken Hill")]
    [InlineData("0880999999", "880", "999999", "Broken Hill")]
    [InlineData("0881200000", "881", "200000", "Adelaide")]
    [InlineData("0881999999", "881", "999999", "Adelaide")]
    [InlineData("0884200000", "884", "200000", "Adelaide")]
    [InlineData("0884999999", "884", "999999", "Adelaide")]
    [InlineData("0885200000", "885", "200000", "Berri, Gawler, Kangaroo Island, Malalla, Murray Bridge, Nurioopta, Tailem Bend, Victor Harbour, Waikerie")]
    [InlineData("0885999999", "885", "999999", "Berri, Gawler, Kangaroo Island, Malalla, Murray Bridge, Nurioopta, Tailem Bend, Victor Harbour, Waikerie")]
    [InlineData("0886200000", "886", "200000", "Ceduna, Port Augusta, Port Pirie, Port Lincoln, Gladstone, Peterborough, Cook, Woomera")]
    [InlineData("0886999999", "886", "999999", "Ceduna, Port Augusta, Port Pirie, Port Lincoln, Gladstone, Peterborough, Cook, Woomera")]
    [InlineData("0887200000", "887", "200000", "Bordertown, Mount Gambier, Naracoorte")]
    [InlineData("0887999999", "887", "999999", "Bordertown, Mount Gambier, Naracoorte")]
    [InlineData("0888200000", "888", "200000", "Clare, Kadina, Port Lincoln, Burra, Balaklava, Maitland, Gawler, Yorketown")]
    [InlineData("0888999999", "888", "999999", "Clare, Kadina, Port Lincoln, Burra, Balaklava, Maitland, Gawler, Yorketown")]
    [InlineData("0889200000", "889", "200000", "Alice Springs, Darwin")]
    [InlineData("0889999999", "889", "999999", "Alice Springs, Darwin")]
    [InlineData("0890200000", "890", "200000", "Bruce Rock, Great Victoria, Kalgoorlie, Merredin")]
    [InlineData("0890999999", "890", "999999", "Bruce Rock, Great Victoria, Kalgoorlie, Merredin")]
    [InlineData("0891200000", "891", "200000", "Christmas Island, Cocos (Keeling) Islands, Derby, Great Sandy, Port Hedland")]
    [InlineData("0891999999", "891", "999999", "Christmas Island, Cocos (Keeling) Islands, Derby, Great Sandy, Port Hedland")]
    [InlineData("0892200000", "892", "200000", "Perth")]
    [InlineData("0892999999", "892", "999999", "Perth")]
    [InlineData("0894200000", "894", "200000", "Perth")]
    [InlineData("0894999999", "894", "999999", "Perth")]
    [InlineData("0895200000", "895", "200000", "Bullsbrook East, Northam, Pinjarra")]
    [InlineData("0895999999", "895", "999999", "Bullsbrook East, Northam, Pinjarra")]
    [InlineData("0896200000", "896", "200000", "Moora, Northam, Wongan Hills, Wyalkatchem, York")]
    [InlineData("0896999999", "896", "999999", "Moora, Northam, Wongan Hills, Wyalkatchem, York")]
    [InlineData("0897200000", "897", "200000", "Bridgetown, Bunbury, Busselton, Pinjarra")]
    [InlineData("0897999999", "897", "999999", "Bridgetown, Bunbury, Busselton, Pinjarra")]
    [InlineData("0898200000", "898", "200000", "Albany, Katanning, Kondinin, Narrogin, Wagin")]
    [InlineData("0898999999", "898", "999999", "Albany, Katanning, Kondinin, Narrogin, Wagin")]
    [InlineData("0899200000", "899", "200000", "Carnamah, Carnarvon, Geraldton, Meekatharra, Morawa, Mullewa, Wongan Hills")]
    [InlineData("0899999999", "899", "999999", "Carnamah, Carnarvon, Geraldton, Meekatharra, Morawa, Mullewa, Wongan Hills")]
    public void Parse_Known_GeographicPhoneNumber_8XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
