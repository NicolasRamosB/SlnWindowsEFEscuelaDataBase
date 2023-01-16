namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaNacimiento = c.DateTime(),
                    })
                .PrimaryKey(t => t.AlumnoId);
            
            CreateTable(
                "dbo.Docente",
                c => new
                    {
                        ProfeosrId = c.Int(nullable: false, identity: true),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ProfeosrId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Docente");
            DropTable("dbo.Alumno");
        }
    }
}
