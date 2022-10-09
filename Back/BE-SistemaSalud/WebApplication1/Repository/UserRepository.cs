using Microsoft.EntityFrameworkCore;
using WebApplication1.DTO;
using WebApplication1.Interfaces;
using WebApplication1.Models;


namespace WebApplication1.Repository
{
    public class UserRepository : IUsuario
    {
        readonly DatabaseContext _dbContext = new();
        public UserRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Persona>> GetAll()
        {
            try
            {
                return _dbContext.Persona.ToList();
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> PostInfoUser(UserInfo value)
        {
            try
            {
                UserLogin userinfo = new UserLogin
                {
                    Username = value.FirstformGroup.Username,
                    Password = value.FirstformGroup.Password
                };
                Persona infoperson = new Persona
                {
                    Primer_Nombre = value.SecondformGroup.Primer_Nombre,
                    Segundo_Nombre = value.SecondformGroup.Segundo_Nombre,
                    Primer_Apellido = value.SecondformGroup.Primer_Apellido,
                    Segundo_Apellido = value.SecondformGroup.Segundo_Apellido,
                    Identificacion = value.SecondformGroup.Identificacion,
                    Id_Tipo_identificacion = value.SecondformGroup.Id_Tipo_identificacion,
                    Fecha_nacimiento = value.SecondformGroup.Fecha_nacimiento,
                    Id_Genero = value.SecondformGroup.Id_Genero,
                    Correo = value.SecondformGroup.Correo,
                    Parentesco = value.SecondformGroup.Parentesco
                };

                var x = _dbContext.Persona.Add(infoperson);
                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
