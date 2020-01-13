using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables; //Referênciando"Usando" a classe Tables

namespace Controllers.Map
{
    class ConsultaMap : EntityTypeConfiguration<Consulta>
    {
        public ConsultaMap()
        {
            this.ToTable("Consulta");
            this.HasKey(c => c.IdConsulta);
            this.HasKey(c => c.IdDentista);
            this.HasKey(c => c.IdPaciente);
            this.Property(c => c.IdConsulta).HasColumnName("ID_CONSULTA");
            this.Property(c => c.IdDentista).HasColumnName("ID_DENTISTA");
            this.Property(c => c.IdPaciente).HasColumnName("ID_PACIENTE");
            this.Property(c => c.Data).HasColumnName("DATA");
            this.Property(c => c.HoraMarcada).HasColumnName("HORA_MARCADA");
            this.Property(c => c.HoraInicio).HasColumnName("HORA_INICIO");
            this.Property(c => c.HoraFim).HasColumnName("HORA_FIM");
            this.Property(c => c.Observacao).HasColumnName("OBSERVACAO");
            this.Property(c => c.Status).HasColumnName("STATUS");
        }
    }
}
