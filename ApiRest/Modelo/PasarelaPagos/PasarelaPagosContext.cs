using System;
using ApiRest.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiRest.Modelo.PasarelaPagos
{
    public partial class PasarelaPagosContext : DbContext
    {
        public PasarelaPagosContext()
        {
        }

        public PasarelaPagosContext(DbContextOptions<PasarelaPagosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActividadesEconomica> ActividadesEconomicas { get; set; }
        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<Cartera> Carteras { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Comercio> Comercios { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Franquicia> Franquicias { get; set; }
        public virtual DbSet<Transaccione> Transacciones { get; set; }
        public virtual DbSet<VistaCarterasPendientesPorPago> VistaCarterasPendientesPorPagos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionService.PasarelaPagosConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<ActividadesEconomica>(entity =>
            {
                entity.HasKey(e => e.IdActividadEconomica)
                    .HasName("PK_ActividadesEconomicas_IdActividadEconomica");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mcc)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("MCC");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(e => e.IdBanco)
                    .HasName("PK_Banco_IdBanco");

                entity.Property(e => e.Banco1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Banco");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Cartera>(entity =>
            {
                entity.HasKey(e => e.IdCartera)
                    .HasName("PK_Cartera_IdCartera");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Valor).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Carteras)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__Carteras__IdClie__398D8EEE");

                entity.HasOne(d => d.IdComercioNavigation)
                    .WithMany(p => p.Carteras)
                    .HasForeignKey(d => d.IdComercio)
                    .HasConstraintName("FK__Carteras__IdCome__38996AB5");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK_Cliente_IdCliente");

                entity.Property(e => e.Celular)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Genero)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NombresCliente)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comercio>(entity =>
            {
                entity.HasKey(e => e.IdComercio)
                    .HasName("PK_Comercio_IdComercio");

                entity.Property(e => e.CamaraComercio).IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NitComercio)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreComercio)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdActividadEconomicaNavigation)
                    .WithMany(p => p.Comercios)
                    .HasForeignKey(d => d.IdActividadEconomica)
                    .HasConstraintName("FK__Comercios__IdAct__31EC6D26");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK_Estados_IdEstado");

                entity.Property(e => e.Estado1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Estado");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Franquicia>(entity =>
            {
                entity.HasKey(e => e.IdFranquicia)
                    .HasName("PK_Franquicia_IdFranquicia");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Franquicia1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Franquicia");
            });

            modelBuilder.Entity<Transaccione>(entity =>
            {
                entity.HasKey(e => e.IdTransaccion)
                    .HasName("PK_Transacciones_IdTransaccion");

                entity.Property(e => e.CelularUsuario)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoUsuario)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Cvv2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CVV2");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaVencimientoTarjeta)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTarjeta)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdBancoNavigation)
                    .WithMany(p => p.Transacciones)
                    .HasForeignKey(d => d.IdBanco)
                    .HasConstraintName("FK__Transacci__IdBan__3F466844");

                entity.HasOne(d => d.IdCarteraNavigation)
                    .WithMany(p => p.Transacciones)
                    .HasForeignKey(d => d.IdCartera)
                    .HasConstraintName("FK__Transacci__IdCar__3D5E1FD2");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Transacciones)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK__Transacci__IdEst__403A8C7D");

                entity.HasOne(d => d.IdFranquiciaNavigation)
                    .WithMany(p => p.Transacciones)
                    .HasForeignKey(d => d.IdFranquicia)
                    .HasConstraintName("FK__Transacci__IdFra__3E52440B");
            });

            modelBuilder.Entity<VistaCarterasPendientesPorPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vista_CarterasPendientesPorPago");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Valor).HasColumnType("numeric(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
