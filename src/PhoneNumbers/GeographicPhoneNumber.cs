namespace PhoneNumbers
{
    public sealed class GeographicPhoneNumber : PhoneNumber
    {
        public GeographicPhoneNumber(
            string callingCode,
            string trunkPrefix,
            string areaCode,
            string localNumber,
            string geographicArea)
            : base(callingCode, trunkPrefix, areaCode, localNumber)
        {
            GeographicArea = geographicArea;
        }

        public string GeographicArea { get; }

        public override PhoneNumberKind PhoneNumberKind =>
            PhoneNumberKind.GeographicPhoneNumber;
    }
}
