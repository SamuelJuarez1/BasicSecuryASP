using BasicSecuryASP.Models;

namespace BasicSecuryASP.Services
{
    public interface IBeerService
    {
        public Task<List<Beer>> Get();
    }
}
