using AssociadosAsserti.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Infra.Mapeamento
{
    public class EmpresaMap: EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
        {
            ToTable("Empresa");
            HasKey(x => x.Id);
            Property(x => x.Associada);
            Property(x => x.CategoriaProfissional);
            Property(x => x.Ciem);
            Property(x => x.Cnpj).IsRequired().HasMaxLength(14);
            //Property(x => x.Contatos); //Lista
            Property(x => x.DataAtivacaoAssociacao);
            Property(x => x.DataDesativacaoAssociacao);
            Property(x => x.DataPedidoAssociacao);
            Property(x => x.DataReativacaoAssociacao);
            Property(x => x.FaturamentoAnual);
            Property(x => x.NomeFantasia).IsRequired().HasMaxLength(60);
            Property(x => x.QtdeClientes);
            Property(x => x.QtdeEstagiarios);
            Property(x => x.RazaoSocial).IsRequired();
            Property(x => x.RegimeTributario).IsRequired();
            Property(x => x.SindicatoEmpresa);
            //Property(x => x.Socios); //Lista
            Property(x => x.DataCriacao);

            //VO's
            Property(x => x.Endereco.Bairro).HasMaxLength(100);
            Property(x => x.Endereco.Cep).HasMaxLength(20);
            Property(x => x.Endereco.Cidade).HasMaxLength(100);
            Property(x => x.Endereco.Estado).HasMaxLength(2);
            Property(x => x.Endereco.Logradouro).HasMaxLength(150);
            Property(x => x.Endereco.Numero).HasMaxLength(20);
        }
    }
}
