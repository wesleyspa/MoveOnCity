using System.Data.Entity;
using MoveOn.Infra.Mappings;
using MoveOn.Domain;
using System;

namespace MoveOn.Infra.DataContext
{
    public class MoveOnDataContext : DbContext
    {
        public MoveOnDataContext() : base("MoveOnCity_Context")
        {
            //Database.SetInitializer<MoveOnDataContext>(new MoveOnDataContextInitializer());
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Atendimento> Atendimentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AtendimentoMap());
            modelBuilder.Configurations.Add(new ServicoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new ContatoMap());
            modelBuilder.Configurations.Add(new ContratoMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Configurations.Add(new VeiculoMap());

            base.OnModelCreating(modelBuilder);
        }
    }

    public class MoveOnDataContextInitializer : DropCreateDatabaseAlways<MoveOnDataContext>
    {
        protected override void Seed(MoveOnDataContext context)
        {
            //-- Novos Contatos
            context.Contatos.Add(new Contato {Id = 1, DDI = "55", DDD = "11", Numero = "943543122", Tipo = "Celular", Info = "Somente ligar em horário comercial" });
            context.Contatos.Add(new Contato {Id = 2, DDI = "55", DDD = "11", Numero = "953553123", Tipo = "Celular", Info = "Sem Infos Adicionais" });
            context.Contatos.Add(new Contato {Id = 3, DDI = "55", DDD = "13", Numero = "63563124", Tipo = "Residencial", Info = "Somente ligar em horário comercial" });
            context.Contatos.Add(new Contato {Id = 4, DDI = "55", DDD = "13", Numero = "973573125", Tipo = "Celular", Info = "Somente ligar em emergência" });
            context.Contatos.Add(new Contato {Id = 5, DDI = "55", DDD = "11", Numero = "83583128", Tipo = "Residencial", Info = "Somente ligar aos fim de semanas" });
            context.Contatos.Add(new Contato {Id = 6, DDI = "55", DDD = "12", Numero = "98765422", Tipo = "Celular" });
            context.Contatos.Add(new Contato {Id = 7, DDI = "55", DDD = "14", Numero = "67892332", Tipo = "Celular", Info = "Sem Infos Adicionais" });
            context.Contatos.Add(new Contato {Id = 8, DDI = "55", DDD = "13", Numero = "54323322", Tipo = "Residencial", Info = "Somente ligar em horário comercial" });
            context.Contatos.Add(new Contato {Id = 9, DDI = "55", DDD = "15", Numero = "65432343", Tipo = "Celular", Info = "Somente ligar em emergência" });
            context.Contatos.Add(new Contato {Id = 10, DDI = "55", DDD = "16", Numero = "23432111", Tipo = "Residencial", Info = "Somente ligar aos fim de semanas" });
            context.SaveChanges();

            //-- Novos Serviços
            context.Servicos.Add(new Servico {Id = 1, Descricao = "Troca de Pneu", InfoAdicional = "Cliente deve possúir o substituto" });
            context.Servicos.Add(new Servico {Id = 2, Descricao = "Água do Motor" });
            context.Servicos.Add(new Servico {Id = 3, Descricao = "Carga de Bateria", InfoAdicional = "Bateria do veículo do Cliente deve estar funcionando, somente descarregada" });
            context.Servicos.Add(new Servico {Id = 4, Descricao = "Pane Seca", InfoAdicional = "Quantidade sulficiente para o posto de combustível mais próximo" });
            context.Servicos.Add(new Servico {Id = 5, Descricao = "Pane Elétrica" });
            context.SaveChanges();

            //-- Novos Contratos
            context.Contratos.Add(new Contrato {Id = 1, VigenciaInicial = DateTime.Now, VigenciaFinal = DateTime.Now });
            context.Contratos.Add(new Contrato {Id = 2, VigenciaInicial = DateTime.Now, VigenciaFinal = DateTime.Now });
            context.Contratos.Add(new Contrato {Id = 3, VigenciaInicial = DateTime.Now, VigenciaFinal = DateTime.Now });
            context.Contratos.Add(new Contrato {Id = 4, VigenciaInicial = DateTime.Now, VigenciaFinal = DateTime.Now });
            context.Contratos.Add(new Contrato {Id = 5, VigenciaInicial = DateTime.Now, VigenciaFinal = DateTime.Now });
            context.SaveChanges();

            //-- Novos Clientes
            context.Clientes.Add(new Cliente {Id = 1, Nome = "José Bonifacio da Silva", DataNascimento = DateTime.Now, CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Casado", Email = "JoseBone@gmail.com", ContratoId = 1 });
            context.Clientes.Add(new Cliente {Id = 2, Nome = "João Cleber Ferreira", DataNascimento = DateTime.Now, CPF_CNPJ = "22222222222", CNH = "123456789", EstadoCivil = "Solteiro", Email = "Joao.C@gmail.com", ContratoId = 2 });
            context.Clientes.Add(new Cliente {Id = 3, Nome = "Maria Joaquina", DataNascimento = DateTime.Now, CPF_CNPJ = "33333333333", CNH = "123456789", EstadoCivil = "Viúva", Email = "MariaB@gmail.com", ContratoId = 3 });
            context.Clientes.Add(new Cliente {Id = 4, Nome = "Berenicie Joana", DataNascimento = DateTime.Now, CPF_CNPJ = "44444444444", CNH = "123456789", EstadoCivil = "Solteiro", Email = "JoaquinaT@gmail.com", ContratoId = 4 });
            context.Clientes.Add(new Cliente {Id = 5, Nome = "Claudete Vazques", DataNascimento = DateTime.Now, CPF_CNPJ = "55555555555", CNH = "123456789", EstadoCivil = "Divorciada", Email = "Claudete@gmail.com", ContratoId = 5 });
            context.SaveChanges();

            //-- Novos Enderecos
            context.Enderecos.Add(new Endereco {Id = 1, Logradouro = "Rua", _Endereco = "Maria da Penha", Numero = "321", CEP = "03232567", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.Enderecos.Add(new Endereco {Id = 2, Logradouro = "Str.", _Endereco = "João Carlos", Numero = "23", CEP = "0398765", Cidade = "Osasco", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.Enderecos.Add(new Endereco {Id = 3, Logradouro = "Avenida", _Endereco = "Boa Vista", Numero = "11", CEP = "2343123", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.Enderecos.Add(new Endereco {Id = 4, Logradouro = "Rua", _Endereco = "XV Novembro", Numero = "93", CEP = "6543456", Cidade = "Taboão da Serra", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.Enderecos.Add(new Endereco {Id = 5, Logradouro = "Avenida", _Endereco = "Paulista", Numero = "32", CEP = "9876543", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.SaveChanges();

            //-- Novos Funcionarios
            context.Funcionarios.Add(new Funcionario {Id = 1, Nome = "Mauricio Augusto Souza", DataNascimento = DateTime.Now, CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Casado", Email = "MauricioA@gmail.com", DataContrato = DateTime.Now });
            context.Funcionarios.Add(new Funcionario {Id = 2, Nome = "Valéria Silva", DataNascimento = DateTime.Now, CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Solteira", Email = "ValeriaS@gmail.com", DataContrato = DateTime.Now });
            context.Funcionarios.Add(new Funcionario {Id = 3, Nome = "Diego Alves", DataNascimento = DateTime.Now, CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Casado", Email = "DiegoA@gmail.com", DataContrato = DateTime.Now });
            context.Funcionarios.Add(new Funcionario {Id = 4, Nome = "Rafael de Castro", DataNascimento = DateTime.Now, CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Solteiro", Email = "RafaelC@gmail.com", DataContrato = DateTime.Now });
            context.Funcionarios.Add(new Funcionario {Id = 5, Nome = "Murilo Maciel", DataNascimento = DateTime.Now, CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Casado", Email = "MuriloM@gmail.com", DataContrato = DateTime.Now });
            context.SaveChanges();

            //-- Novos Status
            context.Status.Add(new Status {Id = 1, Descricao = "Novo Atendimento" });
            context.Status.Add(new Status {Id = 2, Descricao = "Iniciado" });
            context.Status.Add(new Status {Id = 3, Descricao = "Concluído" });
            context.Status.Add(new Status {Id = 4, Descricao = "Cancelado" });
            context.SaveChanges();

            //-- Novos Veículos
            context.Veiculos.Add(new Veiculo {Id = 1, Marca = "Chevrolet", Modelo = "Celta", AnoFabricacao = 2011, Placa = "ABC-3213", Cor = "Prata", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 5 });
            context.Veiculos.Add(new Veiculo {Id = 2, Marca = "Fiat", Modelo = "Uno", AnoFabricacao = 2013, Placa = "DWC-2213", Cor = "Preto", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 5 });
            context.Veiculos.Add(new Veiculo {Id = 3, Marca = "Volkswagem", Modelo = "Gol", AnoFabricacao = 2015, Placa = "EQC-3213", Cor = "Vermelho", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 3 });
            context.Veiculos.Add(new Veiculo {Id = 4, Marca = "Honda", Modelo = "Fit", AnoFabricacao = 2012, Placa = "IDS-0987", Cor = "Prata", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 5 });
            context.Veiculos.Add(new Veiculo {Id = 5, Marca = "Chevrolet", Modelo = "Onix", AnoFabricacao = 2014, Placa = "ODC-3223", Cor = "Branco", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 3 });
            context.Veiculos.Add(new Veiculo {Id = 6, Marca = "Yamaha", Modelo = "Tenere", AnoFabricacao = 2012, Placa = "DDD-0987", Cor = "Azul", Chassi = "ABC02MS3EM99D9", Passageiros = 2, Portas = 0 });
            context.Veiculos.Add(new Veiculo {Id = 7, Marca = "Chevrolet", Modelo = "F10", AnoFabricacao = 2013, Placa = "KDW-3122", Cor = "Branco", Chassi = "ABC02MS3EM99D9", Passageiros = 2, Portas = 2 });
            context.SaveChanges();

            //-- Novos Atendimento
            context.Atendimentos.Add(new Atendimento { Id = 1, ClienteId = 1, VeiculoId = 1, EnderecoId = 1, ServicoId = 1, StatusId = 1, MomAbertura = DateTime.Now });
            context.Atendimentos.Add(new Atendimento { Id = 2, ClienteId = 2, VeiculoId = 2, EnderecoId = 2, ServicoId = 2, StatusId = 2, MomAbertura = DateTime.Now });
            context.Atendimentos.Add(new Atendimento { Id = 3, ClienteId = 3, VeiculoId = 3, EnderecoId = 3, ServicoId = 3, StatusId = 3, MomAbertura = DateTime.Now });
            context.Atendimentos.Add(new Atendimento { Id = 4, ClienteId = 4, VeiculoId = 4, EnderecoId = 4, ServicoId = 1, StatusId = 1, MomAbertura = DateTime.Now });
            context.Atendimentos.Add(new Atendimento { Id = 5, ClienteId = 5, VeiculoId = 5, EnderecoId = 5, ServicoId = 2, StatusId = 2, MomAbertura = DateTime.Now });
            context.SaveChanges();

            //-- Atendimento Iniciados
            context.Atendimentos.Add(new Atendimento { Id = 6, ClienteId = 1, VeiculoId = 1, EnderecoId = 1, ServicoId = 1, StatusId = 1, MomAbertura = DateTime.Now, MomInicio = DateTime.Now});
            context.Atendimentos.Add(new Atendimento { Id = 7, ClienteId = 2, VeiculoId = 2, EnderecoId = 2, ServicoId = 2, StatusId = 2, MomAbertura = DateTime.Now, MomInicio = DateTime.Now});
            context.Atendimentos.Add(new Atendimento { Id = 8, ClienteId = 3, VeiculoId = 3, EnderecoId = 3, ServicoId = 3, StatusId = 3, MomAbertura = DateTime.Now, MomInicio = DateTime.Now});
            context.Atendimentos.Add(new Atendimento { Id = 9, ClienteId = 4, VeiculoId = 4, EnderecoId = 4, ServicoId = 1, StatusId = 1, MomAbertura = DateTime.Now, MomInicio = DateTime.Now});
            context.Atendimentos.Add(new Atendimento { Id = 10, ClienteId = 5, VeiculoId = 5, EnderecoId = 5, ServicoId = 2, StatusId = 2, MomAbertura = DateTime.Now, MomInicio = DateTime.Now});
            context.SaveChanges();

            //-- Atendimento Concluídos
            context.Atendimentos.Add(new Atendimento {Id = 11, ClienteId = 1, VeiculoId = 1, EnderecoId = 1, ServicoId = 1, StatusId = 1, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, InfoConclusao = "A" });
            context.Atendimentos.Add(new Atendimento {Id = 12, ClienteId = 2, VeiculoId = 2, EnderecoId = 2, ServicoId = 2, StatusId = 2, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, InfoConclusao = "B" });
            context.Atendimentos.Add(new Atendimento {Id = 13, ClienteId = 3, VeiculoId = 3, EnderecoId = 3, ServicoId = 3, StatusId = 3, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, InfoConclusao = "C" });
            context.Atendimentos.Add(new Atendimento {Id = 14, ClienteId = 4, VeiculoId = 4, EnderecoId = 4, ServicoId = 1, StatusId = 1, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, InfoConclusao = "D" });
            context.Atendimentos.Add(new Atendimento {Id = 15, ClienteId = 5, VeiculoId = 5, EnderecoId = 5, ServicoId = 2, StatusId = 2, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, InfoConclusao = "E" });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
