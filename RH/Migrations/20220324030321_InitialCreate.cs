using Microsoft.EntityFrameworkCore.Migrations;

namespace RH.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    id_candidato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cedula = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    puesto_id = table.Column<int>(type: "int", nullable: false),
                    departamento_id = table.Column<int>(type: "int", nullable: false),
                    salary_aspire = table.Column<int>(type: "int", nullable: false),
                    principales_competencias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    principales_capacitaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    experiencia_laboral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recomendado_por = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.id_candidato);
                });

            migrationBuilder.CreateTable(
                name: "Capacitaciones",
                columns: table => new
                {
                    id_capacitaciones = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Level_grade_id = table.Column<int>(type: "int", nullable: false),
                    date_from = table.Column<int>(type: "int", nullable: false),
                    date_to = table.Column<int>(type: "int", nullable: false),
                    institution = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacitaciones", x => x.id_capacitaciones);
                });

            migrationBuilder.CreateTable(
                name: "Competencias",
                columns: table => new
                {
                    id_competencias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion_competencias = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencias", x => x.id_competencias);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    id_departamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.id_departamento);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    id_empleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cedula = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    date_ingreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    departamento_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    puesto_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monthly_salary = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.id_empleado);
                });

            migrationBuilder.CreateTable(
                name: "Experiencia_laboral",
                columns: table => new
                {
                    id_departamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_candidato = table.Column<int>(type: "int", nullable: false),
                    puesto_ocupado = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    date_from = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salary = table.Column<double>(type: "float", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencia_laboral", x => x.id_departamento);
                });

            migrationBuilder.CreateTable(
                name: "Idiomas",
                columns: table => new
                {
                    id_idioma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idiomas", x => x.id_idioma);
                });

            migrationBuilder.CreateTable(
                name: "Level_grade",
                columns: table => new
                {
                    id_level = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level_grade", x => x.id_level);
                });

            migrationBuilder.CreateTable(
                name: "Puesto",
                columns: table => new
                {
                    id_puesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    risk_level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    minimum_salary = table.Column<double>(type: "float", nullable: false),
                    maximun_salary = table.Column<double>(type: "float", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puesto", x => x.id_puesto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidato");

            migrationBuilder.DropTable(
                name: "Capacitaciones");

            migrationBuilder.DropTable(
                name: "Competencias");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Experiencia_laboral");

            migrationBuilder.DropTable(
                name: "Idiomas");

            migrationBuilder.DropTable(
                name: "Level_grade");

            migrationBuilder.DropTable(
                name: "Puesto");
        }
    }
}
