using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_APT_MTC.Model
{
    public class APT_Users
    {
        [Key]
        public int User_Id { get; set; }
        public string User_Nome { get; set; }
        public string User_Psw { get; set; }
        public bool User_Ativo { get; set; }
        public DateTime User_DataCadastro { get; set; }
        public bool User_Admin { get; set; }

    }
}
