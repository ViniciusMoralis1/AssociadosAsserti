using AssociadosAsserti.Dominio.Entidades;
using AssociadosAsserti.Dominio.ObjetoValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssociadosAsserti.Dominio.Testes.Entidades
{
    [TestClass]
    public class TesteSocio
    {

        //Para Executar um teste, Clique com o direito no teste (Por exemplo DeveCriarEmpresa)
        //Após isto ira abrir uma janela "Gerenciador de Teste", procure o Teste (é o nome da classe) e o execute novamente caso seja necessário
        [TestMethod]
        public void DeveCriarSocio()
        {
            var enderecoEmpresa = new Endereco("Rua A", "12320321", "10", "RJ", "RIO DE JANEIRO", "CENTRO");
            var enderecoSocio = new Endereco("Rua B", "32120321", "05", "SP", "OSASCO", "CENTRO");

            var empresa = new Empresa("Flavio Fernandes",
                "JUKERA",
                "123321",
                enderecoEmpresa,
                true,
                10,
                10,
                10,
                "Sindicato 1",
                RegimeTributario.LucroPresumido,
                "Cartegoria Profissional",
                30000,
                1000,
                true,
                new DateTime(2019, 03, 20)
                );

            Contato contato1 = new Contato("Teste1", TipoContato.Celular);
            Contato contato2 = new Contato("Teste2", TipoContato.Email);
            Contato contato3 = new Contato("Teste3", TipoContato.Site);

            var socio = new Socio("Socio 1", "1234567899", enderecoSocio, empresa);
            socio.AddContato(contato1);
            socio.AddContato(contato2);
            socio.AddContato(contato3);

        }

        //Criar testes de falhas
        [TestMethod]
        public void NaoDeveCriarSocio()
        {
            var enderecoEmpresa = new Endereco("Rua A", "12320321", "10", "RJ", "RIO DE JANEIRO", "CENTRO");
            var enderecoSocio = new Endereco("Rua B", "32120321", "05", "SP", "OSASCO", "CENTRO");

            var empresa = new Empresa("Flavio Fernandes",
                "JUKERA",
                "123321",
                enderecoEmpresa,
                true,
                10,
                10,
                10,
                "Sindicato 1",
                RegimeTributario.LucroPresumido,
                "Cartegoria Profissional",
                30000,
                1000,
                true,
                new DateTime(2019, 03, 20)
                );

            Contato contato1 = new Contato("Teste1", TipoContato.Celular);
            Contato contato2 = new Contato("Teste2", TipoContato.Email);
            Contato contato3 = new Contato("Teste3", TipoContato.Site);

            var socio = new Socio("Socio 1", "1234567899", null, empresa);
            socio.AddContato(contato1);
            socio.AddContato(contato2);
            socio.AddContato(contato3);

        }
    }
}