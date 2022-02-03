using API_APT_MTC.Data;
using API_APT_MTC.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_APT_MTC.Repositorio
{
    public class Repositorio_Users : IRepositorio_Users
    {

        private readonly  DataContext _context;

        public Repositorio_Users(DataContext context)
        {
            this._context = context;
        }

        public  List<APT_Users> GetAllUsuariosAtivos()
        {
            return _context.APT_Users.ToList();
        }

        //Consulta Assincrona
        //public async Task<APT_Users[]> GetAllUsuariosAtivosAsync()
        //{
        //    IQueryable<APT_Users> query = _context.APT_Users.Where(inat => inat.User_Ativo == true);
        //    return await query.ToArrayAsync();
        //}
    }
}
