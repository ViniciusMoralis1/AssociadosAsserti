
using AssociadosAsserti.Dominio.Entidades;
using AssociadosAsserti.Dominio.ObjetoValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssociadosAsserti.Dominio.Testes.Entidades
{
    [TestClass]
    public class TesteProfissional
    {

        [TestMethod]
        public void DeveCriarProfissional()
        {
            var enderecoEmpresa = new Endereco("Logradouro", "17420000", "10", "SAO PAULO", "SÃO PAULO", "CENTRO");

            var empresa = new Empresa("RazaoSocial", "NomeFantasia", "000000000", enderecoEmpresa, true, 10, 10, 10,
             "SindicatoEmpresa", RegimeTributario.LucroPresumido, "CategoriaProfissional", 10000, 1000, true, new DateTime(2019, 04, 14));

            var profissional = new Profissional("Profissional","123456789", empresa, "lala", "lolo");
        }

        [TestMethod]
        public void NaoDeveCriarProfissional()
        {
            var enderecoEmpresa = new Endereco("Logradouro", "17420000", "10", "SAO PAULO", "SÃO PAULO", "CENTRO");

            var empresa = new Empresa("RazaoSocial", "NomeFantasia", "000000000", enderecoEmpresa, true, 10, 10, 10,
             "SindicatoEmpresa", RegimeTributario.LucroReal,"CategoriaProfissional", 10000, 1000, true, new DateTime(2019, 04, 14));

            var profissional = new Profissional("", "123456789", empresa, "lala", "lolo");
        }

    }
}
