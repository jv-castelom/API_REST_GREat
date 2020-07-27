using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_GREat.Model
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é de Preenchimento obrigatório")]
        [StringLength(50, ErrorMessage ="Nome deve conter no mínimo 5 e no máximo 50 caracteres", MinimumLength = 5)]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        [Required(ErrorMessage = "A Filiação materna é de Preenchimento obrigatório")]
        [StringLength(50, ErrorMessage = "Nome da mãe deve conter no mínimo 5 e no máximo 50 caracteres", MinimumLength = 5)]
        public string Filiacao_Mae { get; set; }
        public string Filiacao_Pai { get; set; }
        [RegularExpression(@"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/[12][0-9]{3}$", ErrorMessage ="Data fora do formato dd/mm/aaaa")]
        public string DataNasc { get; set; }
        //[RegularExpression(@"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/[12][0-9]{3}$", ErrorMessage = "Data fora do formato dd/mm/aaaa")]
        public string DataCadastro { get; set; }



    }
}
