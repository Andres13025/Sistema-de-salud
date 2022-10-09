using WebApplication1.DTO;
using WebApplication1.Models;


namespace WebApplication1.Interfaces
{
    public interface IUsuario
    {
        public Task<List<Persona>> GetAll();
        public Task<bool> PostInfoUser(UserInfo value);
    }
}
