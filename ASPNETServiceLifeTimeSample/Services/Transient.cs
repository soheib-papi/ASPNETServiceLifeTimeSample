namespace ASPNETServiceLifeTimeSample.Services
{
    public class Transient : ITransient
    {
        private readonly Guid _guid;

        public Transient()
        {
            _guid = Guid.NewGuid();
        }
        public Guid Get()
        {
            return _guid;
        }
    }
}
