using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_GREat.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Filiacao_Mae { get; set; }
        public string Filiacao_Pai { get; set; }
        public DateTime Data_Nasc { get; set; }
        public DateTime Data_Cadastro { get; set; }



    }
}
