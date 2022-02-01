using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebAp.Models;

#nullable disable

namespace WebAp.Context
{
    public partial class DemoContext : DbContext
    {
        public DemoContext()
        {
        }

        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<AlumnosBaja> AlumnosBajas { get; set; }
        public virtual DbSet<AlumnosHgo> AlumnosHgos { get; set; }
        public virtual DbSet<AlumnosTodo> AlumnosTodos { get; set; }
        public virtual DbSet<CatCurso> CatCursos { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<CursosAlumno> CursosAlumnos { get; set; }
        public virtual DbSet<CursosInstructore> CursosInstructores { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<EstatusAlumno> EstatusAlumnos { get; set; }
        public virtual DbSet<Instructore> Instructores { get; set; }
        public virtual DbSet<Saldo> Saldos { get; set; }
        public virtual DbSet<TablaIsr> TablaIsrs { get; set; }
        public virtual DbSet<Transaccione> Transacciones { get; set; }
        public virtual DbSet<VAlumno> VAlumnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(e => e.IdAlumnos)
                    .HasName("PK__Alumnos__3213E83F4766B60E");

                entity.Property(e => e.IdAlumnos).HasColumnName("id_alumnos");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.IdEstadoOrigen).HasColumnName("idEstadoOrigen");

                entity.Property(e => e.IdEstatus).HasColumnName("idEstatus");

                entity.Property(e => e.NombreAlumno)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre_alumno");

                entity.Property(e => e.PrimerApellidoAlumno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido_alumno");

                entity.Property(e => e.SegundoApellidoAlumno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido_alumno");

                entity.Property(e => e.Sueldo)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("sueldo");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdEstadoOrigenNavigation)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.IdEstadoOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alumnos_Estados");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.IdEstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alumnos_EstatusAlumnos");
            });

            modelBuilder.Entity<AlumnosBaja>(entity =>
            {
                entity.HasKey(e => e.IdAlumnosBaja)
                    .HasName("PK__AlumnosB__3213E83FDFCD43D6");

                entity.ToTable("AlumnosBaja");

                entity.Property(e => e.IdAlumnosBaja).HasColumnName("id_AlumnosBaja");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");
            });

