namespace ASPNETServiceLifeTimeSample.Services
{
    public class Singleton : ISingleton
    {
        private readonly Guid _guid;

        public Singleton()
        {
            _guid = Guid.NewGuid();
        }
        public Guid Get()
        {
            return _guid;
        }
    }
}
