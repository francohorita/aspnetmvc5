using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace aspnetmvc5.Models
{
    public partial class MySqlDbContext : DbContext
    {
        public MySqlDbContext()
        {
        }

        public MySqlDbContext(DbContextOptions<MySqlDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlumnosMaterias> AlumnosMaterias { get; set; }
        public virtual DbSet<Carreras> Carreras { get; set; }
        public virtual DbSet<CarrerasMaterias> CarrerasMaterias { get; set; }
        public virtual DbSet<Materias> Materias { get; set; }
        public virtual DbSet<MateriasProfesores> MateriasProfesores { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=sql10.freemysqlhosting.net;database=sql10253958;user=sql10253958;pwd=Rjd993MQTP;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlumnosMaterias>(entity =>
            {
                entity.ToTable("alumnos_materias");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Creado)
                    .HasColumnName("creado")
                    .HasColumnType("datetime");

                entity.Property(e => e.MateriaId)
                    .HasColumnName("materiaId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuarioId")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Carreras>(entity =>
            {
                entity.ToTable("carreras");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Creado)
                    .HasColumnName("creado")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CarrerasMaterias>(entity =>
            {
                entity.ToTable("carreras_materias");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CarreraId)
                    .HasColumnName("carreraId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Creado)
                    .HasColumnName("creado")
                    .HasColumnType("datetime");

                entity.Property(e => e.MateriaId)
                    .HasColumnName("materiaId")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Materias>(entity =>
            {
                entity.ToTable("materias");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Creado)
                    .HasColumnName("creado")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<MateriasProfesores>(entity =>
            {
                entity.ToTable("materias_profesores");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Creado)
                    .HasColumnName("creado")
                    .HasColumnType("datetime");

                entity.Property(e => e.MateriaId)
                    .HasColumnName("materiaId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuarioId")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(255)");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasColumnType("text");

                entity.Property(e => e.Creado)
                    .HasColumnName("creado")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dni)
                    .HasColumnName("dni")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fechanac)
                    .HasColumnName("fechanac")
                    .HasColumnType("date");

                entity.Property(e => e.Ingreso)
                    .HasColumnName("ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.Legajo)
                    .HasColumnName("legajo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasColumnType("text");
                
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("text");

                entity.Property(e => e.Sueldo).HasColumnName("sueldo");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("int(2)");
            });
        }
    }
}
