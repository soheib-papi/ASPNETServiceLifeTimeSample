namespace ASPNETServiceLifeTimeSample.Services
{
    public class GuidProvider : IGuidProvider
    {
        public Guid GetGuid()
        {
            return Guid.NewGuid();
        }
    }
}
