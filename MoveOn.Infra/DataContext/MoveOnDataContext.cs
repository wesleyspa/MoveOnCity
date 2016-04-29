using System.Data.Entity;
using MoveOn_MVC.Models;

namespace MoveOn.Infra.DataContext
{
    public class MoveOnDataContext : DbContext
    {
        public MoveOnDataContext() : base("MoveOn_City_ConnString")
        {
            Database.SetInitializer<MoveOnDataContext>(new MoveOnDataContextInitializer());

        }

        public DbSet<Atendimento> Atendimentos { get; set; }     
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

    }

    public class MoveOnDataContextInitializer : DropCreateDatabaseIfModelChanges<MoveOnDataContext>
    {
        protected override void Seed(MoveOnDataContext context)
        {
            //context.Atendimentos.Add(new Atendimento { });
            //context.Servico.Add(new Servico { });
            //context.SaveChanges();
        }
    }
}
