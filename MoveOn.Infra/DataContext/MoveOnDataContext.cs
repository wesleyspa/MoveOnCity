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
        public DbSet<AteVeiculo> AteVeiculos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<FunContato> FunContatos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<FunEndereco> FunEnderecos { get; set; }
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
            modelBuilder.Configurations.Add(new FunEnderecoMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Configurations.Add(new AteVeiculoMap());
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
            context.Contatos.Add(new Contato {Id = 6, DDI = "55", DDD = "12", Numero = "98765422", Tipo = "Celular", Info = "Sem Info" });
            context.Contatos.Add(new Contato {Id = 7, DDI = "55", DDD = "14", Numero = "67892332", Tipo = "Celular", Info = "Sem Infos Adicionais" });
            context.Contatos.Add(new Contato {Id = 8, DDI = "55", DDD = "13", Numero = "54323322", Tipo = "Residencial", Info = "Somente ligar em horário comercial" });
            context.Contatos.Add(new Contato {Id = 9, DDI = "55", DDD = "15", Numero = "65432343", Tipo = "Celular", Info = "Somente ligar em emergência" });
            context.Contatos.Add(new Contato {Id = 10, DDI = "55", DDD = "16", Numero = "23432111", Tipo = "Residencial", Info = "Somente ligar aos fim de semanas" });
            context.SaveChanges();

            //-- Novos Contatos
            context.FunContatos.Add(new FunContato { Id = 1, DDI = "55", DDD = "11", Numero = "943543122", Tipo = "Celular", Info = "Somente ligar em horário comercial" });
            context.FunContatos.Add(new FunContato { Id = 2, DDI = "55", DDD = "11", Numero = "953553123", Tipo = "Celular", Info = "Sem Infos Adicionais" });
            context.FunContatos.Add(new FunContato { Id = 3, DDI = "55", DDD = "13", Numero = "63563124", Tipo = "Residencial", Info = "Somente ligar em horário comercial" });
            context.FunContatos.Add(new FunContato { Id = 4, DDI = "55", DDD = "13", Numero = "973573125", Tipo = "Celular", Info = "Somente ligar em emergência" });
            context.FunContatos.Add(new FunContato { Id = 5, DDI = "55", DDD = "11", Numero = "83583128", Tipo = "Residencial", Info = "Somente ligar aos fim de semanas" });
            context.FunContatos.Add(new FunContato { Id = 6, DDI = "55", DDD = "12", Numero = "98765422", Tipo = "Celular" });
            context.FunContatos.Add(new FunContato { Id = 7, DDI = "55", DDD = "14", Numero = "67892332", Tipo = "Celular", Info = "Sem Infos Adicionais" });
            context.FunContatos.Add(new FunContato { Id = 8, DDI = "55", DDD = "13", Numero = "54323322", Tipo = "Residencial", Info = "Somente ligar em horário comercial" });
            context.FunContatos.Add(new FunContato { Id = 9, DDI = "55", DDD = "15", Numero = "65432343", Tipo = "Celular", Info = "Somente ligar em emergência" });
            context.FunContatos.Add(new FunContato { Id = 10, DDI = "55", DDD = "16", Numero = "23432111", Tipo = "Residencial", Info = "Somente ligar aos fim de semanas" });
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

            //-- Novos Enderecos
            context.Enderecos.Add(new Endereco { Id = 1, Logradouro = "Rua", _Endereco = "Maria da Penha", Numero = "321", Bairro = "Jardim Wanda", CEP = "03232567", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.Enderecos.Add(new Endereco { Id = 2, Logradouro = "Str.", _Endereco = "João Carlos", Numero = "23", Bairro = "Jardim Paulista", CEP = "0398765", Cidade = "Osasco", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.Enderecos.Add(new Endereco { Id = 3, Logradouro = "Avenida", _Endereco = "Boa Vista", Numero = "11", Bairro = "Vila Esperança", CEP = "2343123", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.Enderecos.Add(new Endereco { Id = 4, Logradouro = "Rua", _Endereco = "XV Novembro", Numero = "93", Bairro = "Vila Nova", CEP = "6543456", Cidade = "Taboão da Serra", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.Enderecos.Add(new Endereco { Id = 5, Logradouro = "Avenida", _Endereco = "Paulista", Numero = "32", Bairro = "Vila Natal", CEP = "9876543", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.SaveChanges();

            //-- Novos Enderecos
            context.FunEnderecos.Add(new FunEndereco { Id = 1, Logradouro = "Rua", _Endereco = "Maria da Penha", Numero = "321", Bairro = "Jardim Wanda", CEP = "03232567", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.FunEnderecos.Add(new FunEndereco { Id = 2, Logradouro = "Str.", _Endereco = "João Carlos", Numero = "23", Bairro = "Jardim Paulista", CEP = "0398765", Cidade = "Osasco", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.FunEnderecos.Add(new FunEndereco { Id = 3, Logradouro = "Avenida", _Endereco = "Boa Vista", Numero = "11", Bairro = "Vila Esperança", CEP = "2343123", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.FunEnderecos.Add(new FunEndereco { Id = 4, Logradouro = "Rua", _Endereco = "XV Novembro", Numero = "93", Bairro = "Vila Nova", CEP = "6543456", Cidade = "Taboão da Serra", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.FunEnderecos.Add(new FunEndereco { Id = 5, Logradouro = "Avenida", _Endereco = "Paulista", Numero = "32", Bairro = "Vila Natal", CEP = "9876543", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.SaveChanges();

            //-- Novos Veículos
            context.Veiculos.Add(new Veiculo { Id = 1, Marca = "Chevrolet", Modelo = "Celta", AnoFabricacao = 2011, Placa = "ABC-3213", Cor = "Prata", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 5 });
            context.Veiculos.Add(new Veiculo { Id = 2, Marca = "Fiat", Modelo = "Uno", AnoFabricacao = 2013, Placa = "DWC-2213", Cor = "Preto", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 5 });
            context.Veiculos.Add(new Veiculo { Id = 3, Marca = "Volkswagem", Modelo = "Gol", AnoFabricacao = 2015, Placa = "EQC-3213", Cor = "Vermelho", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 3 });
            context.Veiculos.Add(new Veiculo { Id = 4, Marca = "Honda", Modelo = "Fit", AnoFabricacao = 2012, Placa = "IDS-0987", Cor = "Prata", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 5 });
            context.Veiculos.Add(new Veiculo { Id = 5, Marca = "Chevrolet", Modelo = "Onix", AnoFabricacao = 2014, Placa = "ODC-3223", Cor = "Branco", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 3 });
            context.Veiculos.Add(new Veiculo { Id = 6, Marca = "Yamaha", Modelo = "Tenere", AnoFabricacao = 2012, Placa = "DDD-0987", Cor = "Azul", Chassi = "ABC02MS3EM99D9", Passageiros = 2, Portas = 0 });
            context.Veiculos.Add(new Veiculo { Id = 7, Marca = "Chevrolet", Modelo = "F10", AnoFabricacao = 2013, Placa = "KDW-3122", Cor = "Branco", Chassi = "ABC02MS3EM99D9", Passageiros = 2, Portas = 2 });
            context.SaveChanges();

            //-- Novos Clientes
            context.Clientes.Add(new Cliente {Id = 1, Nome = "José Bonifacio da Silva", DataNascimento = "22/05/1993", CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Casado", Email = "JoseBone@gmail.com", EnderecoId = 1, Telefone1 = "32123432" ,Senha = "123", VeiculoId = 1});
            context.Clientes.Add(new Cliente {Id = 2, Nome = "João Cleber Ferreira", DataNascimento = "22/02/1993", CPF_CNPJ = "22222222222", CNH = "123456789", EstadoCivil = "Solteiro", Email = "Joao.C@gmail.com", EnderecoId = 2, Telefone1 = "32123432", Senha = "123", VeiculoId = 2 });
            context.Clientes.Add(new Cliente {Id = 3, Nome = "Maria Joaquina", DataNascimento = "22/09/1993", CPF_CNPJ = "33333333333", CNH = "123456789", EstadoCivil = "Viúva", Email = "MariaB@gmail.com", EnderecoId = 3, Telefone1 = "32123432", Senha = "123", VeiculoId = 3 });
            context.Clientes.Add(new Cliente {Id = 4, Nome = "Berenicie Joana", DataNascimento = "22/05/1973", CPF_CNPJ = "44444444444", CNH = "123456789", EstadoCivil = "Solteiro", Email = "JoaquinaT@gmail.com", EnderecoId = 4, Telefone1 = "32123432", Senha = "123", VeiculoId = 4 });
            context.Clientes.Add(new Cliente {Id = 5, Nome = "Claudete Vazques", DataNascimento = "13/05/1982", CPF_CNPJ = "55555555555", CNH = "123456789", EstadoCivil = "Divorciada", Email = "Claudete@gmail.com", EnderecoId = 5, Telefone1 = "32123432", Senha = "123", VeiculoId = 5 });
            context.Clientes.Add(new Cliente {Id = 6, Nome = "Wesley Alves", DataNascimento = "10/02/1995", CPF_CNPJ = "39987783813", CNH = "123456789", EstadoCivil = "Divorciada", Email = "Claudete@gmail.com", EnderecoId = 5, Telefone1 = "32123432", Senha = "123", VeiculoId = 5 });
            context.SaveChanges();

            //-- Novos Funcionarios
            context.Funcionarios.Add(new Funcionario {Id = 1, Nome = "Mauricio Augusto Souza", DataNascimento = "20/12/1993", CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Casado", Email = "MauricioA@gmail.com", FunEnderecoId = 1, Senha = "123", Telefone1 = "11943543321" });
            context.Funcionarios.Add(new Funcionario {Id = 2, Nome = "Valéria Silva", DataNascimento = "09/01/1992", CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Solteira", Email = "ValeriaS@gmail.com", FunEnderecoId = 2, Senha = "123", Telefone1 = "11943543321" });
            context.Funcionarios.Add(new Funcionario {Id = 3, Nome = "Diego Alves", DataNascimento = "02/03/1955", CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Casado", Email = "DiegoA@gmail.com", FunEnderecoId = 3, Senha = "123", Telefone1 = "11943543321" });
            context.Funcionarios.Add(new Funcionario {Id = 4, Nome = "Rafael de Castro", DataNascimento = "12/05/1943", CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Solteiro", Email = "RafaelC@gmail.com", FunEnderecoId = 4, Senha = "123", Telefone1 = "11943543321" });
            context.Funcionarios.Add(new Funcionario {Id = 5, Nome = "Murilo Maciel", DataNascimento = "10/05/1990", CPF_CNPJ = "11111111111", CNH = "123456789", EstadoCivil = "Casado", Email = "MuriloM@gmail.com", FunEnderecoId = 5, Senha = "123", Telefone1 = "11943543321" });
            context.SaveChanges();

            //-- Novos Status
            context.Status.Add(new Status {Id = 1, Descricao = "Novo Atendimento" });
            context.Status.Add(new Status {Id = 2, Descricao = "Iniciado" });
            context.Status.Add(new Status {Id = 3, Descricao = "Concluído" });
            context.Status.Add(new Status {Id = 4, Descricao = "Cancelado" });
            context.SaveChanges();

            //-- Novos AteVeículos
            context.AteVeiculos.Add(new AteVeiculo { Id = 1, Marca = "Chevrolet", Modelo = "Celta", AnoFabricacao = 2011, Placa = "ABC-3213", Cor = "Prata", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 5 });
            context.AteVeiculos.Add(new AteVeiculo { Id = 2, Marca = "Fiat", Modelo = "Uno", AnoFabricacao = 2013, Placa = "DWC-2213", Cor = "Preto", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 5 });
            context.AteVeiculos.Add(new AteVeiculo { Id = 3, Marca = "Volkswagem", Modelo = "Gol", AnoFabricacao = 2015, Placa = "EQC-3213", Cor = "Vermelho", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 3 });
            context.AteVeiculos.Add(new AteVeiculo { Id = 4, Marca = "Honda", Modelo = "Fit", AnoFabricacao = 2012, Placa = "IDS-0987", Cor = "Prata", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 5 });
            context.AteVeiculos.Add(new AteVeiculo { Id = 5, Marca = "Chevrolet", Modelo = "Onix", AnoFabricacao = 2014, Placa = "ODC-3223", Cor = "Branco", Chassi = "ABC02MS3EM99D9", Passageiros = 5, Portas = 3 });
            context.AteVeiculos.Add(new AteVeiculo { Id = 6, Marca = "Yamaha", Modelo = "Tenere", AnoFabricacao = 2012, Placa = "DDD-0987", Cor = "Azul", Chassi = "ABC02MS3EM99D9", Passageiros = 2, Portas = 0 });
            context.AteVeiculos.Add(new AteVeiculo { Id = 7, Marca = "Chevrolet", Modelo = "F10", AnoFabricacao = 2013, Placa = "KDW-3122", Cor = "Branco", Chassi = "ABC02MS3EM99D9", Passageiros = 2, Portas = 2 });
            context.SaveChanges();

            //-- Novos Atendimento
            context.Atendimentos.Add(new Atendimento { Id = 1, ClienteId = 1, VeiculoCliente = 1, ServicoId = 1, MomAbertura = DateTime.Now, Logradouro = "Rua", _Endereco = "Maria da Penha", Numero = "321", Bairro = "Jardim Wanda", CEP = "03232567", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 43213});
            context.Atendimentos.Add(new Atendimento { Id = 2, ClienteId = 2, VeiculoCliente = 2, ServicoId = 2, MomAbertura = DateTime.Now, Logradouro = "Str.", _Endereco = "João Carlos", Numero = "23", Bairro = "Jardim Paulista", CEP = "0398765", Cidade = "Osasco", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42333 });
            context.Atendimentos.Add(new Atendimento { Id = 3, ClienteId = 3, VeiculoCliente = 3, ServicoId = 3, MomAbertura = DateTime.Now, Logradouro = "Avenida", _Endereco = "Boa Vista", Numero = "11", Bairro = "Vila Esperança", CEP = "2343123", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 33132 });
            context.Atendimentos.Add(new Atendimento { Id = 4, ClienteId = 4, VeiculoCliente = 4, ServicoId = 1, MomAbertura = DateTime.Now, Logradouro = "Rua", _Endereco = "XV Novembro", Numero = "93", Bairro = "Vila Nova", CEP = "6543456", Cidade = "Taboão da Serra", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 43123 });
            context.Atendimentos.Add(new Atendimento { Id = 5, ClienteId = 5, VeiculoCliente = 5, ServicoId = 2, MomAbertura = DateTime.Now, Logradouro = "Avenida", _Endereco = "Paulista", Numero = "32", Bairro = "Vila Natal", CEP = "9876543", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.SaveChanges();

            //-- Atendimento Iniciados
            context.Atendimentos.Add(new Atendimento { Id = 6, ClienteId = 1, VeiculoCliente = 1, AteVeiculoId = 1, ServicoId = 1, MomAbertura = DateTime.Now, MomInicio = DateTime.Now , Status="urgente", Logradouro = "Estrada", _Endereco = "São Francisco", Numero = "2701", Bairro = "Vila Sonia do Taboao", CEP = "06765001", Cidade = "Taboão da Serra", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 423543 });
            context.Atendimentos.Add(new Atendimento { Id = 7, ClienteId = 2, VeiculoCliente = 2, AteVeiculoId = 2, ServicoId = 2, MomAbertura = DateTime.Now, MomInicio = DateTime.Now , Logradouro = "Str.", _Endereco = "João Carlos", Numero = "23", Bairro = "Jardim Paulista", CEP = "0398765", Cidade = "Osasco", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42353  });
            context.Atendimentos.Add(new Atendimento { Id = 8, ClienteId = 3, VeiculoCliente = 3, AteVeiculoId = 3, ServicoId = 3, MomAbertura = DateTime.Now, MomInicio = DateTime.Now , Logradouro = "Avenida", _Endereco = "Boa Vista", Numero = "11", Bairro = "Vila Esperança", CEP = "2343123", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 654321  });
            context.Atendimentos.Add(new Atendimento { Id = 9, ClienteId = 4, VeiculoCliente = 4, AteVeiculoId = 4, ServicoId = 1, MomAbertura = DateTime.Now, MomInicio = DateTime.Now , Logradouro = "Rua", _Endereco = "XV Novembro", Numero = "93", Bairro = "Vila Nova", CEP = "6543456", Cidade = "Taboão da Serra", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 442234  });
            context.Atendimentos.Add(new Atendimento { Id = 10, ClienteId = 5, VeiculoCliente = 5, AteVeiculoId = 5, ServicoId = 2, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, Logradouro = "Avenida", _Endereco = "Paulista", Numero = "32", Bairro = "Vila Natal", CEP = "9876543", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 4232254323  });
            context.SaveChanges();

            //-- Atendimento Concluídos
            context.Atendimentos.Add(new Atendimento {Id = 11, ClienteId = 1, VeiculoCliente = 1, AteVeiculoId = 1, ServicoId = 1, MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, InfoConclusao = "A" , Logradouro = "Rua", _Endereco = "Maria da Penha", Numero = "321", Bairro = "Vila Sonia do Taboao", CEP = "03232567", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 34321 });
            context.Atendimentos.Add(new Atendimento {Id = 12, ClienteId = 2, VeiculoCliente = 2, AteVeiculoId = 2, ServicoId = 2,  MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, InfoConclusao = "B", Logradouro = "Str.", _Endereco = "João Carlos", Numero = "23", Bairro = "Jardim Paulista", CEP = "0398765", Cidade = "Osasco", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 423 });
            context.Atendimentos.Add(new Atendimento {Id = 13, ClienteId = 3, VeiculoCliente = 3, AteVeiculoId = 3, ServicoId = 3,  MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, InfoConclusao = "C", Logradouro = "Avenida", _Endereco = "Boa Vista", Numero = "11", Bairro = "Vila Esperança", CEP = "2343123", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 223232 });
            context.Atendimentos.Add(new Atendimento {Id = 14, ClienteId = 4, VeiculoCliente = 4, AteVeiculoId = 4, ServicoId = 1,  MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, InfoConclusao = "D", Logradouro = "Rua", _Endereco = "XV Novembro", Numero = "93", Bairro = "Vila Nova", CEP = "6543456", Cidade = "Taboão da Serra", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 43213 });
            context.Atendimentos.Add(new Atendimento {Id = 15, ClienteId = 5, VeiculoCliente = 5, AteVeiculoId = 5, ServicoId = 2,  MomAbertura = DateTime.Now, MomInicio = DateTime.Now, MomConclusao = DateTime.Now, InfoConclusao = "E", Logradouro = "Avenida", _Endereco = "Paulista", Numero = "32", Bairro = "Vila Natal", CEP = "9876543", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil", CoordenadaX = 12345, CoordenadaY = 42322 });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
