namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Australia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AU_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Australia);

    [Theory]
    [InlineData("0220000000", "2", "20000000", "Central East Region (New South Wales, the Australian Capital Territory and parts of northern Victoria)")]
    [InlineData("0232999999", "2", "32999999", "Central East Region (New South Wales, the Australian Capital Territory and parts of northern Victoria)")]
    [InlineData("0233000000", "2", "33000000", "Gosford")]
    [InlineData("0233999999", "2", "33999999", "Gosford")]
    [InlineData("0234000000", "2", "34000000", "Central East Region (New South Wales, the Australian Capital Territory and parts of northern Victoria)")]
    [InlineData("0237999999", "2", "37999999", "Central East Region (New South Wales, the Australian Capital Territory and parts of northern Victoria)")]
    [InlineData("0238000000", "2", "38000000", "Bowral, Crookwell, Goulburn, Marulan")]
    [InlineData("0238999999", "2", "38999999", "Bowral, Crookwell, Goulburn, Marulan")]
    [InlineData("0239000000", "2", "39000000", "Central East Region (New South Wales, the Australian Capital Territory and parts of northern Victoria)")]
    [InlineData("0239999999", "2", "39999999", "Central East Region (New South Wales, the Australian Capital Territory and parts of northern Victoria)")]
    [InlineData("0240000000", "2", "40000000", "Newcastle")]
    [InlineData("0241999999", "2", "41999999", "Newcastle")]
    [InlineData("0242000000", "2", "42000000", "Wollongong")]
    [InlineData("0242999999", "2", "42999999", "Wollongong")]
    [InlineData("0243000000", "2", "43000000", "Gosford")]
    [InlineData("0243999999", "2", "43999999", "Gosford")]
    [InlineData("0244000000", "2", "44000000", "Moruya, Nowra")]
    [InlineData("0244999999", "2", "44999999", "Moruya, Nowra")]
    [InlineData("0245000000", "2", "45000000", "Windsor")]
    [InlineData("0245999999", "2", "45999999", "Windsor")]
    [InlineData("0246000000", "2", "46000000", "Campbelltown")]
    [InlineData("0246999999", "2", "46999999", "Campbelltown")]
    [InlineData("0247000000", "2", "47000000", "Penrith")]
    [InlineData("0247999999", "2", "47999999", "Penrith")]
    [InlineData("0248000000", "2", "48000000", "Bowral, Crookwell, Goulburn, Marulan")]
    [InlineData("0248999999", "2", "48999999", "Bowral, Crookwell, Goulburn, Marulan")]
    [InlineData("0249000000", "2", "49000000", "Newcastle")]
    [InlineData("0249999999", "2", "49999999", "Newcastle")]
    [InlineData("0250000000", "2", "50000000", "Albury, Corryong")]
    [InlineData("0250999999", "2", "50999999", "Albury, Corryong")]
    [InlineData("0251000000", "2", "51000000", "Canberra")]
    [InlineData("0252999999", "2", "52999999", "Canberra")]
    [InlineData("0253000000", "2", "53000000", "Bathurst, Cowra, Lithgow, Mudgee, Orange, Rylstone, Young")]
    [InlineData("0253999999", "2", "53999999", "Bathurst, Cowra, Lithgow, Mudgee, Orange, Rylstone, Young")]
    [InlineData("0254000000", "2", "54000000", "Central East Region (New South Wales, the Australian Capital Territory and parts of northern Victoria)")]
    [InlineData("0254999999", "2", "54999999", "Central East Region (New South Wales, the Australian Capital Territory and parts of northern Victoria)")]
    [InlineData("0255000000", "2", "55000000", "Kempsey, Lord Howe Island, Muswellbrook, Singleton, Taree, Wauchope")]
    [InlineData("0255999999", "2", "55999999", "Kempsey, Lord Howe Island, Muswellbrook, Singleton, Taree, Wauchope")]
    [InlineData("0256000000", "2", "56000000", "Casino, Coffs Harbour, Graton, Kyogle, Lismore, Murwillumbah")]
    [InlineData("0256999999", "2", "56999999", "Casino, Coffs Harbour, Graton, Kyogle, Lismore, Murwillumbah")]
    [InlineData("0257000000", "2", "57000000", "Armidale, Barraba, Gunnedah, Inverell, Moree, Narrabri, Glen Innes, Tamworth")]
    [InlineData("0257999999", "2", "57999999", "Armidale, Barraba, Gunnedah, Inverell, Moree, Narrabri, Glen Innes, Tamworth")]
    [InlineData("0258000000", "2", "58000000", "Bourke, Condoblin, Coonamble, Dubbo, Forbes, Moree, Nyngan, Parkes, Wellington")]
    [InlineData("0258999999", "2", "58999999", "Bourke, Condoblin, Coonamble, Dubbo, Forbes, Moree, Nyngan, Parkes, Wellington")]
    [InlineData("0259000000", "2", "59000000", "Adelong, Griffith, Hay, Narrandera, Temora, Wagga Wagga, West Wyalong")]
    [InlineData("0259999999", "2", "59999999", "Adelong, Griffith, Hay, Narrandera, Temora, Wagga Wagga, West Wyalong")]
    [InlineData("0260000000", "2", "60000000", "Albury, Corryong")]
    [InlineData("0260999999", "2", "60999999", "Albury, Corryong")]
    [InlineData("0261000000", "2", "61000000", "Canberra")]
    [InlineData("0262999999", "2", "62999999", "Canberra")]
    [InlineData("0263000000", "2", "63000000", "Bathurst, Cowra, Lithgow, Mudgee, Orange, Rylstone, Young")]
    [InlineData("0263999999", "2", "63999999", "Bathurst, Cowra, Lithgow, Mudgee, Orange, Rylstone, Young")]
    [InlineData("0264000000", "2", "64000000", "Bega, Cooma")]
    [InlineData("0264999999", "2", "64999999", "Bega, Cooma")]
    [InlineData("0265000000", "2", "65000000", "Kempsey, Lord Howe Island, Muswellbrook, Singleton, Taree, Wauchope")]
    [InlineData("0265999999", "2", "65999999", "Kempsey, Lord Howe Island, Muswellbrook, Singleton, Taree, Wauchope")]
    [InlineData("0266000000", "2", "66000000", "Casino, Coffs Harbour, Graton, Kyogle, Lismore, Murwillumbah")]
    [InlineData("0266999999", "2", "66999999", "Casino, Coffs Harbour, Graton, Kyogle, Lismore, Murwillumbah")]
    [InlineData("0267000000", "2", "67000000", "Armidale, Barraba, Gunnedah, Inverell, Moree, Narrabri, Glen Innes, Tamworth")]
    [InlineData("0267999999", "2", "67999999", "Armidale, Barraba, Gunnedah, Inverell, Moree, Narrabri, Glen Innes, Tamworth")]
    [InlineData("0268000000", "2", "68000000", "Bourke, Condoblin, Coonamble, Dubbo, Forbes, Moree, Nyngan, Parkes, Wellington")]
    [InlineData("0268999999", "2", "68999999", "Bourke, Condoblin, Coonamble, Dubbo, Forbes, Moree, Nyngan, Parkes, Wellington")]
    [InlineData("0269000000", "2", "69000000", "Adelong, Griffith, Hay, Narrandera, Temora, Wagga Wagga, West Wyalong")]
    [InlineData("0269999999", "2", "69999999", "Adelong, Griffith, Hay, Narrandera, Temora, Wagga Wagga, West Wyalong")]
    [InlineData("0270000000", "2", "70000000", "Sydney")]
    [InlineData("0299999999", "2", "99999999", "Sydney")]
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
    [InlineData("0320000000", "3", "20000000", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0339999999", "3", "39999999", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0340000000", "3", "40000000", "Balranald, Hopetoun, Mildura, Ouyen, Swan Hill")]
    [InlineData("0340999999", "3", "40999999", "Balranald, Hopetoun, Mildura, Ouyen, Swan Hill")]
    [InlineData("0341000000", "3", "41000000", "Bairnsdale, Morwell, Sale")]
    [InlineData("0341999999", "3", "41999999", "Bairnsdale, Morwell, Sale")]
    [InlineData("0342000000", "3", "42000000", "Geelong, Colac")]
    [InlineData("0342999999", "3", "42999999", "Geelong, Colac")]
    [InlineData("0343000000", "3", "43000000", "Ararat, Ballarat, Horsham, Kyneton, Nhill")]
    [InlineData("0343999999", "3", "43999999", "Ararat, Ballarat, Horsham, Kyneton, Nhill")]
    [InlineData("0344000000", "3", "44000000", "Bendigo, Charlton, Echuca, Kerang, Kyneton, Maryborough")]
    [InlineData("0344999999", "3", "44999999", "Bendigo, Charlton, Echuca, Kerang, Kyneton, Maryborough")]
    [InlineData("0345000000", "3", "45000000", "Camperdown, Casterton, Edenhope, Hamilton, Portland, Warrnambool")]
    [InlineData("0345999999", "3", "45999999", "Camperdown, Casterton, Edenhope, Hamilton, Portland, Warrnambool")]
    [InlineData("0346000000", "3", "46000000", "Foster, Korumburra, Warragul")]
    [InlineData("0346000000", "3", "46000000", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0346999999", "3", "46999999", "Foster, Korumburra, Warragul")]
    [InlineData("0346999999", "3", "46999999", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0347000000", "3", "47000000", "Alexandra, Myrtleford, Seymour, Wangaratta, Deniliquin, Numurkah, Shepparton")]
    [InlineData("0347999999", "3", "47999999", "Alexandra, Myrtleford, Seymour, Wangaratta, Deniliquin, Numurkah, Shepparton")]
    [InlineData("0348000000", "3", "48000000", "Deniliquin, Numurkah, Shepparton")]
    [InlineData("0348000000", "3", "48000000", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0348999999", "3", "48999999", "Deniliquin, Numurkah, Shepparton")]
    [InlineData("0348999999", "3", "48999999", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0349000000", "3", "49000000", "Mornington, Warragul")]
    [InlineData("0349999999", "3", "49999999", "Mornington, Warragul")]
    [InlineData("0350000000", "3", "50000000", "Balranald, Hopetoun, Mildura, Ouyen, Swan Hill")]
    [InlineData("0350999999", "3", "50999999", "Balranald, Hopetoun, Mildura, Ouyen, Swan Hill")]
    [InlineData("0351000000", "3", "51000000", "Bairnsdale, Morwell, Sale")]
    [InlineData("0351999999", "3", "51999999", "Bairnsdale, Morwell, Sale")]
    [InlineData("0352000000", "3", "52000000", "Geelong, Colac")]
    [InlineData("0352999999", "3", "52999999", "Geelong, Colac")]
    [InlineData("0353000000", "3", "53000000", "Ararat, Ballarat, Horsham, Kyneton, Nhill")]
    [InlineData("0353999999", "3", "53999999", "Ararat, Ballarat, Horsham, Kyneton, Nhill")]
    [InlineData("0354000000", "3", "54000000", "Bendigo, Charlton, Echuca, Kerang, Kyneton, Maryborough")]
    [InlineData("0354999999", "3", "54999999", "Bendigo, Charlton, Echuca, Kerang, Kyneton, Maryborough")]
    [InlineData("0355000000", "3", "55000000", "Camperdown, Casterton, Edenhope, Hamilton, Portland, Warrnambool")]
    [InlineData("0355999999", "3", "55999999", "Camperdown, Casterton, Edenhope, Hamilton, Portland, Warrnambool")]
    [InlineData("0357000000", "3", "57000000", "Alexandra, Myrtleford, Seymour, Wangaratta, Deniliquin, Numurkah, Shepparton")]
    [InlineData("0357999999", "3", "57999999", "Alexandra, Myrtleford, Seymour, Wangaratta, Deniliquin, Numurkah, Shepparton")]
    [InlineData("0359000000", "3", "59000000", "Mornington, Warragul")]
    [InlineData("0359999999", "3", "59999999", "Mornington, Warragul")]
    [InlineData("0360000000", "3", "60000000", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0360999999", "3", "60999999", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0361000000", "3", "61000000", "Hobart, Geeveston, Oatlands, Ouse")]
    [InlineData("0362999999", "3", "62999999", "Hobart, Geeveston, Oatlands, Ouse")]
    [InlineData("0363000000", "3", "63000000", "Deloraine, Flinders Island, Launceston, Scottsdale, St Mary’s")]
    [InlineData("0363999999", "3", "63999999", "Deloraine, Flinders Island, Launceston, Scottsdale, St Mary’s")]
    [InlineData("0364000000", "3", "64000000", "Burnie, Devonport, King Island, Queenstown, Smithton")]
    [InlineData("0365999999", "3", "65999999", "Burnie, Devonport, King Island, Queenstown, Smithton")]
    [InlineData("0366000000", "3", "66000000", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0366999999", "3", "66999999", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0367000000", "3", "67000000", "Deloraine, Flinders Island, Launceston, Scottsdale, St Mary’s")]
    [InlineData("0367999999", "3", "67999999", "Deloraine, Flinders Island, Launceston, Scottsdale, St Mary’s")]
    [InlineData("0368000000", "3", "68000000", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0369999999", "3", "69999999", "South East Region (Tasmania, most of Victoria and parts of southern New South Wales)")]
    [InlineData("0370000000", "3", "70000000", "Melbourne")]
    [InlineData("0399999999", "3", "99999999", "Melbourne")]
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
    [InlineData("0720000000", "7", "20000000", "Brisbane, Bribie Island, Esk")]
    [InlineData("0739999999", "7", "39999999", "Brisbane, Bribie Island, Esk")]
    [InlineData("0740000000", "7", "40000000", "Cairns")]
    [InlineData("0740999999", "7", "40999999", "Cairns")]
    [InlineData("0741000000", "7", "41000000", "Bundaberg, Gayndah, Kingaroy, Maryborough, Murgon")]
    [InlineData("0741999999", "7", "41999999", "Bundaberg, Gayndah, Kingaroy, Maryborough, Murgon")]
    [InlineData("0742000000", "7", "42000000", "Cairns")]
    [InlineData("0742999999", "7", "42999999", "Cairns")]
    [InlineData("0743000000", "7", "43000000", "Bundaberg, Gayndah, Kingaroy, Maryborough, Murgon")]
    [InlineData("0743999999", "7", "43999999", "Bundaberg, Gayndah, Kingaroy, Maryborough, Murgon")]
    [InlineData("0744000000", "7", "44000000", "Cloncurry, Hughenden, Townsville")]
    [InlineData("0744999999", "7", "44999999", "Cloncurry, Hughenden, Townsville")]
    [InlineData("0745000000", "7", "45000000", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    [InlineData("0746999999", "7", "46999999", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    [InlineData("0747000000", "7", "47000000", "Cloncurry, Hughenden, Townsville")]
    [InlineData("0747999999", "7", "47999999", "Cloncurry, Hughenden, Townsville")]
    [InlineData("0748000000", "7", "48000000", "Biloela, Emerald, Gladstone, Mackay, Rockhampton")]
    [InlineData("0749999999", "7", "49999999", "Biloela, Emerald, Gladstone, Mackay, Rockhampton")]
    [InlineData("0750000000", "7", "50000000", "North East Region (Queensland)")]
    [InlineData("0751999999", "7", "51999999", "North East Region (Queensland)")]
    [InlineData("0752000000", "7", "52000000", "Caboolture, Esk, Gatton, Gympie, Nambour")]
    [InlineData("0754999999", "7", "54999999", "Caboolture, Esk, Gatton, Gympie, Nambour")]
    [InlineData("0755000000", "7", "55000000", "Beaudesert, Southport, Tweed Heads")]
    [InlineData("0757999999", "7", "57999999", "Beaudesert, Southport, Tweed Heads")]
    [InlineData("0758000000", "7", "58000000", "North East Region (Queensland)")]
    [InlineData("0775999999", "7", "75999999", "North East Region (Queensland)")]
    [InlineData("0776000000", "7", "76000000", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    [InlineData("0776999999", "7", "76999999", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    [InlineData("0777000000", "7", "77000000", "North East Region (Queensland)")]
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
    [InlineData("0820000000", "8", "20000000", "Central and West Region (Western Australia, South Australia, the Northern Territory and parts of New South Wales)")]
    [InlineData("0850999999", "8", "50999999", "Central and West Region (Western Australia, South Australia, the Northern Territory and parts of New South Wales)")]
    [InlineData("0851000000", "8", "51000000", "Christmas Island, Cocos (Keeling) Islands, Derby, Great Sandy, Port Hedland")]
    [InlineData("0851999999", "8", "51999999", "Christmas Island, Cocos (Keeling) Islands, Derby, Great Sandy, Port Hedland")]
    [InlineData("0852000000", "8", "52000000", "Perth")]
    [InlineData("0854999999", "8", "54999999", "Perth")]
    [InlineData("0855000000", "8", "55000000", "Central and West Region (Western Australia, South Australia, the Northern Territory and parts of New South Wales)")]
    [InlineData("0859999999", "8", "59999999", "Central and West Region (Western Australia, South Australia, the Northern Territory and parts of New South Wales)")]
    [InlineData("0860000000", "8", "60000000", "Bruce Rock, Great Victoria, Kalgoorlie, Merredin")]
    [InlineData("0860999999", "8", "60999999", "Bruce Rock, Great Victoria, Kalgoorlie, Merredin")]
    [InlineData("0861000000", "8", "61000000", "Perth")]
    [InlineData("0865999999", "8", "65999999", "Perth")]
    [InlineData("0866000000", "8", "66000000", "Moora, Northam, Wongan Hills, Wyalkatchem, York")]
    [InlineData("0866999999", "8", "66999999", "Moora, Northam, Wongan Hills, Wyalkatchem, York")]
    [InlineData("0867000000", "8", "67000000", "Bridgetown, Bunbury, Busselton, Pinjarra")]
    [InlineData("0867999999", "8", "67999999", "Bridgetown, Bunbury, Busselton, Pinjarra")]
    [InlineData("0868000000", "8", "68000000", "Albany, Katanning, Kondinin, Narrogin, Wagin")]
    [InlineData("0868999999", "8", "68999999", "Albany, Katanning, Kondinin, Narrogin, Wagin")]
    [InlineData("0869000000", "8", "69000000", "Central and West Region (Western Australia, South Australia, the Northern Territory and parts of New South Wales)")]
    [InlineData("0869999999", "8", "69999999", "Central and West Region (Western Australia, South Australia, the Northern Territory and parts of New South Wales)")]
    [InlineData("0870000000", "8", "70000000", "Adelaide")]
    [InlineData("0874999999", "8", "74999999", "Adelaide")]
    [InlineData("0875000000", "8", "75000000", "Berri, Gawler, Kangaroo Island, Malalla, Murray Bridge, Nurioopta, Tailem Bend, Victor Harbour, Waikerie")]
    [InlineData("0875999999", "8", "75999999", "Berri, Gawler, Kangaroo Island, Malalla, Murray Bridge, Nurioopta, Tailem Bend, Victor Harbour, Waikerie")]
    [InlineData("0876000000", "8", "76000000", "Ceduna, Port Augusta, Port Pirie, Port Lincoln, Gladstone, Peterborough, Cook, Woomera")]
    [InlineData("0876999999", "8", "76999999", "Ceduna, Port Augusta, Port Pirie, Port Lincoln, Gladstone, Peterborough, Cook, Woomera")]
    [InlineData("0877000000", "8", "77000000", "Bordertown, Mount Gambier, Naracoorte")]
    [InlineData("0877999999", "8", "77999999", "Bordertown, Mount Gambier, Naracoorte")]
    [InlineData("0878000000", "8", "78000000", "Clare, Kadina, Port Lincoln, Burra, Balaklava, Maitland, Gawler, Yorketown")]
    [InlineData("0878999999", "8", "78999999", "Clare, Kadina, Port Lincoln, Burra, Balaklava, Maitland, Gawler, Yorketown")]
    [InlineData("0879000000", "8", "79000000", "Alice Springs, Darwin")]
    [InlineData("0879999999", "8", "79999999", "Alice Springs, Darwin")]
    [InlineData("0880000000", "8", "80000000", "Broken Hill")]
    [InlineData("0880999999", "8", "80999999", "Broken Hill")]
    [InlineData("0881000000", "8", "81000000", "Adelaide")]
    [InlineData("0884999999", "8", "84999999", "Adelaide")]
    [InlineData("0885000000", "8", "85000000", "Berri, Gawler, Kangaroo Island, Malalla, Murray Bridge, Nurioopta, Tailem Bend, Victor Harbour, Waikerie")]
    [InlineData("0885999999", "8", "85999999", "Berri, Gawler, Kangaroo Island, Malalla, Murray Bridge, Nurioopta, Tailem Bend, Victor Harbour, Waikerie")]
    [InlineData("0886000000", "8", "86000000", "Ceduna, Port Augusta, Port Pirie, Port Lincoln, Gladstone, Peterborough, Cook, Woomera")]
    [InlineData("0886999999", "8", "86999999", "Ceduna, Port Augusta, Port Pirie, Port Lincoln, Gladstone, Peterborough, Cook, Woomera")]
    [InlineData("0887000000", "8", "87000000", "Bordertown, Mount Gambier, Naracoorte")]
    [InlineData("0887999999", "8", "87999999", "Bordertown, Mount Gambier, Naracoorte")]
    [InlineData("0888000000", "8", "88000000", "Clare, Kadina, Port Lincoln, Burra, Balaklava, Maitland, Gawler, Yorketown")]
    [InlineData("0888999999", "8", "88999999", "Clare, Kadina, Port Lincoln, Burra, Balaklava, Maitland, Gawler, Yorketown")]
    [InlineData("0889000000", "8", "89000000", "Alice Springs, Darwin")]
    [InlineData("0889999999", "8", "89999999", "Alice Springs, Darwin")]
    [InlineData("0890000000", "8", "90000000", "Bruce Rock, Great Victoria, Kalgoorlie, Merredin")]
    [InlineData("0890999999", "8", "90999999", "Bruce Rock, Great Victoria, Kalgoorlie, Merredin")]
    [InlineData("0891000000", "8", "91000000", "Christmas Island, Cocos (Keeling) Islands, Derby, Great Sandy, Port Hedland")]
    [InlineData("0891999999", "8", "91999999", "Christmas Island, Cocos (Keeling) Islands, Derby, Great Sandy, Port Hedland")]
    [InlineData("0892000000", "8", "92000000", "Perth")]
    [InlineData("0894999999", "8", "94999999", "Perth")]
    [InlineData("0895000000", "8", "95000000", "Bullsbrook East, Northam, Pinjarra")]
    [InlineData("0895999999", "8", "95999999", "Bullsbrook East, Northam, Pinjarra")]
    [InlineData("0896000000", "8", "96000000", "Moora, Northam, Wongan Hills, Wyalkatchem, York")]
    [InlineData("0896999999", "8", "96999999", "Moora, Northam, Wongan Hills, Wyalkatchem, York")]
    [InlineData("0897000000", "8", "97000000", "Bridgetown, Bunbury, Busselton, Pinjarra")]
    [InlineData("0897999999", "8", "97999999", "Bridgetown, Bunbury, Busselton, Pinjarra")]
    [InlineData("0898000000", "8", "98000000", "Albany, Katanning, Kondinin, Narrogin, Wagin")]
    [InlineData("0898999999", "8", "98999999", "Albany, Katanning, Kondinin, Narrogin, Wagin")]
    [InlineData("0899000000", "8", "99000000", "Carnamah, Carnarvon, Geraldton, Meekatharra, Morawa, Mullewa, Wongan Hills")]
    [InlineData("0899999999", "8", "99999999", "Carnamah, Carnarvon, Geraldton, Meekatharra, Morawa, Mullewa, Wongan Hills")]
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
}
