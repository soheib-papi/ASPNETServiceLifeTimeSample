namespace ASPNETServiceLifeTimeSample.Services
{
    public class Scoped : IScoped
    {
        private readonly Guid _guid;

        public Scoped()
        {
            _guid = Guid.NewGuid();
        }
        public Guid Get()
        {
            return _guid;
        }
    }
}
