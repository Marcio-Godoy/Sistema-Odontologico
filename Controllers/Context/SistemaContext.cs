using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Runtime.Remoting.Contexts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Controllers.Map;
using Tables;

namespace Controllers.Context
{
    class SistemaContext : DbContext
    {
        //A base irá "apontar" para o banco de dados
        public SistemaContext() : base("Data Source=MARCIOGODOY\\MARCIO;Initial Catalog=Odonto; Persist Security Info=True; User ID=sa;Password=91975203;")
        {

        }

        //Definindo as propriedades das tabelas
        public DbSet<Consulta>Consultas{get;set;} //Envio e recebimento de dados (GET;SET;)
        public DbSet<Paciente>Pacientes{ get; set;}
        public DbSet<Dentista>Dentistas{ get; set;}

        //Acessar as tabelas
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new DentistaMap()); //Adicionando um mapeamento para a base de dados "TABLES"
            modelBuilder.Configurations.Add(new PacienteMap()); 
            modelBuilder.Configurations.Add(new ConsultaMap()); 
            base.OnModelCreating(modelBuilder);
        }
    }
}
