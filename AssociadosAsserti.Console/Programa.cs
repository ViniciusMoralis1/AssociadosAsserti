using AssociadosAsserti.Dominio.Entidades;
using AssociadosAsserti.Dominio.ObjetoValor;
using AssociadosAsserti.Dominio.Repositorios;
using AssociadosAsserti.Infra.Context;
using DDDCommerce.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AssociadosAsserti.Console
{
    public class Programa
    {
        static void Main(string[] args)
        {
            AssociadosAsserti_AssociadosDataContext context = new AssociadosAsserti_AssociadosDataContext();

            EmpresaRepository empresaRepository = new EmpresaRepository(context);
            GerarEmpresa(empresaRepository);

            ProfissionalRepository profissionalRepository = new ProfissionalRepository(context);
            GerarProfissional(profissionalRepository);

            SocioRepository socioRepository = new SocioRepository(context);
            GerarSocio(socioRepository);

            UsuarioRepository usuarioRepository = new UsuarioRepository(context);
            GerarUsuario(usuarioRepository);
        }

        public static void GerarEmpresa(IEmpresaRepository empresaRepository)
        {
            var enderecoEmpresa = new Endereco("Logradouro", "17420000", "10", "SAO PAULO", "SÃO PAULO", "CENTRO");

            var empresa = new Empresa("RazaoSocial", "NomeFantasia", "000000000", enderecoEmpresa, true, 10, 10, 10,
             "SindicatoEmpresa", RegimeTributario.LucroReal, "CategoriaProfissional", 10000, 1000, true, new DateTime(2019, 04, 14));

            empresaRepository.Save(empresa);
        }

        public static void GerarProfissional(IProfissionalRepository profissionalRepository)
        {
            var enderecoEmpresa = new Endereco("Logradouro", "17420000", "10", "SAO PAULO", "SÃO PAULO", "CENTRO");

            var empresa = new Empresa("RazaoSocial", "NomeFantasia", "000000000", enderecoEmpresa, true, 10, 10, 10,
             "SindicatoEmpresa", RegimeTributario.LucroPresumido, "CategoriaProfissional", 10000, 1000, true, new DateTime(2019, 04, 14));

            var profissional = new Profissional("Profissional", "123456789", empresa, "lala", "lolo");
            profissionalRepository.Save(profissional);
        }

        public static void GerarSocio(ISocioRepository socioRepository)
        {
            var enderecoEmpresa = new Endereco("Rua A", "12320321", "10", "RJ", "RIO DE JANEIRO", "CENTRO");
            var enderecoSocio = new Endereco("Rua B", "32120321", "05", "SP", "OSASCO", "CENTRO");

            var empresa = new Empresa("RazaoSocial", "NomeFantasia", "000000000", enderecoEmpresa, true, 10, 10, 10,
             "SindicatoEmpresa", RegimeTributario.LucroReal, "CategoriaProfissional", 10000, 1000, true, new DateTime(2019, 04, 14));

            Contato contato1 = new Contato("Teste1", TipoContato.Celular);
            Contato contato2 = new Contato("Teste2", TipoContato.Email);
            Contato contato3 = new Contato("Teste3", TipoContato.Site);

            var socio = new Socio("Socio 1", "1234567899", enderecoSocio, empresa);
            socio.AddContato(contato1);
            socio.AddContato(contato2);
            socio.AddContato(contato3);

            socioRepository.Save(socio);
        }

        public static void GerarUsuario(IUsuarioRepository usuarioRepository)
        {
            var usuario = new Usuario("Breno", "brenin", "abc123", true, new DateTime(2019, 04, 05));

            usuarioRepository.Save(usuario);

        }
    }
}

