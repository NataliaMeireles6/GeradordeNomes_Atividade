using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradordeNomes_Atividade.Controllers1
{
    internal class ConsultaPessoa
    {
        public string ConsultarPessoas(int Inicio, int Fim, int qtde)
        {
            string URL = "https://localhost:7120/ListaPessoas?IdadeInicial=";
            String oURLPesquisa = String.Concat( URL.ToString() , Inicio.ToString() , "&IdadeFinal=" , Fim.ToString() ,
                "&QuantasPessoas=" , qtde.ToString() , "");

            HttpClient httpClient = new HttpClient();

            HttpResponseMessage Resposta =
                httpClient.GetAsync(oURLPesquisa).Result;

            string JsonResposta = Resposta.Content.ReadAsStringAsync().Result;

            return JsonResposta;

        }

    }

    
}
