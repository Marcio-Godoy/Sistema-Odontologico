using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables; //Referênciando"Usando" a classe Tables


namespace Controllers.Map 
{
    class PacienteMap : EntityTypeConfiguration<Paciente>
    {
        public PacienteMap()
        {
            this.ToTable("Paciente");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasColumnName("ID_PACIENTE");
            this.Property(p => p.Nome).HasColumnName("NOME_PACIENTE");
            this.Property(p => p.Email).HasColumnName("EMAIL_PACIENTE");
            this.Property(p => p.Telefone).HasColumnName("TELEFONE_PACIENTE");
            this.Property(p => p.Celular).HasColumnName("CELULAR_PACIENTE");
            this.Property(p => p.CEP).HasColumnName("CEP_PACIENTE");
            this.Property(p => p.Endereco).HasColumnName("ENDERECO_PACIENTE");
            this.Property(p => p.Complemento).HasColumnName("COMPLEMENTO_PACIENTE");
            this.Property(p => p.Nascimento).HasColumnName("NASCIMENTO_PACIENTE");
            this.Property(p => p.Sexo).HasColumnName("SEXO_PACIENTE");

        }
    }
}
