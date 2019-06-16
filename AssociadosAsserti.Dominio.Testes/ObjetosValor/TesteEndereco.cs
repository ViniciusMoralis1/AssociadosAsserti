using System;
using AssociadosAsserti.Dominio.ObjetoValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssociadosAsserti.Dominio.Testes
{
    [TestClass]
    public class EnderecoTeste
    {
        [TestMethod]
        public void DeveCriarEndereco()
        {
            var endereco = new Endereco("Logradouro", "111111111", "10" , "SAO PAULO", "SAO PAULO", "CENTRO");
        }

        [TestMethod]
        public void NaoDeveCriarEndereco()
        {
            var endereco = new Endereco("", "", "", "", "", "");
        }


        [TestMethod]
        public void DeveRetornarErroLogradouroNuloOuVazio()
        {
            var end = new Endereco("", "asd", "asd", "asd", "asd", "asd");
            //Assert.IsTrue(end.Valid);
        }

        [TestMethod]
        public void DeveRetornarErroCepNuloOuVazio()
        {
            var end = new Endereco("asd", "", "asd", "asd", "asd", "asd");
            // Assert.IsTrue(end.Valid);
        }

        [TestMethod]
        public void DeveRetornarErroNumeroNuloOuVazio()
        {
            var end = new Endereco("asd", "asd", "", "asd", "asd", "asd");
            // Assert.IsTrue(end.Valid);
        }

        [TestMethod]
        public void DeveRetornarErroEstadoNuloOuVazio()
        {
            var end = new Endereco("asd", "asd", "asd", "", "asd", "asd");
            // Assert.IsTrue(end.Valid);
        }

        [TestMethod]
        public void DeveRetornarErroCidadeNuloOuVazio()
        {
            var end = new Endereco("asd", "asd", "asd", "asd", "", "asd");
            // Assert.IsTrue(end.Valid);
        }

        [TestMethod]
        public void DeveRetornarErroBairroNuloOuVazio()
        {
            var end = new Endereco("asd", "asd", "asd", "asd", "asd", "");
            // Assert.IsTrue(end.Valid);
        }
    }

}
