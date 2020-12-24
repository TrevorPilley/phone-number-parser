namespace PhoneNumbers.Parsers
{
    internal sealed class AreaCodeInfo
    {
        internal AreaCodeInfo(string areaCode, string? geographicArea) =>
            (AreaCode, GeographicArea) = (areaCode, geographicArea);

        internal string AreaCode { get; }

        internal string? GeographicArea { get; }
    }
}
