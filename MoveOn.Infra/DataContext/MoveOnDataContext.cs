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
            Database.SetInitializer<MoveOnDataContext>(new MoveOnDataContextInitializer());
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
            modelBuilder.Configurations.Add(new ServicoMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Configurations.Add(new VeiculoMap());

            base.OnModelCreating(modelBuilder);
        }
    }

    public class MoveOnDataContextInitializer : DropCreateDatabaseIfModelChanges<MoveOnDataContext>
    {
        protected override void Seed(MoveOnDataContext context)
        {
            //-- Novos Clientes
            context.Clientes.Add(new Cliente { Nome = "José Bonifacio da Silva", DataNascimento = DateTime.Now, CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Casado", Email = "JoseBone@gmail.com", ContratoId = 1, VeiculoId = 1, ContatoId = 1 });
            context.Clientes.Add(new Cliente { Nome = "João Cleber Ferreira", DataNascimento = DateTime.Now, CPF_CNPJ = "22222222222", CNH = "123456789", EstadoCivil = "Solteiro", Email = "Joao.C@gmail.com", ContratoId = 2, VeiculoId = 2, ContatoId = 2 });
            context.Clientes.Add(new Cliente { Nome = "Maria Joaquina", DataNascimento = DateTime.Now, CPF_CNPJ = "33333333333", CNH = "123456789", EstadoCivil = "Viúva", Email = "MariaB@gmail.com", ContratoId = 3, VeiculoId = 3, ContatoId = 3 });
            context.Clientes.Add(new Cliente { Nome = "Berenicie Joana", DataNascimento = DateTime.Now, CPF_CNPJ = "44444444444", CNH = "123456789", EstadoCivil = "Solteiro", Email = "JoaquinaT@gmail.com", ContratoId = 4, VeiculoId = 4, ContatoId = 4 });
            context.Clientes.Add(new Cliente { Nome = "Claudete Vazques", DataNascimento = DateTime.Now, CPF_CNPJ = "55555555555", CNH = "123456789", EstadoCivil = "Divorciada", Email = "Claudete@gmail.com", ContratoId = 5, VeiculoId = 5, ContatoId = 5 });

            //-- Novos Contatos
            context.Contatos.Add(new Contato { DDI = "55", DDD = "11", Numero = 943543122, Tipo = "Celular", Info = "Somente ligar em horário comercial", ClienteId = 1 });
            context.Contatos.Add(new Contato { DDI = "55", DDD = "11", Numero = 953553123, Tipo = "Celular", Info = "Sem Infos Adicionais", ClienteId = 2 });
            context.Contatos.Add(new Contato { DDI = "55", DDD = "13", Numero = 63563124, Tipo = "Residencial", Info = "Somente ligar em horário comercial", ClienteId = 3 });
            context.Contatos.Add(new Contato { DDI = "55", DDD = "13", Numero = 973573125, Tipo = "Celular", Info = "Somente ligar em emergência", ClienteId = 4 });
            context.Contatos.Add(new Contato { DDI = "55", DDD = "11", Numero = 83583128, Tipo = "Residencial", Info = "Somente ligar aos fim de semanas", ClienteId = 5 });
            context.Contatos.Add(new Contato { DDI = "55", DDD = "12", Numero = 98765422, Tipo = "Celular", ClienteId = 6 });
            context.Contatos.Add(new Contato { DDI = "55", DDD = "14", Numero = 67892332, Tipo = "Celular", Info = "Sem Infos Adicionais", ClienteId = 7 });
            context.Contatos.Add(new Contato { DDI = "55", DDD = "13", Numero = 54323322, Tipo = "Residencial", Info = "Somente ligar em horário comercial", ClienteId = 8 });
            context.Contatos.Add(new Contato { DDI = "55", DDD = "15", Numero = 65432343, Tipo = "Celular", Info = "Somente ligar em emergência", ClienteId = 9 });
            context.Contatos.Add(new Contato { DDI = "55", DDD = "16", Numero = 23432111, Tipo = "Residencial", Info = "Somente ligar aos fim de semanas", ClienteId = 10 });

            //-- Novos Contratos
            context.Contratos.Add(new Contrato { VigenciaInicial = DateTime.Now, ClienteId = 1, ServicoId = 1 });
            context.Contratos.Add(new Contrato { VigenciaInicial = DateTime.Now, ClienteId = 2, ServicoId = 2 });
            context.Contratos.Add(new Contrato { VigenciaInicial = DateTime.Now, ClienteId = 3, ServicoId = 3 });
            context.Contratos.Add(new Contrato { VigenciaInicial = DateTime.Now, ClienteId = 4, ServicoId = 4 });
            context.Contratos.Add(new Contrato { VigenciaInicial = DateTime.Now, ClienteId = 5, ServicoId = 5 });

            //-- Novos Enderecos
            context.Enderecos.Add(new Endereco { Logradouro = "Rua", _Endereco = "Maria da Penha", Numero = "321", CEP = "03232567", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322, ClienteId = 1 });
            context.Enderecos.Add(new Endereco { Logradouro = "Str.", _Endereco = "João Carlos", Numero = "23", CEP = "0398765", Cidade = "Osasco", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322, ClienteId = 2 });
            context.Enderecos.Add(new Endereco { Logradouro = "Avenida", _Endereco = "Boa Vista", Numero = "11", CEP = "2343123", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322, ClienteId = 3 });
            context.Enderecos.Add(new Endereco { Logradouro = "Rua", _Endereco = "XV Novembro", Numero = "93", CEP = "6543456", Cidade = "Taboão da Serra", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322, ClienteId = 4 });
            context.Enderecos.Add(new Endereco { Logradouro = "Avenida", _Endereco = "Paulista", Numero = "32", CEP = "9876543", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322, ClienteId = 5 });

            //-- Novos Funcionarios
            context.Funcionarios.Add(new Funcionario { Nome = "Mauricio Augusto Souza", DataNascimento = DateTime.Now, CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Casado", Email = "MauricioA@gmail.com", ContatoId = 6 });
            context.Funcionarios.Add(new Funcionario { Nome = "Valéria Silva", DataNascimento = DateTime.Now, CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Solteira", Email = "ValeriaS@gmail.com", ContatoId = 7 });
            context.Funcionarios.Add(new Funcionario { Nome = "Diego Alves", DataNascimento = DateTime.Now, CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Casado", Email = "DiegoA@gmail.com", ContatoId = 8 });
            context.Funcionarios.Add(new Funcionario { Nome = "Rafael de Castro", DataNascimento = DateTime.Now, CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Solteiro", Email = "RafaelC@gmail.com", ContatoId = 9 });
            context.Funcionarios.Add(new Funcionario { Nome = "Murilo Maciel", DataNascimento = DateTime.Now, CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Casado", Email = "MuriloM@gmail.com", ContatoId = 10 });

            //-- Novos Serviços
            context.Servicos.Add(new Servico { Descricao = "Troca de Pneu", InfoAdicional = "Cliente deve possúir o substituto" });
            context.Servicos.Add(new Servico { Descricao = "Água do Motor" });
            context.Servicos.Add(new Servico { Descricao = "Carga de Bateria", InfoAdicional = "Bateria do veículo do Cliente deve estar funcionando, somente descarregada" });
            context.Servicos.Add(new Servico { Descricao = "Pane Seca", InfoAdicional = "Quantidade sulficiente para o posto de combustível mais próximo"});
            context.Servicos.Add(new Servico { Descricao = "Pane Elétrica" });

            //-- Novos Status
            context.Status.Add(new Status { Descricao = "Novo Atendimento" });
            context.Status.Add(new Status { Descricao = "Iniciado" });
            context.Status.Add(new Status { Descricao = "Concluído" });
            context.Status.Add(new Status { Descricao = "Cancelado" });

            //-- Novos Veículos
            context.Veiculos.Add(new Veiculo { Marca = "Chevrolet", Modelo = "Celta", AnoFabricacao = 2011, Placa = "ABC-3213", Cor = "Prata", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 5 });
            context.Veiculos.Add(new Veiculo { Marca = "Fiat", Modelo = "Uno", AnoFabricacao = 2013, Placa = "DWC-2213", Cor = "Preto", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 5 });
            context.Veiculos.Add(new Veiculo { Marca = "Volkswagem", Modelo = "Gol", AnoFabricacao = 2015, Placa = "EQC-3213", Cor = "Vermelho", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 3 });
            context.Veiculos.Add(new Veiculo { Marca = "Honda", Modelo = "Fit", AnoFabricacao = 2012, Placa = "IDS-0987", Cor = "Prata", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 5 });
            context.Veiculos.Add(new Veiculo { Marca = "Chevrolet", Modelo = "Onix", AnoFabricacao = 2014, Placa = "ODC-3223", Cor = "Branco", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 3 });
            context.Veiculos.Add(new Veiculo { Marca = "Yamaha", Modelo = "Tenere", AnoFabricacao = 2012, Placa = "DDD-0987", Cor = "Azul", Chassi = "ABC02MS3EM99D9", Passageiros = 2, Portas = 0 });
            context.Veiculos.Add(new Veiculo { Marca = "Chevrolet", Modelo = "F10", AnoFabricacao = 2013, Placa = "KDW-3122", Cor = "Branco", Chassi = "ABC02MS3EM99D9", Passageiros = 2, Portas = 2 });

            //-- Novos Atendimento
            context.Atendimentos.Add(new Atendimento { ClienteId = 1, VeiculoId = 1, EnderecoId = 1, ServicoId = 1, StatusId = 1, MomAbertura = DateTime.Now });
            context.Atendimentos.Add(new Atendimento { ClienteId = 2, VeiculoId = 2, EnderecoId = 2, ServicoId = 2, StatusId = 2, MomAbertura = DateTime.Now });
            context.Atendimentos.Add(new Atendimento { ClienteId = 3, VeiculoId = 3, EnderecoId = 3, ServicoId = 3, StatusId = 3, MomAbertura = DateTime.Now });
            context.Atendimentos.Add(new Atendimento { ClienteId = 4, VeiculoId = 4, EnderecoId = 4, ServicoId = 1, StatusId = 1, MomAbertura = DateTime.Now });
            context.Atendimentos.Add(new Atendimento { ClienteId = 5, VeiculoId = 5, EnderecoId = 5, ServicoId = 2, StatusId = 2, MomAbertura = DateTime.Now });

            //-- Atendimento Iniciados
            context.Atendimentos.Add(new Atendimento { ClienteId = 1, VeiculoId = 1, EnderecoId = 1, ServicoId = 1, StatusId = 1, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, ResponsavelId = 1, VeiculoIdResp = 6 });
            context.Atendimentos.Add(new Atendimento { ClienteId = 2, VeiculoId = 2, EnderecoId = 2, ServicoId = 2, StatusId = 2, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, ResponsavelId = 2, VeiculoIdResp = 7 });
            context.Atendimentos.Add(new Atendimento { ClienteId = 3, VeiculoId = 3, EnderecoId = 3, ServicoId = 3, StatusId = 3, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, ResponsavelId = 1, VeiculoIdResp = 6 });
            context.Atendimentos.Add(new Atendimento { ClienteId = 4, VeiculoId = 4, EnderecoId = 4, ServicoId = 1, StatusId = 1, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, ResponsavelId = 2, VeiculoIdResp = 7 });
            context.Atendimentos.Add(new Atendimento { ClienteId = 5, VeiculoId = 5, EnderecoId = 5, ServicoId = 2, StatusId = 2, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, ResponsavelId = 1, VeiculoIdResp = 6 });

            //-- Atendimento Concluídos
            context.Atendimentos.Add(new Atendimento { ClienteId = 1, VeiculoId = 1, EnderecoId = 1, ServicoId = 1, StatusId = 1, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, ResponsavelId = 1, VeiculoIdResp = 6 });
            context.Atendimentos.Add(new Atendimento { ClienteId = 2, VeiculoId = 2, EnderecoId = 2, ServicoId = 2, StatusId = 2, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, ResponsavelId = 2, VeiculoIdResp = 7 });
            context.Atendimentos.Add(new Atendimento { ClienteId = 3, VeiculoId = 3, EnderecoId = 3, ServicoId = 3, StatusId = 3, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, ResponsavelId = 1, VeiculoIdResp = 6 });
            context.Atendimentos.Add(new Atendimento { ClienteId = 4, VeiculoId = 4, EnderecoId = 4, ServicoId = 1, StatusId = 1, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, ResponsavelId = 2, VeiculoIdResp = 7 });
            context.Atendimentos.Add(new Atendimento { ClienteId = 5, VeiculoId = 5, EnderecoId = 5, ServicoId = 2, StatusId = 2, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, ResponsavelId = 1, VeiculoIdResp = 6 });


            context.SaveChanges();
        }
    }
}
