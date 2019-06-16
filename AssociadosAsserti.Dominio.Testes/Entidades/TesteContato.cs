
using AssociadosAsserti.Dominio.Entidades;
using AssociadosAsserti.Dominio.ObjetoValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssociadosAsserti.Dominio.Testes.Entidades
{
    [TestClass]
    public class TesteContato
    {

        [TestMethod]
        public void DeveCriarContato()
        {
            var contato = new Contato("Contato", TipoContato.Celular);
        }

        [TestMethod]
        public void NaoDeveCriarContato()
        {
            var contato2 = new Contato("", TipoContato.Site);
        }
    }
}
