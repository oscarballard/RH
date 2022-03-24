using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace RH.Models
{
    //dataContext
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Competencias> Competencias { get; set; }
        public DbSet<Idiomas> Idiomas { get; set; }
        public DbSet<Capacitaciones> Capacitaciones { get; set; }
        public DbSet<Level_grade> Level_grade { get; set; }
        public DbSet<Puesto> Puesto { get; set; }
        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Experiencia_laboral> Experiencia_laboral { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
    } 
    public class Competencias{
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id_competencias {get; set;}
        [StringLength(100)]
        public string descripcion_competencias {get; set;}
        public int status {get; set;}

    }

    public class Idiomas{

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]        
        public int id_idioma {get; set;}
        [StringLength(50)]
        public string name {get; set;}
        public int status {get; set;}

    }

    public class Capacitaciones{

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]    
        public int id_capacitaciones {get; set;}
        [StringLength(100)]
        public string description {get; set;}
        [ForeignKey("id_level")]
        public int Level_grade_id {get; set;}
        [Required]
        public int date_from {get; set;}
        public int date_to {get; set;}
        public int institution {get; set;}
        public int status {get; set;}
    }

    public class Level_grade{

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]   
        public int id_level {get; set;}
         [Required]
         [StringLength(100)]
        public string name {get;set;} 
        public int status {get;set;} 
    }

    public class Puesto{
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]   
        public int id_puesto {get; set;}
        [Required]
        [StringLength(100)]
        public string name {get; set;} 
        public string risk_level {get; set;}       //nivel de riesgo
        public double minimum_salary {get; set;}   //Nivel Mínimo Salario
        public double maximun_salary {get; set;}   // Nivel Máximo Salario
        public int status {get; set;}
    }

    public class Candidato{
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]   
        public int id_candidato {get; set;}
        [StringLength(12)]
        public string cedula {get; set;} 
        [StringLength(100)]
        public string name {get; set;} 
        [ForeignKey("id_puesto")]
        public int puesto_id {get; set;}       //nivel de riesgo
        [ForeignKey("id_departamento")]
        public int departamento_id {get; set;}   //Nivel Mínimo Salario
        public int salary_aspire {get; set;}   // Nivel Máximo Salario
        public string principales_competencias {get; set;}
        public string principales_capacitaciones {get; set;}
        public string experiencia_laboral {get; set;}
        public string recomendado_por {get; set;}
        public int status {get; set;}
    }

    public class Departamento{

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]  
         public int id_departamento {get; set;}
         [StringLength(100)]
         public string name {get;set;}
         public int status {get;set;}
    }

    public class Experiencia_laboral{
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]  
         public int id_departamento {get; set;}
        [ForeignKey("id_candidato")]
        public int id_candidato {get; set;}
         [StringLength(100)]
        public string puesto_ocupado {get; set;} 
        public string date_from {get; set;} 
        public double salary {get; set;}
        public int status {get; set;}
    }

    public class Empleado{
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)] 
        public int id_empleado {get; set;}
        [StringLength(13)]
        public string cedula {get; set;} 
        [StringLength(100)]
        public string name {get; set;} 
        public string date_ingreso {get; set;} 
        [ForeignKey("id_departamento")]
        public string departamento_id {get; set;} 
        [ForeignKey("id_puesto")]
        public string puesto_id {get; set;} 
        public int monthly_salary {get; set;}
        public int status {get; set;}
    }
}