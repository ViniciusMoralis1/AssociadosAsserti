using AssociadosAsserti.Compartilhado.Entidades;
using AssociadosAsserti.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;

namespace AssociadosAsserti.Dominio.Entidades
{
    public class Empresa : Entidade
    {
        protected Empresa()
        {

        }

        //Construtor de Empresa, toda vez que usar new Empresa(); passar todos os paramentros
        public Empresa(string razaoSocial, string nomeFantasia, string cnpj, Endereco endereco, bool ciem, int qtdeFuncionariosCeletistas, int qtdeEstagiarios, int qtdeFuncionariosPj, string sindicatoEmpresa, RegimeTributario regime , string categoriaProfissional, float faturamentoAnual, int qtdeClientes, bool associada, DateTime dataPedidoAssociacao)
        {

            //Criar logica da Quantidade se for null recebe 0

            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
            Endereco = endereco;
            Ciem = ciem;
            QtdeFuncionariosCeletistas = qtdeFuncionariosCeletistas;
            QtdeEstagiarios = qtdeEstagiarios;
            QtdeFuncionariosPj = qtdeFuncionariosPj;
            SindicatoEmpresa = sindicatoEmpresa;
            RegimeTributario = regime;
            CategoriaProfissional = categoriaProfissional;
            FaturamentoAnual = faturamentoAnual;
            QtdeClientes = qtdeClientes;
            DataPedidoAssociacao = dataPedidoAssociacao;
            Associada = associada;

            //DataDesativacaoAssociacao = dataDesativacaoAssociacao;
            //DataReativacaoAssociacao = dataReativacaoAssociacao;

            //Faz as validações, todas precisam ser verdadeiras 
            if (String.IsNullOrEmpty(RazaoSocial) || (String.IsNullOrEmpty(NomeFantasia) || (String.IsNullOrEmpty(Cnpj)))) {
                throw new Exception("Dados Inválidos, algum campo foi passado vazio");
            }
                       
            if (qtdeFuncionariosCeletistas < 0 || qtdeEstagiarios < 0 || qtdeFuncionariosPj < 0 || qtdeClientes < 0)
            {
                throw new Exception("Opss... Quantidade de Celetistas, Estagiarios, Pj's ou Clientes! Não pode ser menor que ZERO");
            }

        }

        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }

        //É padrao, pesquisar tabela
        // public string CnaePrimario { get; set; }
        // public string CnarSecundario { get; set; }


        public RegimeTributario RegimeTributario { get; set; }

        public Endereco Endereco { get; set; }
        public Boolean Ciem { get; set; }   //True para Empresa que estao no CIEM
        public int QtdeFuncionariosCeletistas { get; set; }
        public int QtdeEstagiarios { get; set; }
        public int QtdeFuncionariosPj { get; set; }
        public string SindicatoEmpresa { get; set; }
        public string CategoriaProfissional { get; set; }
        public float FaturamentoAnual { get; set; }
        public int QtdeClientes { get; set; }

        public Boolean Associada { get; set; } //Criar Logica, ao setar a empresa como associada (Associada = true;)
                                               //Pegar a data atual e incluir DataAtivacao


        public DateTime DataPedidoAssociacao { get; set; }
        public DateTime DataAtivacaoAssociacao { get; set; }
        public DateTime DataDesativacaoAssociacao { get; set; }
        public DateTime DataReativacaoAssociacao { get; set; }


        //Analisar esses Atributos
        // public DateTime DataSuspensaoBoletos { get; set; }
        // public DateTime DataReativacaoBoletos { get; set; }

      
        //Listas
        public List<Contato> Contatos { get; set; }
        public List<Socio> Socios { get; set; }


        //Métodos de adição as Listas
        public void AddContato(Contato contato)
        {
            //Se a lista Contatos for nula, é criado uma nova Lista e logo após é chamdo o metodo de adicao
            //Incluindo um objeto Contato dentro da lista
            Contatos = Contatos ?? new List<Contato>();
            Contatos.Add(contato);
        }

        public void AddSocios(Socio socio)
        {
            //Se a lista Socios for nula, é criado uma nova Lista e logo após é chamdo o metodo de adicao
            //Incluindo um objeto Socio dentro da lista
            Socios = Socios ?? new List<Socio>();
            Socios.Add(socio);
        }

        public void AssociarEmpresa()
        {
            if (Associada)      //Se a empresa já estiver como associada, ira desativar a associação e preencher a data de desativacao
            {
                Associada = false;
                DataDesativacaoAssociacao = DateTime.Now;
            }
            //Caso contrário ira setar a empresa como associada e preencher a data de Ativacao
            Associada = true;
            DataAtivacaoAssociacao = DateTime.Now;
        }

        public void ReativarAssociacao()
        {
            if(Associada == true)
            {
                throw new Exception("Empresa já associada");
            }
            Associada = true;
            DataReativacaoAssociacao = DateTime.Now;
        }
    }
}
