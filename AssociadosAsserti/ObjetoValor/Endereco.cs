using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Dominio.ObjetoValor
{
   public class Endereco
    {
        public Endereco(string logradouro, string cep, string numero, string estado, string cidade, string bairro)
        {
            Logradouro = logradouro;
            Cep = cep;
            Numero = numero;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;

            if (String.IsNullOrEmpty(Logradouro)){
                throw new Exception("Logradouro nao pode ser Nulo ou Vazio");
            }

            if (String.IsNullOrEmpty(numero))
            {
                throw new Exception("Numero nao pode ser Nulo ou Vazio");
            }

            if (String.IsNullOrEmpty(estado))
            {
                throw new Exception("Estado nao pode ser Nulo ou Vazio");
            }

            if (String.IsNullOrEmpty(cidade))
            {
                throw new Exception("Cidade nao pode ser Nulo ou Vazio");
            }

            if (String.IsNullOrEmpty(bairro))
            {
                throw new Exception("Bairro nao pode ser Nulo ou Vazio");
            }
        }

        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
    }
}
