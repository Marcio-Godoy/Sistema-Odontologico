namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consulta",
                c => new
                    {
                        ID_PACIENTE = c.Int(nullable: false, identity: true),
                        ID_CONSULTA = c.Int(nullable: false),
                        ID_DENTISTA = c.Int(nullable: false),
                        DATA = c.DateTime(),
                        HORA_MARCADA = c.DateTime(),
                        HORA_INICIO = c.DateTime(),
                        HORA_FIM = c.DateTime(),
                        OBSERVACAO = c.String(),
                        STATUS = c.String(),
                    })
                .PrimaryKey(t => t.ID_PACIENTE);
            
            CreateTable(
                "dbo.Dentista",
                c => new
                    {
                        ID_DENTISTA = c.Int(nullable: false, identity: true),
                        NOME_DENTISTA = c.String(),
                        EMAIL_DENTISTA = c.String(),
                        TELEFONE_DENTISTA = c.Long(nullable: false),
                        CELULAR_DENTISTA = c.Long(nullable: false),
                        CRO = c.String(),
                    })
                .PrimaryKey(t => t.ID_DENTISTA);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        ID_PACIENTE = c.Int(nullable: false, identity: true),
                        NOME_PACIENTE = c.String(),
                        EMAIL_PACIENTE = c.String(),
                        TELEFONE_PACIENTE = c.Long(nullable: false),
                        CELULAR_PACIENTE = c.Long(nullable: false),
                        CEP_PACIENTE = c.String(),
                        ENDERECO_PACIENTE = c.String(),
                        COMPLEMENTO_PACIENTE = c.String(),
                        NASCIMENTO_PACIENTE = c.DateTime(nullable: false),
                        SEXO_PACIENTE = c.String(),
                    })
                .PrimaryKey(t => t.ID_PACIENTE);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Paciente");
            DropTable("dbo.Dentista");
            DropTable("dbo.Consulta");
        }
    }
}
