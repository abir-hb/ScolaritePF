using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScolariteWeb
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EspEnseignant> EspEnseignant { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id=scopfeS;Password=esprit;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "SCOPFES");

            modelBuilder.Entity<EspEnseignant>(entity =>
            {
                entity.HasKey(e => e.IdEns)
                    .HasName("SYS_C0012740");

                entity.ToTable("ESP_ENSEIGNANT");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeEns)
                    .HasColumnName("CHARGE_ENS")
                    .HasColumnType("NUMBER(7,2)");

                entity.Property(e => e.Cin)
                    .HasColumnName("CIN")
                    .HasColumnType("NUMBER(19,2)");

                entity.Property(e => e.CnssEns)
                    .HasColumnName("CNSS_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeGradeActuel)
                    .HasColumnName("CODE_GRADE_ACTUEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeGradeEntree)
                    .HasColumnName("CODE_GRADE_ENTREE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateModifyJwtPwd)
                    .HasColumnName("DATE_MODIFY_JWT_PWD")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.DateRec)
                    .HasColumnName("DATE_REC")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCivilEns)
                    .HasColumnName("ETAT_CIVIL_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LibGradeActuelle)
                    .HasColumnName("LIB_GRADE_ACTUELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LibGradeEntree)
                    .HasColumnName("LIB_GRADE_ENTREE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailEns)
                    .HasColumnName("MAIL_ENS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NbHeureEns)
                    .HasColumnName("NB_HEURE_ENS")
                    .HasColumnType("NUMBER(7,2)");

                entity.Property(e => e.Niveau)
                    .HasColumnName("NIVEAU")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomEns)
                    .HasColumnName("NOM_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomEns)
                    .HasColumnName("PRENOM_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PwdEns)
                    .HasColumnName("PWD_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PwdInit)
                    .HasColumnName("PWD_INIT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PwdJwtEnseignant)
                    .HasColumnName("PWD_JWT_ENSEIGNANT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SexeEns)
                    .HasColumnName("SEXE_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("TEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEns)
                    .HasColumnName("TYPE_ENS")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
