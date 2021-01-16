namespace Project_QLPT.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLPT_DB : DbContext
    {
        public QLPT_DB()
            : base("name=QLPT_DB")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<NGUOITHUE> NGUOITHUEs { get; set; }
        public virtual DbSet<PHIEUTHUE> PHIEUTHUEs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.USR)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.PWD)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .Property(e => e.IDNGUOITHUE)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .Property(e => e.NAMSINH)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .HasMany(e => e.PHIEUTHUEs)
                .WithOptional(e => e.NGUOITHUE)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PHIEUTHUE>()
                .Property(e => e.IDPHIEU)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHUE>()
                .Property(e => e.IDPHONG)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHUE>()
                .Property(e => e.IDNGUOITHUE)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.IDPHONG)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUTHUEs)
                .WithOptional(e => e.PHONG)
                .WillCascadeOnDelete();
        }
    }
}
