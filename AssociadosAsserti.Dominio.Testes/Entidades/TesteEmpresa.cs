using AssociadosAsserti.Dominio.Entidades;
using AssociadosAsserti.Dominio.ObjetoValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssociadosAsserti.Dominio.Testes.Entidades
{
    [TestClass]
    public class TesteEmpresa
    {

        //Para Executar um teste, Clique com o direito no teste (Por exemplo DeveCriarEmpresa)
        //Após isto ira abrir uma janela "Gerenciador de Teste", procure o Teste (é o nome da classe) e o execute novamente caso seja necessário
        [TestMethod]
        public void NaoDeveCriarEmpresa()
        {
            var enderecoEmpresa = new Endereco("Rua A", "12320321", "10", "RJ", "RIO DE JANEIRO" ,"CENTRO");

            //Omitindo o NomeFantasia da Empresa forçando o Teste Falhar
            var empresa = new Empresa("Flavio Fernandes", "", "123321", enderecoEmpresa, true, 10, 10, 10, "Sindicato 1", RegimeTributario.LucroPresumido ,"Categoria Profissional", 30000, 1000, true, new DateTime(2019, 03, 20));
        }

       [TestMethod]
        public void DeveCriarEmpresa()
        {
           var enderecoEmpresa = new Endereco("Logradouro", "17420000", "10", "SAO PAULO", "SÃO PAULO" , "CENTRO");

           var empresa = new Empresa("RazaoSocial", "NomeFantasia", "000000000", enderecoEmpresa, true, 10, 10, 10,
            "SindicatoEmpresa", RegimeTributario.LucroReal, "CategoriaProfissional", 10000, 1000, true, new DateTime(2019, 04, 14));
        }

        //Esse Teste deve ser alterado de acordo com a validações de Contato
        [TestMethod]
        public void DeveCriarEmpresaComContato()
        {
            var enderecoEmpresa = new Endereco("Rua A", "12320321", "10", "RJ", "RIO DE JANEIRO", "CENTRO");
           
            var contatoEmpresa = new Contato("Contato1", TipoContato.Site); //Cria o Contato

            var empresa = new Empresa("RazaoSocial", "NomeFantasia", "000000000", enderecoEmpresa, true, 10, 10, 10,
           "SindicatoEmpresa", RegimeTributario.SimplesNacional, "CategoriaProfissional", 10000, 1000, false, new DateTime(2019, 04, 14));
            empresa.AddContato(contatoEmpresa);

            empresa.AssociarEmpresa();

            Console.WriteLine(empresa);

        }

        //Esse Teste deve ser alterado de acordo com a validações de Contato e Socio
        [TestMethod]
        public void DeveCriarEmpresaComSocio()
        {
            var enderecoEmpresa = new Endereco("Rua A", "12320321", "10", "RJ", "RIO DE JANEIRO", "CENTRO");
            var enderecoEmpresa2 = new Endereco("Rua B", "321321321", "50", "RJ", "RIO DE JANEIRO", "CENTRO");

            var contatoEmpresa = new Contato("Contato1", TipoContato.Site); //Cria o Contato

            var empresaSocio = new Empresa("RazaoSocial1", "NomeFantasia1", "111111111", enderecoEmpresa2, true, 50, 50, 50,
           "SindicatoEmpresa1", RegimeTributario.LucroReal, "CategoriaProfissional1", 10000, 1000, true, new DateTime(2019, 04, 14));
            

            var socio = new Socio("Socio 1", "12312345677", enderecoEmpresa2, empresaSocio);

            var empresa = new Empresa("RazaoSocial", "NomeFantasia", "000000000", enderecoEmpresa, true, 10, 10, 10,
           "SindicatoEmpresa", RegimeTributario.LucroPresumido, "CategoriaProfissional", 10000, 1000, true, new DateTime(2019, 04, 14));

            empresa.AddContato(contatoEmpresa);
            empresa.AddSocios(socio);
        }

        [TestMethod]
        public void NaoDeveCriarEmpresaPorNumeroFuncionario()
        {
            var enderecoEmpresa = new Endereco("Rua A", "12320321", "10", "RJ", "RIO DE JANEIRO", "CENTRO");
            var enderecoEmpresa2 = new Endereco("Rua B", "321321321", "50", "RJ", "RIO DE JANEIRO", "CENTRO");

            var contatoEmpresa = new Contato("Contato1", TipoContato.Site); //Cria o Contato

            var empresaSocio = new Empresa("RazaoSocial1", "NomeFantasia1", "111111111", enderecoEmpresa2, true, 50, 50, 50,
           "SindicatoEmpresa1", RegimeTributario.LucroReal, "CategoriaProfissional1", 10000, 1000, true, new DateTime(2019, 04, 14));


            var socio = new Socio("Socio 1", "12312345677", enderecoEmpresa2, empresaSocio);

            var empresa = new Empresa("RazaoSocial", "NomeFantasia", "000000000", enderecoEmpresa, true, -1, 10, 10,
           "SindicatoEmpresa", RegimeTributario.LucroPresumido,"CategoriaProfissional", 10000, 1000, true, new DateTime(2019, 04, 14));

            empresa.AddContato(contatoEmpresa);
            empresa.AddSocios(socio);
        }
    }
}
