using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Kiosko.Models
{
    public partial class KIOSKOUTM1Context : DbContext
    {
        public KIOSKOUTM1Context()
        {
        }

        public KIOSKOUTM1Context(DbContextOptions<KIOSKOUTM1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Divisione> Divisiones { get; set; }
        public virtual DbSet<Fotosdivision> Fotosdivisions { get; set; }
        public virtual DbSet<Fotosproyecto> Fotosproyectos { get; set; }
        public virtual DbSet<Grdoygrupo> Grdoygrupos { get; set; }
        public virtual DbSet<Proyecto> Proyectos { get; set; }
        public virtual DbSet<Registrosalumno> Registrosalumnos { get; set; }
        public virtual DbSet<Registrosprofesore> Registrosprofesores { get; set; }
        public virtual DbSet<Statususuario> Statususuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-QFEKVLB1\\FERNS;Initial Catalog=KIOSKOUTM1;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.Idcargo)
                    .HasName("PK_IDCARGO");

                entity.ToTable("CARGO");

                entity.Property(e => e.Idcargo).HasColumnName("IDCARGO");

                entity.Property(e => e.Cargo1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARGO");
            });

            modelBuilder.Entity<Divisione>(entity =>
            {
                entity.HasKey(e => e.Iddivisiones)
                    .HasName("PK_IDDIVISIONES");

                entity.ToTable("DIVISIONES");

                entity.Property(e => e.Iddivisiones).HasColumnName("IDDIVISIONES");

                entity.Property(e => e.Coordinador)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COORDINADOR");

                entity.Property(e => e.Descripciondivision)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCIONDIVISION");

                entity.Property(e => e.Fotodivision)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FOTODIVISION");

                entity.Property(e => e.Nombredivision)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBREDIVISION");

                entity.Property(e => e.Planestudio)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PLANESTUDIO");

                entity.Property(e => e.Videodivision)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("VIDEODIVISION");
            });

            modelBuilder.Entity<Fotosdivision>(entity =>
            {
                entity.HasKey(e => e.Idfotodivision)
                    .HasName("PK_IDFOTODIVISION");

                entity.ToTable("FOTOSDIVISION");

                entity.Property(e => e.Idfotodivision).HasColumnName("IDFOTODIVISION");

                entity.Property(e => e.Fotodivision)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FOTODIVISION");

                entity.Property(e => e.Iddivisiones).HasColumnName("IDDIVISIONES");

                entity.HasOne(d => d.IddivisionesNavigation)
                    .WithMany(p => p.Fotosdivisions)
                    .HasForeignKey(d => d.Iddivisiones)
                    .HasConstraintName("FK_IDDIVISIONES");
            });

            modelBuilder.Entity<Fotosproyecto>(entity =>
            {
                entity.HasKey(e => e.Idfotoproyecto)
                    .HasName("PK_IDFOTOPROYECTO");

                entity.ToTable("FOTOSPROYECTO");

                entity.Property(e => e.Idfotoproyecto).HasColumnName("IDFOTOPROYECTO");

                entity.Property(e => e.Fotoproyecto)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FOTOPROYECTO");

                entity.Property(e => e.Idproyectos).HasColumnName("IDPROYECTOS");

                entity.HasOne(d => d.IdproyectosNavigation)
                    .WithMany(p => p.Fotosproyectos)
                    .HasForeignKey(d => d.Idproyectos)
                    .HasConstraintName("FK_IDPROYECTOS");
            });

            modelBuilder.Entity<Grdoygrupo>(entity =>
            {
                entity.HasKey(e => e.Idgradoygrupo)
                    .HasName("PK_IDGRADOYGRUPO");

                entity.ToTable("GRDOYGRUPO");

                entity.Property(e => e.Idgradoygrupo).HasColumnName("IDGRADOYGRUPO");

                entity.Property(e => e.Gradoygrupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GRADOYGRUPO");
            });

            modelBuilder.Entity<Proyecto>(entity =>
            {
                entity.HasKey(e => e.Idproyectos)
                    .HasName("PK_IDPROYECTOS");

                entity.ToTable("PROYECTOS");

                entity.Property(e => e.Idproyectos).HasColumnName("IDPROYECTOS");

                entity.Property(e => e.Descripcionproyecto)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCIONPROYECTO");

                entity.Property(e => e.Fotoproyecto)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FOTOPROYECTO");

                entity.Property(e => e.Iddivisiones).HasColumnName("IDDIVISIONES");

                entity.Property(e => e.Nombreproyecto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBREPROYECTO");

                entity.Property(e => e.Videoproyecto)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("VIDEOPROYECTO");

                entity.HasOne(d => d.IddivisionesNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.Iddivisiones)
                    .HasConstraintName("FK_IDDIVISIONESENPROYECTO");
            });

            modelBuilder.Entity<Registrosalumno>(entity =>
            {
                entity.HasKey(e => e.Idalumno)
                    .HasName("PK_IDALUMNO");

                entity.ToTable("REGISTROSALUMNO");

                entity.Property(e => e.Idalumno).HasColumnName("IDALUMNO");

                entity.Property(e => e.Apellidom)
                  //  .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOM");

                entity.Property(e => e.Apellidop)
                    //.IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOP");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTRASEÑA");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Fechanac)
                    .HasColumnType("date")
                    .HasColumnName("FECHANAC");

                entity.Property(e => e.Fotoalumno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FOTOALUMNO");

                entity.Property(e => e.Idcargo).HasColumnName("IDCARGO");

                entity.Property(e => e.Iddivisiones).HasColumnName("IDDIVISIONES");

                entity.Property(e => e.Idgradoygrupo).HasColumnName("IDGRADOYGRUPO");

                entity.Property(e => e.Idproyectos).HasColumnName("IDPROYECTOS");

                entity.Property(e => e.Idstatus).HasColumnName("IDSTATUS");

                entity.Property(e => e.Nombre)
                    //.IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO");

                entity.HasOne(d => d.IdcargoNavigation)
                    .WithMany(p => p.Registrosalumnos)
                    .HasForeignKey(d => d.Idcargo)
                    .HasConstraintName("FK_CARGOALUMNO");

                entity.HasOne(d => d.IddivisionesNavigation)
                    .WithMany(p => p.Registrosalumnos)
                    .HasForeignKey(d => d.Iddivisiones)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IDDIVISIONALUMNO");

                entity.HasOne(d => d.IdgradoygrupoNavigation)
                    .WithMany(p => p.Registrosalumnos)
                    .HasForeignKey(d => d.Idgradoygrupo)
                    .HasConstraintName("FK_GRADOYGRUPO");

                entity.HasOne(d => d.IdproyectosNavigation)
                    .WithMany(p => p.Registrosalumnos)
                    .HasForeignKey(d => d.Idproyectos)
                    .HasConstraintName("FK_IDPROYECTOALUMNO");

                entity.HasOne(d => d.IdstatusNavigation)
                    .WithMany(p => p.Registrosalumnos)
                    .HasForeignKey(d => d.Idstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IDSTATUSALUMNO");
            });

            modelBuilder.Entity<Registrosprofesore>(entity =>
            {
                entity.HasKey(e => e.Idprofesor)
                    .HasName("PK_IDPROFESOR");

                entity.ToTable("REGISTROSPROFESORES");

                entity.Property(e => e.Idprofesor).HasColumnName("IDPROFESOR");

                entity.Property(e => e.Apellidom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOM");

                entity.Property(e => e.Apellidop)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOP");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTRASEÑA");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Fechanac)
                    .HasColumnType("date")
                    .HasColumnName("FECHANAC");

                entity.Property(e => e.Fotoprofesor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FOTOPROFESOR");

                entity.Property(e => e.Idcargo).HasColumnName("IDCARGO");

                entity.Property(e => e.Iddivisiones).HasColumnName("IDDIVISIONES");

                entity.Property(e => e.Idproyectos).HasColumnName("IDPROYECTOS");

                entity.Property(e => e.Idstatus).HasColumnName("IDSTATUS");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO");

                entity.HasOne(d => d.IdcargoNavigation)
                    .WithMany(p => p.Registrosprofesores)
                    .HasForeignKey(d => d.Idcargo)
                    .HasConstraintName("FK_CARGOPROFESOR");

                entity.HasOne(d => d.IddivisionesNavigation)
                    .WithMany(p => p.Registrosprofesores)
                    .HasForeignKey(d => d.Iddivisiones)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IDDIVISIONPROFESOR");

                entity.HasOne(d => d.IdproyectosNavigation)
                    .WithMany(p => p.Registrosprofesores)
                    .HasForeignKey(d => d.Idproyectos)
                    .HasConstraintName("FK_IDPROYECTOPROFESOR");

                entity.HasOne(d => d.IdstatusNavigation)
                    .WithMany(p => p.Registrosprofesores)
                    .HasForeignKey(d => d.Idstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IDSTATUSPROFESOR");
            });

            modelBuilder.Entity<Statususuario>(entity =>
            {
                entity.HasKey(e => e.Idstatus)
                    .HasName("PK_IDSTATUS");

                entity.ToTable("STATUSUSUARIO");

                entity.Property(e => e.Idstatus).HasColumnName("IDSTATUS");

                entity.Property(e => e.Statususuario1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUSUSUARIO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
