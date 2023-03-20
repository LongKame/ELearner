using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EnglishApp.Models
{
    public partial class LearningEnglishContext : DbContext
    {
        public LearningEnglishContext()
        {
        }

        public LearningEnglishContext(DbContextOptions<LearningEnglishContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SentenceStructure> SentenceStructures { get; set; }
        public virtual DbSet<TestLearning> TestLearnings { get; set; }
        public virtual DbSet<VocabInLesson> VocabInLessons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost;database=LearningEnglish;Trusted_Connection=True;user=sa;password=sa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .HasColumnName("contact_no");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("user_name");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Account__role_id__38996AB5");
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer1)
                    .IsRequired()
                    .HasColumnName("Answer");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Answer__Correct__75A278F5");
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.ToTable("Lesson");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Lesson1)
                    .IsRequired()
                    .HasColumnName("lesson");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.PartId).HasColumnName("part_id");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lesson__level_id__403A8C7D");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lesson__part_id__3F466844");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.ToTable("Level");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image");

                entity.Property(e => e.Level1)
                    .IsRequired()
                    .HasColumnName("level");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.ToTable("Part");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasColumnName("part_name");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.Question1)
                    .IsRequired()
                    .HasColumnName("Question");

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.LessonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Question__lesson__72C60C4A");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<SentenceStructure>(entity =>
            {
                entity.ToTable("SentenceStructure");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasColumnName("level");

                entity.Property(e => e.Sentence).HasColumnName("sentence");

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.SentenceStructures)
                    .HasForeignKey(d => d.LessonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SentenceS__lesso__45F365D3");
            });

            modelBuilder.Entity<TestLearning>(entity =>
            {
                entity.ToTable("TestLearning");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnswerA).IsRequired();

                entity.Property(e => e.AnswerB).IsRequired();

                entity.Property(e => e.AnswerC).IsRequired();

                entity.Property(e => e.AnswerD).IsRequired();

                entity.Property(e => e.Correct).IsRequired();

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.Question).IsRequired();

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.TestLearnings)
                    .HasForeignKey(d => d.LessonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TestLearn__lesso__534D60F1");
            });

            modelBuilder.Entity<VocabInLesson>(entity =>
            {
                entity.ToTable("VocabInLesson");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Antonymous).HasColumnName("antonymous");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.Meaning).HasColumnName("meaning");

                entity.Property(e => e.Pronunciation).HasColumnName("pronunciation");

                entity.Property(e => e.Synonymous).HasColumnName("synonymous");

                entity.Property(e => e.Word).HasColumnName("word");

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.VocabInLessons)
                    .HasForeignKey(d => d.LessonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VocabInLe__lesso__4316F928");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
