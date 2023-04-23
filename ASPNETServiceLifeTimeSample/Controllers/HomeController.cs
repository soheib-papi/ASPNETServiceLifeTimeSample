using ASPNETServiceLifeTimeSample.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETServiceLifeTimeSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingleton _singleton1;
        private readonly IScoped _scoped1;
        private readonly ITransient _transient1;

        private readonly ISingleton _singleton2;
        private readonly IScoped _scoped2;
        private readonly ITransient _transient2;

        private readonly ISingleton _singleton3;
        private readonly IScoped _scoped3;
        private readonly ITransient _transient3;

        public HomeController(
            ISingleton singleton1,
            IScoped scoped1,
            ITransient transient1,
            ISingleton singleton2,
            IScoped scoped2,
            ITransient transient2,
            ISingleton singleton3,
            IScoped scoped3,
            ITransient transient3)
        {
            _singleton1 = singleton1;
            _scoped1 = scoped1;
            _transient1 = transient1;

            _singleton2 = singleton2;
            _scoped2 = scoped2;
            _transient2 = transient2;

            _singleton3 = singleton3;
            _scoped3 = scoped3;
            _transient3 = transient3;
        }

        [Route("Home/GetSingleton")]
        public List<Guid> GetSingleton()
        {
            List<Guid> result = new List<Guid>();
            var value1 = _singleton1.Get();
            var value2 = _singleton2.Get();
            var value3 = _singleton3.Get();
            result.Add(value1);
            result.Add(value2);
            result.Add(value3);
            return result;
        }

        [Route("Home/GetScoped")]
        public List<Guid> GetScoped()
        {
            List<Guid> result = new List<Guid>();
            var value1 = _scoped1.Get();
            var value2 = _scoped2.Get();
            var value3 = _scoped3.Get();
            result.Add(value1);
            result.Add(value2);
            result.Add(value3);
            return result;
        }

        [Route("Home/GetTransient")]
        public List<Guid> GetTransient()
        {
            List<Guid> result = new List<Guid>();
            var value1 = _transient1.Get();
            var value2 = _transient2.Get();
            var value3 = _transient3.Get();
            result.Add(value1);
            result.Add(value2);
            result.Add(value3);
            return result;
        }
    }
}
