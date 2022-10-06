using Microsoft.EntityFrameworkCore;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class TipoCondicionesRepository : ITiposCondiciones
    {
        readonly DatabaseContext _dbContext = new();
        public TipoCondicionesRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<TiposCondiciones> GetTiposCondiciones()
        {
            try
            {
                return _dbContext.TiposCondiciones.ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
