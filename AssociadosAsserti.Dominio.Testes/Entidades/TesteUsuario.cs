using AssociadosAsserti.Dominio.Entidades;
using AssociadosAsserti.Dominio.ObjetoValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssociadosAsserti.Dominio.Testes.Entidades
{
    [TestClass]
    public class TesteUsuario
    {

        //Para Executar um teste, Clique com o direito no teste (Por exemplo DeveCriarEmpresa)
        //Após isto ira abrir uma janela "Gerenciador de Teste", procure o Teste (é o nome da classe) e o execute novamente caso seja necessário
        [TestMethod]
        public void DeveCriarUsuario()
        {
            //deve funcionar
            var usuario = new Usuario("Breno", "brenin", "abc123", true, new DateTime(2019, 04, 05));
        }
        [TestMethod]
        public void NaoDeveCriarUsuario()
        {
            //deve falhar
            var usuario = new Usuario("Breno", "", "abc123", true, new DateTime(2019, 04, 05));
        }

    }
}
