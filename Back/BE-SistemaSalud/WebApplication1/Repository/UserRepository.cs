using Microsoft.EntityFrameworkCore;
using System;
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
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> PostInfoUser(UserInfo value)
        {
            try
            {
                Login userinfo = new Login
                {
                    Usuario = value.FirstformGroup.Username,
                    Contraseña = value.FirstformGroup.Password,
                    Activo = true,
                    Ultimo_logueo = DateTime.Now
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
                
                var state = _dbContext.Persona.Add(infoperson);
                var resultrequest = await _dbContext.SaveChangesAsync();
                var iduser = state.Entity.Id_Persona;
                var resultaddlogin = await addlogin(iduser, userinfo);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private async Task<bool> addlogin(int iduser, Login userinfo)
        {
            try
            {
                userinfo.Id_Persona = iduser;
                var state = _dbContext.Usuario.Add(userinfo);
                var resultrequest = await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
