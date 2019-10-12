using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ControlTesisCore.Models.BD
{
    public partial class controltesisContext : DbContext
    {
        public controltesisContext()
        {
        }

        public controltesisContext(DbContextOptions<controltesisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<CabezaGrupo> CabezaGrupo { get; set; }
        public virtual DbSet<Carrera> Carrera { get; set; }
        public virtual DbSet<CuerpoGrupo> CuerpoGrupo { get; set; }
        public virtual DbSet<Docente> Docente { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Facultad> Facultad { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=controltesis;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.HasKey(e => e.Idadmin)
                    .HasName("PK__administ__5B93BD6E65BAA8A2");

                entity.ToTable("administrador");

                entity.Property(e => e.Idadmin).HasColumnName("idadmin");

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.Administrador)
                    .HasForeignKey(d => d.Idusuario)
                    .HasConstraintName("fk_usuario_admin");
            });

            modelBuilder.Entity<CabezaGrupo>(entity =>
            {
                entity.HasKey(e => e.Idgrupo)
                    .HasName("PK__cabeza_g__F8D5E6CE7CD9DA91");

                entity.ToTable("cabeza_grupo");

                entity.Property(e => e.Idgrupo).HasColumnName("idgrupo");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Iddocente).HasColumnName("iddocente");

                entity.Property(e => e.Nota)
                    .HasColumnName("nota")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Tema)
                    .HasColumnName("tema")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IddocenteNavigation)
                    .WithMany(p => p.CabezaGrupo)
                    .HasForeignKey(d => d.Iddocente)
                    .HasConstraintName("fk_docente_grupo");
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.HasKey(e => e.Idcarrera)
                    .HasName("PK__carrera__B719185026CCC174");

                entity.ToTable("carrera");

                entity.Property(e => e.Idcarrera).HasColumnName("idcarrera");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Idfacultad).HasColumnName("idfacultad");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plans)
                    .HasColumnName("plans")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdfacultadNavigation)
                    .WithMany(p => p.Carrera)
                    .HasForeignKey(d => d.Idfacultad)
                    .HasConstraintName("fk_facultad_carrera");
            });

            modelBuilder.Entity<CuerpoGrupo>(entity =>
            {
                entity.HasKey(e => e.Iddetalle)
                    .HasName("PK__cuerpo_g__6FE8F71F34EEDDFE");

                entity.ToTable("cuerpo_grupo");

                entity.Property(e => e.Iddetalle).HasColumnName("iddetalle");

                entity.Property(e => e.Idestudiante).HasColumnName("idestudiante");

                entity.Property(e => e.Idgrupo).HasColumnName("idgrupo");

                entity.HasOne(d => d.IdestudianteNavigation)
                    .WithMany(p => p.CuerpoGrupo)
                    .HasForeignKey(d => d.Idestudiante)
                    .HasConstraintName("fk_estudiante_cuerpo");

                entity.HasOne(d => d.IdgrupoNavigation)
                    .WithMany(p => p.CuerpoGrupo)
                    .HasForeignKey(d => d.Idgrupo)
                    .HasConstraintName("fk_grupo_cuerpo");
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.HasKey(e => e.Iddocente)
                    .HasName("PK__docente__57C6C46E545F5029");

                entity.ToTable("docente");

                entity.Property(e => e.Iddocente).HasColumnName("iddocente");

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.NSeguro)
                    .HasColumnName("n_seguro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.Docente)
                    .HasForeignKey(d => d.Idusuario)
                    .HasConstraintName("fk_usuario_docente");
            });

            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.Idestudiante)
                    .HasName("PK__estudian__DE1D9AFA4AE324CA");

                entity.ToTable("estudiante");

                entity.HasIndex(e => e.Nombre)
                    .HasName("NombreEstudiante_IndiceNoCluster");

                entity.Property(e => e.Idestudiante).HasColumnName("idestudiante");

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaN)
                    .HasColumnName("fecha_n")
                    .HasColumnType("date");

                entity.Property(e => e.FechaR)
                    .HasColumnName("fecha_r")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idcarrera).HasColumnName("idcarrera");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcarreraNavigation)
                    .WithMany(p => p.Estudiante)
                    .HasForeignKey(d => d.Idcarrera)
                    .HasConstraintName("fk_carrera_estudiante");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.Estudiante)
                    .HasForeignKey(d => d.Idusuario)
                    .HasConstraintName("fk_usuario_estudiante");
            });

            modelBuilder.Entity<Facultad>(entity =>
            {
                entity.HasKey(e => e.Idfacultad)
                    .HasName("PK__facultad__16D32FD1FE8A3F5E");

                entity.ToTable("facultad");

                entity.Property(e => e.Idfacultad).HasColumnName("idfacultad");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("PK__usuario__080A97431AD1F225");

                entity.ToTable("usuario");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Carnet)
                    .HasColumnName("carnet")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contraseña)
                    .HasColumnName("contraseña")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rol).HasColumnName("rol");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
