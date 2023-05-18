using GeradordeNomes_Atividade.Controllers1;
using GeradordeNomes_Atividade.Objeto1;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace GeradordeNomes_Atividade
{
    public partial class Form1 : Form
    {
        ConsultaPessoa consultaPessoa = new ConsultaPessoa();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gerar();
        }

        private void gerar()

        {
            List<Lista> listas = new List<Lista>();
          
            string pessoas = consultaPessoa.ConsultarPessoas(0, 1, 2000);
            List<Pessoa> myPessoas = JsonConvert.DeserializeObject<List<Pessoa>>(pessoas);
            String nomeList = "de 0 a 1 ano";
            int Contador = 0;

            for (int i = 0; i< myPessoas.Count; i++)
            {

                Lista lista = new Lista();

                lista.codigo = Contador++;
                lista.nomeList = nomeList;
                lista.nome = myPessoas[i].nome;
                lista.sobrenome = myPessoas[i].sobrenome;
                lista.estadocivil = myPessoas[i].estadocivil;
                lista.cpf = myPessoas[i].cpf;
                lista.datanascimento = myPessoas[i].datanascimento;
                lista.email = myPessoas[i].email;
                lista.fone = myPessoas[i].fone;
                lista.sexo = myPessoas[i].sexo;
                lista.Hobbie = myPessoas[i].Hobbie;
                lista.idade = myPessoas[i].idade;
                listas.Add(lista);


            }


            pessoas = consultaPessoa.ConsultarPessoas(5, 17, 2000);
            myPessoas = JsonConvert.DeserializeObject<List<Pessoa>>(pessoas);
            nomeList = "de 5 a 17 anos";
            Contador = 0;

            for (int i = 0; i< myPessoas.Count; i++)
            {
                Lista lista = new Lista();

                lista.codigo = Contador++;
                lista.nomeList = nomeList;
                lista.nome = myPessoas[i].nome;
                lista.sobrenome = myPessoas[i].sobrenome;
                lista.estadocivil = myPessoas[i].estadocivil;
                lista.cpf = myPessoas[i].cpf;
                lista.datanascimento = myPessoas[i].datanascimento;
                lista.email = myPessoas[i].email;
                lista.fone = myPessoas[i].fone;
                lista.sexo = myPessoas[i].sexo;
                lista.Hobbie = myPessoas[i].Hobbie;
                lista.idade = myPessoas[i].idade;
                listas.Add(lista);


            }
            

            pessoas = consultaPessoa.ConsultarPessoas(18, 29, 2000);
            myPessoas = JsonConvert.DeserializeObject<List<Pessoa>>(pessoas);
            nomeList = "de 18 a 29 anos";
            Contador = 0;

            for (int i = 0; i < myPessoas.Count; i++)
            {
                Lista lista = new Lista();


                lista.codigo = Contador++;
                lista.nomeList = nomeList;
                lista.nome = myPessoas[i].nome;
                lista.sobrenome = myPessoas[i].sobrenome;
                lista.estadocivil = myPessoas[i].estadocivil;
                lista.cpf = myPessoas[i].cpf;
                lista.datanascimento = myPessoas[i].datanascimento;
                lista.email = myPessoas[i].email;
                lista.fone = myPessoas[i].fone;
                lista.sexo = myPessoas[i].sexo;
                lista.Hobbie = myPessoas[i].Hobbie;
                lista.idade = myPessoas[i].idade;
                listas.Add(lista);

            }


            pessoas = consultaPessoa.ConsultarPessoas(30, 50, 2000);
            myPessoas = JsonConvert.DeserializeObject<List<Pessoa>>(pessoas);
            nomeList = "de 30 a 50 anos";
            Contador = 0;

            for (int i = 0; i < myPessoas.Count; i++)
            {
                Lista lista = new Lista();

                lista.codigo = Contador++;
                lista.nomeList = nomeList;
                lista.nome = myPessoas[i].nome;
                lista.sobrenome = myPessoas[i].sobrenome;
                lista.estadocivil = myPessoas[i].estadocivil;
                lista.cpf = myPessoas[i].cpf;
                lista.datanascimento = myPessoas[i].datanascimento;
                lista.email = myPessoas[i].email;
                lista.fone = myPessoas[i].fone;
                lista.sexo = myPessoas[i].sexo;
                lista.Hobbie = myPessoas[i].Hobbie;
                lista.idade = myPessoas[i].idade;
                listas.Add(lista);
            }

            

            pessoas = consultaPessoa.ConsultarPessoas(51, 90, 2000);
            myPessoas = JsonConvert.DeserializeObject<List<Pessoa>>(pessoas);
            nomeList = "de 51 a 90 anos";
            Contador = 0;

            for (int i = 0; i < myPessoas.Count; i++)
            {
                Lista lista = new Lista();

                lista.codigo = Contador++;
                lista.nomeList = nomeList;
                lista.nome = myPessoas[i].nome;
                lista.estadocivil = myPessoas[i].estadocivil;
                lista.sobrenome = myPessoas[i].sobrenome;
                lista.cpf = myPessoas[i].cpf;
                lista.datanascimento = myPessoas[i].datanascimento;
                lista.email = myPessoas[i].email;
                lista.fone = myPessoas[i].fone;
                lista.sexo = myPessoas[i].sexo;
                lista.Hobbie = myPessoas[i].Hobbie;
                lista.idade = myPessoas[i].idade;
                listas.Add(lista);
            

            }

            dataGridView1.DataSource = listas;
            dataGridView1.Refresh();

            


        }
    }
}
