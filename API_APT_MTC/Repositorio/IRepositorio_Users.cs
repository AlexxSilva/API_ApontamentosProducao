using API_APT_MTC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_APT_MTC.Repositorio
{
    public interface IRepositorio_Users
    {
        List<APT_Users> GetAllUsuariosAtivos();
    }
}