            modelBuilder.Entity<AlumnosHgo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlumnosHgo");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.IdAlumnos)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_alumnos");

                entity.Property(e => e.IdEstadoOrigen).HasColumnName("idEstadoOrigen");

                entity.Property(e => e.IdEstatus).HasColumnName("idEstatus");

                entity.Property(e => e.NombreAlumno)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre_alumno");

                entity.Property(e => e.PrimerApellidoAlumno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido_alumno");

                entity.Property(e => e.SegundoApellidoAlumno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido_alumno");

                entity.Property(e => e.Sueldo)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("sueldo");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AlumnosTodo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.IdAlumnos)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_alumnos");

                entity.Property(e => e.IdEstadoOrigen).HasColumnName("idEstadoOrigen");

                entity.Property(e => e.IdEstatus).HasColumnName("idEstatus");

                entity.Property(e => e.NombreAlumno)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre_alumno");

                entity.Property(e => e.PrimerApellidoAlumno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido_alumno");

                entity.Property(e => e.SegundoApellidoAlumno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido_alumno");

                entity.Property(e => e.Sueldo)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("sueldo");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<CatCurso>(entity =>
            {
                entity.HasKey(e => e.IdCatCursos)
                    .HasName("PK__CatCurso__3213E83F8743710C");

                entity.Property(e => e.IdCatCursos).HasColumnName("id_CatCursos");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Horas).HasColumnName("horas");

                entity.Property(e => e.IdPreRequisito).HasColumnName("idPreRequisito");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdPreRequisitoNavigation)
                    .WithMany(p => p.InverseIdPreRequisitoNavigation)
                    .HasForeignKey(d => d.IdPreRequisito)
                    .HasConstraintName("FK_CatCursos_CatCursos");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.IdCursos)
                    .HasName("PK__Cursos__3213E83F80C286BF");

                entity.Property(e => e.IdCursos).HasColumnName("id_Cursos");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.Fechatermino)
                    .HasColumnType("date")
                    .HasColumnName("fechatermino");

                entity.Property(e => e.IdCatCurso).HasColumnName("idCatCurso");

                entity.HasOne(d => d.IdCatCursoNavigation)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.IdCatCurso)
                    .HasConstraintName("FK_Cursos_CatCursos");
            });

            modelBuilder.Entity<CursosAlumno>(entity =>
            {
                entity.HasKey(e => e.IdCursosAlumnos)
                    .HasName("PK__CursosAl__3213E83F4252D686");

                entity.Property(e => e.IdCursosAlumnos).HasColumnName("id_CursosAlumnos");

                entity.Property(e => e.Calificacion).HasColumnName("calificacion");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("date")
                    .HasColumnName("fechaBaja");

                entity.Property(e => e.FechaInscripcion)
                    .HasColumnType("date")
                    .HasColumnName("fechaInscripcion");

                entity.Property(e => e.IdAlumno).HasColumnName("idAlumno");

                entity.Property(e => e.IdCurso).HasColumnName("idCurso");

                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany(p => p.CursosAlumnos)
                    .HasForeignKey(d => d.IdAlumno)
                    .HasConstraintName("FK_CursosAlumnos_Alumnos");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.CursosAlumnos)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CursosAlumnos_Cursos");
            });

            modelBuilder.Entity<CursosInstructore>(entity =>
            {
                entity.HasKey(e => e.IdCursosInstructores)
                    .HasName("PK__CursosIn__3213E83F877B8C41");

                entity.Property(e => e.IdCursosInstructores).HasColumnName("id_CursosInstructores");

                entity.Property(e => e.FechaContratacion)
                    .HasColumnType("date")
                    .HasColumnName("fechaContratacion");

                entity.Property(e => e.IdCurso).HasColumnName("idCurso");

                entity.Property(e => e.IdInstructor).HasColumnName("idInstructor");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.CursosInstructores)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CursosInstructores_Cursos");

                entity.HasOne(d => d.IdCurso1)
                    .WithMany(p => p.CursosInstructores)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CursosInstructores_Instructores");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstados)
                    .HasName("PK__Estados__3213E83F41C93F06");

                entity.Property(e => e.IdEstados).HasColumnName("id_Estados");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<EstatusAlumno>(entity =>
            {
                entity.HasKey(e => e.IdEstatusAlumnos)
                    .HasName("PK__EstatusA__3213E83FF958C9AD");

                entity.Property(e => e.IdEstatusAlumnos).HasColumnName("id_EstatusAlumnos");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Instructore>(entity =>
            {
                entity.HasKey(e => e.IdInstructores)
                    .HasName("PK__Instruct__3213E83F8AAAB6F1");

                entity.Property(e => e.IdInstructores).HasColumnName("id_Instructores");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.CuotaHora)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("cuotaHora");

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("rfc")
                    .IsFixedLength(true);

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Saldo>(entity =>
            {
                entity.ToTable("saldos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Saldo1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("saldo");
            });

            modelBuilder.Entity<TablaIsr>(entity =>
            {
                entity.ToTable("TablaISR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CuotaFija).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ExedLimInf).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.LimInf).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.LimSup).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Subsidio).HasColumnType("decimal(19, 2)");
            });

            modelBuilder.Entity<Transaccione>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdDestino).HasColumnName("idDestino");

                entity.Property(e => e.IdOrigen).HasColumnName("idOrigen");

                entity.Property(e => e.Monto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("monto");

                entity.HasOne(d => d.IdDestinoNavigation)
                    .WithMany(p => p.TransaccioneIdDestinoNavigations)
                    .HasForeignKey(d => d.IdDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transacciones_saldos1");

                entity.HasOne(d => d.IdOrigenNavigation)
                    .WithMany(p => p.TransaccioneIdOrigenNavigations)
                    .HasForeignKey(d => d.IdOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transacciones_saldos");
            });

            modelBuilder.Entity<VAlumno>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAlumnos");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength(true);

                entity.Property(e => e.Estado)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EStatus");

                entity.Property(e => e.IdAlumnos).HasColumnName("id_alumnos");

                entity.Property(e => e.NombreAlumno)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre_alumno");

                entity.Property(e => e.PrimerApellidoAlumno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido_alumno");

                entity.Property(e => e.SegundoApellidoAlumno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido_alumno");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
