using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradordeNomes_Atividade.Controllers1
{
    public  class Lista
    {
        public string? nomeList { get; set; }
        public int? codigo { get; set; }
        public string? nome { get; set; }
        public string? sobrenome { get; set; }
        public DateTime datanascimento { get; set; }
        public string? email { get; set; }
        public string? cpf { get; set; }
        public string? fone { get; set; }
        public string? sexo { get; set; }
        public string? estadocivil { get; set; }
        public string? Hobbie { get; set; }
        public int? idade { get; set; }

        public static implicit operator Lista(int v)
        {
            throw new NotImplementedException();
        }
    }


    }

